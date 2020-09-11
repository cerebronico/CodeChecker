Imports System.ComponentModel
Imports System.IO
Imports System.Globalization
Imports Keyence.AutoID.SDK
imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Checker
    Dim ReadOnly _mReader As ReaderAccessor = New ReaderAccessor()
    Dim _newBarcodeReceived as Boolean = False
    Dim _dt as String = Nothing
    Dim _dtfInfo As CultureInfo 'DateTimeFormatInfo
    Dim _dtStyle as String = "dddd, dd MMMM yyyy"

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        close()
    End Sub

    Private Sub FormCodeChecker_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            If Not SerialPortModuleIO.IsOpen Then
                SerialPortModuleIO.Open()
                SerialPortModuleIO.NewLine=vbCrLf
            End If

        Catch ex As Exception : MsgBox(ex.Message)
            MessageBox.Show("Error al acceder al Puerto Serial: " & ex.Message)
        End Try
    End Sub

    Private Sub FormCodeChecker_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If SerialPortModuleIO.IsOpen Then
            SerialPortModuleIO.Close()
        End If

        ' liveviewForm1.Dispose()
        _mReader.Dispose()
    End Sub

    Private Sub SerialPortModuleIO_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SerialPortModuleIO.DataReceived
        
        Try
            Dim buffer as String, myData As String, s() As String
            buffer = SerialPortModuleIO.ReadLine()
            
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
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'delegateUserControl is for controlling UserControl from other threads.
    Private Delegate Sub DelegateUserControl(str As String)

    Private Sub ReceivedDataWrite(receivedData As String)
        DataText.Text = (receivedData)
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
End Class
