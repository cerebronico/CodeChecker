Imports System.ComponentModel
Imports System.IO
Imports System.Globalization
Imports Keyence.AutoID.SDK
imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Public Class Verifier
    Dim ReadOnly _mReader As ReaderAccessor = New ReaderAccessor()
    Dim _newBarcodeReceived as Boolean = False
    Dim _dt as String = Nothing
    Dim _dtfInfo As CultureInfo 'DateTimeFormatInfo
    Dim _dtStyle as String = "dddd, dd MMMM yyyy"

    Private Sub CodeChecker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 
        
        CheckForExistingInstance()

        #If  DEBUG
            Me.WindowState = vbNormal   
        #End If
        
        Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("es-EC")

        Dim dateFormat As DateTimeFormatInfo = CultureInfo.GetCultureInfo("es-EC").DateTimeFormat   

        Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat = dateFormat

        PictureBoxQr.Visible = False
        PictureBoxSku.Visible = False
        TextBoxTOn.Text = My.MySettings.Default.var_TOn
        TextBoxTOff.Text = My.MySettings.Default.var_TOFF
        TextBoxTimeOut.Text = My.MySettings.Default.var_TOUT

        LabelValidas.Text = 0
        LabelBad1DCode.Text = 0
        LabelBad2DCode.Text = 0
        LabelNoCode.Text = 0

        _dtfInfo = New CultureInfo("es-EC") ' DateTimeFormatInfo.InvariantInfo
        _dt = DateTime.Now.ToString(_dtStyle, _dtfInfo)

        LabelDate.Text = _dt

        Me.ActiveControl = Me.TextBoxSKUScanned
        TextBoxSKUScanned.SelectAll()


        Try
            If Not SerialPortIO.IsOpen Then
                SerialPortIO.Open()
                SerialPortIO.NewLine=vbCrLf
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
        _mReader.Dispose()

    End Sub


    Private Sub ButtonOperator_Click(sender As Object, e As EventArgs) Handles ButtonOperator.Click   
        Login.ShowDialog()
    End Sub

    Private Sub ButtonSetParameters_Click(sender As Object, e As EventArgs) Handles ButtonSetParameters.Click  

        Try
            My.MySettings.Default.var_TOn = TextBoxTOn.Text
            My.MySettings.Default.var_TOFF = TextBoxTOff.Text
            My.MySettings.Default.var_TOUT = TextBoxTimeOut.Text
            
            dim cmd as String = "P " & TextBoxTimeOut.Text & " " & TextBoxTOn.Text & " " & TextBoxTOff.Text & vbCr
            
            My.Settings.Save()
            My.Settings.Reload()

            TextBoxSKUScanned.Focus()

            If SerialPortIO.IsOpen
                SerialPortIO.WriteLine(cmd)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al actualizar " & ex.Message)
        End Try
    End Sub


    'Private Sub SerialPortScanner_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SerialPortScanner.DataReceived  
    '    Static buffer As String, qr as Integer, barcode As Integer

    '    Try
    '        Do
    '            buffer = SerialPortScanner.ReadLine()

    '            Console.WriteLine(buffer.Length)
    '            Console.WriteLine(buffer)

    '            buffer = buffer.Replace(vbCr, "").Replace(vbLf, "")
    '            Console.WriteLine(buffer.Length)
    '            Console.WriteLine(buffer)

    '            If buffer Is Nothing Then
    '                Exit Do
    '            Else if buffer = "ERROR" Then
    '                SerialPortIO.WriteLine("B0")  ' wrong QR code
    '                SerialPortIO.WriteLine("Q0")  ' wrong QR code
    '                ToolStripStatusLabelScannedQr.Text  = "ERROR"
    '                ToolStripStatusLabelScannerBarcode.Text = "ERROR"

    '                ShowEmoticons(0)

    '                Exit Do
                
    '            Else If buffer.Length = 46 Or buffer.Length = 47 Then
    '                Dim s As String() = buffer.Split(New Char() {","c})

    '                ToolStripStatusLabelScannedQr.Text = s(0)
    '                ToolStripStatusLabelScannerBarcode.Text = s(1)

    '                If s(0).Length = 32 or s(0).Length = 33 Then ' QR code
    '                    If ToolStripStatusLabelUserEnteredCode.Text = s(0)
    '                        SerialPortIO.WriteLine("Q2")  ' QR code correct
    '                        qr = 2
    '                    Else
    '                        SerialPortIO.WriteLine("Q0")  ' wrong QR code
    '                        qr = 0
    '                    End If
    '                End If

    '                dim batch as String = Mid(s(0), 19, 8)

    '                If TextBoxBatchScanned.InvokeRequired
    '                    TextBoxBatchScanned.Invoke(DirectCast(Sub() TextBoxBatchScanned.text = batch, MethodInvoker))
    '                End If

    '                Dim code As String = Mid(s(0), 27)

    '                If TextBoxCodeScanned.InvokeRequired
    '                    TextBoxCodeScanned.Invoke(DirectCast(Sub() TextBoxCodeScanned.Text = code, MethodInvoker))
    '                End If

    '                Dim productionDate as String = Mid(s(0), 7, 2) & "/" & Mid(s(0), 5, 2) & _
    '                                               "/" & Mid(s(0), 3, 2)

    '                If TextBoxProductionDateScanned.InvokeRequired
    '                    TextBoxProductionDateScanned.Invoke(DirectCast(Sub() TextBoxProductionDateScanned.Text = productionDate, MethodInvoker))
    '                End If

    '                Dim expiryDate as String = Mid(s(0), 15, 2) & "/" & Mid(s(0), 13, 2) & _
    '                                           "/" & Mid(s(0), 11, 2)

    '                if TextBoxExpiryDateScanned.InvokeRequired
    '                    TextBoxExpiryDateScanned.Invoke(DirectCast(Sub() TextBoxExpiryDateScanned.Text = expiryDate, MethodInvoker))
    '                End If

    '                If s(1).Length = 13 ' barcode length

    '                    If TextBoxSKUScanned.InvokeRequired
    '                        TextBoxSKUScanned.Invoke(DirectCast(Sub() TextBoxSKUScanned.text = s(1), MethodInvoker))
    '                        'TextBoxSKUScanned.Invoke(DirectCast(Sub() TextBoxSKUScanned.text = buffer, MethodInvoker))
    '                    End If

    '                    If TextBoxSKU.Text = s(1) ' barcode correct!
    '                        SerialPortIO.WriteLine("B1")
    '                        barcode = 1
                            
    '                    Else
    '                        SerialPortIO.WriteLine("B0") ' wrong barcode
    '                        barcode = 0
                            
    '                    End If

    '                    _newBarcodeReceived = True

    '                End If

    '                ShowEmoticons(qr + barcode)

    '                Exit Do

    '            End If
    '        Loop

    '    Catch ex As Exception

    '        MessageBox.Show("Scanner Error: " & ex.Message)

    '    finally

    '        buffer = Nothing
    '    End Try

    'End Sub

    Private Sub ShowEmoticons(choice As Integer)

        Select Case choice
            Case 0
                PictureBoxSku.Image = CodeChecker.My.Resources.Resources.right_or_wrong_3
                PictureBoxQr.Image = CodeChecker.My.Resources.Resources.right_or_wrong_3
            Case 1
                PictureBoxSku.Image = CodeChecker.My.Resources.Resources.right_or_wrong_2
                PictureBoxQr.Image = CodeChecker.My.Resources.Resources.right_or_wrong_3
            Case 2
                PictureBoxSku.Image = CodeChecker.My.Resources.Resources.right_or_wrong_3
                PictureBoxQr.Image = CodeChecker.My.Resources.Resources.right_or_wrong_2
            Case 3
                PictureBoxSku.Image = CodeChecker.My.Resources.Resources.right_or_wrong_2
                PictureBoxQr.Image = CodeChecker.My.Resources.Resources.right_or_wrong_2
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

        qrCode = "13" + Format(DateTimePickerProduction.value, "yyMMdd") + _
                 "15" + Format(DateTimePickerExpiry.Value,"yyMMdd") + "10" + _
                 TextBoxBatch.Text + TextBoxCode.Text

        ToolStripStatusLabelUserEnteredCode.Text=qrCode

        With me
            .TextBoxSKU.Enabled=False
            .TextBoxBatch.Enabled=False
            .TextBoxCode.Enabled=False
            .DateTimePickerProduction.Enabled=False
            .DateTimePickerExpiry.Enabled=False

            If .ButtonStart.Text = "INICIAR"
                .ButtonStart.Text = "TERMINAR"
                SerialPortIO.WriteLine("C")
                SerialPortIO.WriteLine("G")
                Else 
                .ButtonStart.Text = "INICIAR"
                SerialPortIO.WriteLine("S")
            End If
            
            .ButtonSave2USB.Enabled=False

            .TextBoxSKUScanned.Focus()

            My.MySettings.Default.SKU = TextBoxSKU.Text

            My.Settings.Save()
            My.Settings.Reload()

            'Stop liveview.
            liveviewForm1.EndReceive()
            'Start liveview.
            liveviewForm1.BeginReceive()

            'Set ip address of ReaderAccessor.
            _mReader.IpAddress = "192.168.100.100"
            'Connect TCP/IP.
            _mReader.Connect(AddressOf ReceivedDataAction)

        End With

    End Sub

    Private Sub ReceivedDataAction(data As Byte())
        'Define received data actions here.Defined actions work asynchronously.
        '"ReceivedDataWrite" works when reading data was received.
        BeginInvoke(New DelegateUserControl(AddressOf ReceivedDataWrite), System.Text.Encoding.ASCII.GetString(data))
    End Sub

    Private Sub SerialPortIO_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SerialPortIO.DataReceived

        Try
            Dim buffer as String, myData As String, s() As String
            buffer = SerialPortIO.ReadLine()
            
            console.WriteLine(buffer)

            If Microsoft.VisualBasic.Left(buffer, 1) = ":"
                myData = Mid(buffer,2)

                s = myData.Split(New Char() {","c})

                if s.Length = 1 and s(0) = "X" Then

                    ' SerialPortScanner.WriteLine("LON" + vbCr)
                    ReceivedDataWrite(_mReader.ExecCommand("LON"))

                    If PictureBox1.InvokeRequired Then
                        PictureBox1.Invoke(DirectCast(Sub() PictureBox1.Image = CodeChecker.My.Resources.Resources.Verde_f02, MethodInvoker))
                    End If
                    
                Else if s.Length = 5 Then

                    'SerialPortScanner.WriteLine("LOFF" + vbCr)
                    ReceivedDataWrite(_mReader.ExecCommand("LOFF"))

                    If PictureBox1.InvokeRequired Then
                        PictureBox1.Invoke(DirectCast(Sub() PictureBox1.Image = CodeChecker.My.Resources.Resources.Verde_f01, MethodInvoker))
                    End If

                    If LabelNoCode.InvokeRequired Then
                        LabelNoCode.Invoke(DirectCast(Sub() LabelNoCode.Text = s(0), MethodInvoker))
                    End If
                    
                    If LabelBad1DCode.InvokeRequired Then
                        LabelBad1DCode.Invoke(DirectCast(Sub() LabelBad1DCode.Text = s(1), MethodInvoker))
                    End If

                    If LabelBad2DCode.InvokeRequired Then
                        LabelBad2DCode.Invoke(DirectCast(Sub() LabelBad2DCode.Text=s(2), MethodInvoker))
                    End If

                    If LabelValidas.InvokeRequired
                        LabelValidas.Invoke(DirectCast(Sub() LabelValidas.Text=s(3), MethodInvoker))
                    End If

                    If LabelTotalCajas.InvokeRequired
                        LabelTotalCajas.Invoke(DirectCast(Sub() LabelTotalCajas.Text= s(4), MethodInvoker))
                    End If

                    If PictureBoxSku.InvokeRequired
                        PictureBoxSku.Invoke(DirectCast(Sub() PictureBoxSku.Visible=False, MethodInvoker))
                    End If

                    If PictureBoxQr.InvokeRequired
                        PictureBoxQr.Invoke(DirectCast(Sub() PictureBoxQr.Visible=False, MethodInvoker))
                    End If

                End If

            End If
            
        Catch ex As Exception
            MessageBox.Show("error en dato de IO: " & ex.Message)
        End Try

    End Sub

    'delegateUserControl is for controlling UserControl from other threads.
    Private Delegate Sub DelegateUserControl(str As String)

    Private Sub ReceivedDataWrite(receivedData As String)
        if String.IsNullOrEmpty(receivedData) then Return

        If receivedData = "ERROR" & vbCr Then
            ToolStripStatusLabelScannedQr.Text = "NO SE PUDO LEER EL CODIGO"
            ToolStripStatusLabelScannerBarcode.Text = ""
        Else 
            Dim s As String() = receivedData.Split(New Char() {","c})
            ToolStripStatusLabelScannedQr.Text = s(0)
            ToolStripStatusLabelScannerBarcode.Text = s(1)
        End If
        
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
        If Process.GetProcessesByName _
               (Process.GetCurrentProcess.ProcessName).Length > 1 Then

            MessageBox.Show _
                ("El programa ya se está ejecutando", _
                 "Instancias multiples no se permiten", _
                 MessageBoxButtons.OK, _
                 MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Function MyZero(ByVal value As Integer ) As String
        Return value.ToString().PadLeft(2, "0")

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim txt as String, voids as Integer
        Static barcodeRemnant As Integer

        txt = MyZero(DateTime.Now.Hour)
        txt &= ":" & MyZero(DateTime.Now.Minute)
        txt &= ":" & MyZero(DateTime.Now.Second)
        LabelTime.Text = txt

        Dim dt As String = DateTime.Now.ToString(_dtStyle, _dtfInfo)
        LabelDate.Text = dt

        If _newBarcodeReceived then 
            if barcodeRemnant >= 8
                TextBoxSKUScanned.Text = Nothing
                TextBoxBatchScanned.Text = Nothing
                TextBoxCodeScanned.Text = Nothing
                TextBoxExpiryDateScanned.Text=Nothing
                TextBoxProductionDateScanned.Text=Nothing

                _newBarcodeReceived = False
                barcodeRemnant=0
            Else 
                barcodeRemnant+=1
            End If
        End If

        If CInt(LabelTotalCajas.Text) > 0 Then
            voids = Cint(LabelBad1DCode.Text) + CInt(LabelBad2DCode.Text) + CInt(LabelNoCode.Text)/CInt(LabelTotalCajas.Text)
        End If

        LabelVoids.Text = "No válidas: " & voids.ToString() & "%"
 
    End Sub

    Private Sub TextBoxSKU_Click(sender As Object, e As EventArgs) Handles TextBoxSKU.Click
        'Call LoadOnScreenNumpad(TextBoxSKU)
    End Sub

    Private Sub DateTimePickerProduction_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerProduction.ValueChanged
        DateTimePickerExpiry.Value = DateAdd("m", 10, DateTimePickerProduction.Value)
    End Sub

End Class
