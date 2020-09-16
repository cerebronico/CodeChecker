Imports System.ComponentModel
Imports System.Globalization
Imports System.IO.Ports
Imports System.Text
Imports System.Threading
Imports CodeChecker.My
Imports CodeChecker.My.Resources
Imports Keyence.AutoID.SDK


Public Class Verifier
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32"(ByRef oldValue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32"(ByRef oldValue As Long) As Boolean

    'delegateUserControl is for controlling UserControl from other threads.
    Private Delegate Sub DelegateUserControl(str As String)

    Public Property Osk1 as String = "C:\Windows\System32\osk.exe"
    Public Property DtStyle as String = "dddd, dd MMMM yyyy"

    Public Property MReader as ReaderAccessor = New ReaderAccessor()

    Public Property DtfInfo as CultureInfo 'DateTimeFormatInfo
    Public Property Dt1 as String = Nothing

    Public Property NewBarcodeReceived as Boolean = False


    Private Sub CodeChecker_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        CheckForExistingInstance()

#If  DEBUG
        WindowState = vbNormal
#End If

        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-EC")

        Dim dateFormat As DateTimeFormatInfo = CultureInfo.GetCultureInfo("es-EC").DateTimeFormat

        Thread.CurrentThread.CurrentCulture.DateTimeFormat = dateFormat

        PictureBoxQr.Visible = False
        PictureBoxSku.Visible = False
        TextBoxTOn.Text = MySettings.Default.var_TOn
        TextBoxTOff.Text = MySettings.Default.var_TOFF
        TextBoxTimeOut.Text = MySettings.Default.var_TOUT

        LabelValidas.Text = 0
        LabelBad1DCode.Text = 0
        LabelBad2DCode.Text = 0
        LabelNoCode.Text = 0

        DtfInfo = New CultureInfo("es-EC") ' DateTimeFormatInfo.InvariantInfo
        Dt1 = DateTime.Now.ToString(DtStyle, DtfInfo)

        LabelDate.Text = Dt1

        ActiveControl = TextBoxSKUScanned
        TextBoxSKUScanned.SelectAll()


        Try
            If Not SerialPortIO.IsOpen Then
                SerialPortIO.Open()
                SerialPortIO.NewLine = vbCrLf
            End If


        Catch ex As Exception : MsgBox(ex.Message)
            MessageBox.Show("Error al acceder al Puerto Serial: " & ex.Message)
        End Try
    End Sub

    Private Sub Verifier_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If SerialPortIO.IsOpen Then
            SerialPortIO.Close()
        End If

        ' liveviewForm1.Dispose()
        MReader.Dispose()
    End Sub

    Private Sub ButtonOperator_Click(sender As Object, e As EventArgs) Handles ButtonOperator.Click
        Login.ShowDialog()
    End Sub

    Private Sub ButtonSetParameters_Click(sender As Object, e As EventArgs) Handles ButtonSetParameters.Click

        Try
            MySettings.Default.var_TOn = TextBoxTOn.Text
            MySettings.Default.var_TOFF = TextBoxTOff.Text
            MySettings.Default.var_TOUT = TextBoxTimeOut.Text

            dim cmd as String = "P " & TextBoxTimeOut.Text & " " & TextBoxTOn.Text & " " & TextBoxTOff.Text & vbCr

            Settings.Save()
            Settings.Reload()

            TextBoxSKUScanned.Focus()

            If SerialPortIO.IsOpen
                SerialPortIO.WriteLine(cmd)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al actualizar " & ex.Message)
        End Try
    End Sub

    Private Sub ShowEmoticons(choice As Integer)

        Select Case choice
            Case 0
                PictureBoxSku.Image = right_or_wrong_3
                PictureBoxQr.Image = right_or_wrong_3

            Case 1
                PictureBoxSku.Image = right_or_wrong_2
                PictureBoxQr.Image = right_or_wrong_3
            Case 2
                PictureBoxSku.Image = right_or_wrong_3
                PictureBoxQr.Image = right_or_wrong_2
            Case 3
                PictureBoxSku.Image = right_or_wrong_2
                PictureBoxQr.Image = right_or_wrong_2
        End Select

        If PictureBoxSku.InvokeRequired
            PictureBoxSku.Invoke(DirectCast(Sub() PictureBoxSku.Visible = True, MethodInvoker))
        End If

        If PictureBoxQr.InvokeRequired
            PictureBoxQr.Invoke(DirectCast(Sub() PictureBoxQr.Visible = True, MethodInvoker))
        End If
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Try
            if SerialPortIO.IsOpen
                SerialPortIO.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Close()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Dim qrCode As String

        qrCode = "13" + Format(DateTimePickerProduction.value, "yyMMdd") + "15" + Format(DateTimePickerExpiry.Value, "yyMMdd") + "10" + TextBoxBatch.Text + TextBoxCode.Text

        ToolStripStatusLabelUserEnteredCode.Text = qrCode
        'Computer.Audio.Play("\Resources\tos-redalert.wav")

        With me
            .TextBoxSKU.Enabled = False
            .TextBoxBatch.Enabled = False
            .TextBoxCode.Enabled = False
            .DateTimePickerProduction.Enabled = False
            .DateTimePickerExpiry.Enabled = False

            If .ButtonStart.Text = "INICIAR"
                .ButtonStart.Text = "TERMINAR"
                SerialPortIO.WriteLine("C")
                SerialPortIO.WriteLine("G")
            Else
                .ButtonStart.Text = "INICIAR"
                SerialPortIO.WriteLine("S")
            End If

            .ButtonSave2USB.Enabled = False

            .TextBoxSKUScanned.Focus()

            MySettings.Default.SKU = TextBoxSKU.Text

            Settings.Save()
            Settings.Reload()

            'Stop liveview.
            liveviewForm1.EndReceive()
            'Start liveview.
            liveviewForm1.BeginReceive()

            'Set ip address of ReaderAccessor.
            MReader.IpAddress = "192.168.100.100"
            'Connect TCP/IP.
            MReader.Connect(AddressOf ReceivedDataAction)

        End With
    End Sub

    Private Sub ReceivedDataAction(data As Byte())
        'Define received data actions here.Defined actions work asynchronously.
        '"ReceivedDataWrite" works when reading data was received.
        BeginInvoke(New DelegateUserControl(AddressOf ReceivedDataWrite), Encoding.ASCII.GetString(data))
    End Sub

    Private Sub SerialPortIO_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPortIO.DataReceived

        Try
            Dim buffer as String, myData As String, s() As String
            buffer = SerialPortIO.ReadLine()

            console.WriteLine(buffer)

            If Microsoft.VisualBasic.Left(buffer, 1) = ":"
                myData = Mid(buffer, 2)

                s = myData.Split(New Char() {","c})

                if s.Length = 1 and s(0) = "X" Then

                    ReceivedDataWrite(MReader.ExecCommand("LON"))

                    If PictureBox1.InvokeRequired Then
                        PictureBox1.Invoke(DirectCast(Sub() PictureBox1.Image = Verde_f02, MethodInvoker))
                    End If

                Else if s.Length = 5 Then

                    ReceivedDataWrite(MReader.ExecCommand("LOFF"))

                    If PictureBox1.InvokeRequired Then
                        PictureBox1.Invoke(DirectCast(Sub() PictureBox1.Image = Verde_f01, MethodInvoker))
                    End If

                    If LabelNoCode.InvokeRequired Then
                        LabelNoCode.Invoke(DirectCast(Sub() LabelNoCode.Text = s(0), MethodInvoker))
                    End If

                    If LabelBad1DCode.InvokeRequired Then
                        LabelBad1DCode.Invoke(DirectCast(Sub() LabelBad1DCode.Text = s(1), MethodInvoker))
                    End If

                    If LabelBad2DCode.InvokeRequired Then
                        LabelBad2DCode.Invoke(DirectCast(Sub() LabelBad2DCode.Text = s(2), MethodInvoker))
                    End If

                    If LabelValidas.InvokeRequired
                        LabelValidas.Invoke(DirectCast(Sub() LabelValidas.Text = s(3), MethodInvoker))
                    End If

                    If LabelTotalCajas.InvokeRequired
                        LabelTotalCajas.Invoke(DirectCast(Sub() LabelTotalCajas.Text = s(4), MethodInvoker))
                    End If

                    If PictureBoxSku.InvokeRequired
                        PictureBoxSku.Invoke(DirectCast(Sub() PictureBoxSku.Visible = False, MethodInvoker))
                    End If

                    If PictureBoxQr.InvokeRequired
                        PictureBoxQr.Invoke(DirectCast(Sub() PictureBoxQr.Visible = False, MethodInvoker))
                    End If

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("error en dato de IO: " & ex.Message)
        End Try
    End Sub

    Private Sub ReceivedDataWrite(receivedData As String)
        Dim qr as Integer, barcode As Integer
        if String.IsNullOrEmpty(receivedData) then Return

        receivedData = receivedData.Replace(vbCr, "").Replace(vbLf, "")

        If receivedData = "ERROR" Then
            SerialPortIO.WriteLine("B0")  ' wrong QR code
            SerialPortIO.WriteLine("Q0")  ' wrong QR code
            ToolStripStatusLabelScannedQr.Text = "NO SE PUDO LEER EL CODIGO"
            ToolStripStatusLabelScannerBarcode.Text = "ERROR"

            If TextBoxSKUScanned.InvokeRequired
                TextBoxSKUScanned.Invoke(DirectCast(Sub() TextBoxSKUScanned.text = "NO VISTO", MethodInvoker))
            End If

            ShowEmoticons(0)

        Else
            Dim s As String() = receivedData.Split(New Char() {","c})

            ToolStripStatusLabelScannedQr.Text = s(0)
            ToolStripStatusLabelScannerBarcode.Text = s(1)

            If s(0).Length = 32 or s(0).Length = 33 Then ' QR code
                If ToolStripStatusLabelUserEnteredCode.Text = s(0)
                    SerialPortIO.WriteLine("Q2")  ' QR code correct
                    qr = 2
                Else
                    SerialPortIO.WriteLine("Q0")  ' wrong QR code
                    qr = 0
                End If
            End If

            dim batch as String = Mid(s(0), 19, 8)

            If TextBoxBatchScanned.InvokeRequired
                TextBoxBatchScanned.Invoke(DirectCast(Sub() TextBoxBatchScanned.text = batch, MethodInvoker))
            End If

            Dim code As String = Mid(s(0), 27)

            If TextBoxCodeScanned.InvokeRequired
                TextBoxCodeScanned.Invoke(DirectCast(Sub() TextBoxCodeScanned.Text = code, MethodInvoker))
            End If

            Dim productionDate as String = Mid(s(0), 7, 2) & "/" & Mid(s(0), 5, 2) & "/" & Mid(s(0), 3, 2)

            If TextBoxProductionDateScanned.InvokeRequired
                TextBoxProductionDateScanned.Invoke(DirectCast(Sub() TextBoxProductionDateScanned.Text = productionDate, MethodInvoker))
            End If

            Dim expiryDate as String = Mid(s(0), 15, 2) & "/" & Mid(s(0), 13, 2) & "/" & Mid(s(0), 11, 2)

            if TextBoxExpiryDateScanned.InvokeRequired
                TextBoxExpiryDateScanned.Invoke(DirectCast(Sub() TextBoxExpiryDateScanned.Text = expiryDate, MethodInvoker))
            End If

            If s(1).Length = 13 ' barcode length

                If TextBoxSKUScanned.InvokeRequired
                    TextBoxSKUScanned.Invoke(DirectCast(Sub() TextBoxSKUScanned.text = s(1), MethodInvoker))
                End If

                If TextBoxSKU.Text = s(1) ' barcode correct!
                    SerialPortIO.WriteLine("B1")
                    barcode = 1
                Else
                    SerialPortIO.WriteLine("B0") ' wrong barcode
                    barcode = 0
                End If

            End If

            ShowEmoticons(qr + barcode)

        End If

        NewBarcodeReceived = True
    End Sub

    Private Sub Verifier_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If SerialPortIO.IsOpen Then
            ToolStripStatusLabel1.Text = "Conectado"
            ToolStripStatusLabel1.BackColor = Color.DarkGreen
        Else
            ToolStripStatusLabel1.Text = "No Conectado"
            ToolStripStatusLabel1.BackColor = Color.DarkRed
        End If
    End Sub

    Public Sub CheckForExistingInstance()
        'Get number of processes of you program
        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then

            MessageBox.Show("El programa ya se está ejecutando", "Instancias multiples no se permiten", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Function MyZero(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim txt as String, voids as Integer
        Static barcodeRemnant As Integer

        txt = MyZero(DateTime.Now.Hour)
        txt &= ":" & MyZero(DateTime.Now.Minute)
        txt &= ":" & MyZero(DateTime.Now.Second)
        LabelTime.Text = txt

        Dim dt As String = DateTime.Now.ToString(DtStyle, DtfInfo)
        LabelDate.Text = dt

        If NewBarcodeReceived then
            if barcodeRemnant >= 8
                TextBoxSKUScanned.Text = Nothing
                TextBoxBatchScanned.Text = Nothing
                TextBoxCodeScanned.Text = Nothing
                TextBoxExpiryDateScanned.Text = Nothing
                TextBoxProductionDateScanned.Text = Nothing

                NewBarcodeReceived = False
                barcodeRemnant = 0
            Else
                barcodeRemnant += 1
            End If
        End If

        If CInt(LabelTotalCajas.Text) > 0 Then
            voids = 100*(Cint(LabelBad1DCode.Text) + CInt(LabelBad2DCode.Text) + CInt(LabelNoCode.Text))/CInt(LabelTotalCajas.Text)
        End If

        LabelVoids.Text = "No válidas: " & voids.ToString() & "%"
    End Sub

    Private Sub DateTimePickerProduction_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerProduction.ValueChanged
        DateTimePickerExpiry.Value = DateAdd("m", 10, DateTimePickerProduction.Value)
    End Sub

    Private Sub TextBoxBatch_Enter(sender As Object, e As EventArgs) Handles TextBoxBatch.Enter, TextBoxSKU.Enter, TextBoxCode.Enter
        If textBoxBatch.TabIndex > 0 Then
            Dim old As Long
            If Environment.Is64BitOperatingSystem Then
                If Wow64DisableWow64FsRedirection(old) Then
                    Process.Start(Osk1)
                    Wow64EnableWow64FsRedirection(old)
                End If
            Else
                Process.Start(Osk1)
            End If
        End If
    End Sub
End Class
