Imports System.ComponentModel
Imports System.IO.Ports
Imports Keyence.AutoID.SDK
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Verifier
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verifier))
        Me.ToolStripStatusLabelScannedQr = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPortIO = New System.IO.Ports.SerialPort(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBoxTimeOut = New System.Windows.Forms.TextBox()
        Me.TextBoxTOff = New System.Windows.Forms.TextBox()
        Me.TextBoxTOn = New System.Windows.Forms.TextBox()
        Me.TextBoxSKU = New System.Windows.Forms.TextBox()
        Me.ToolStripStatusLabelScannerBarcode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LiveviewForm1 = New Keyence.AutoID.SDK.LiveviewForm()
        Me.LabelPresentacion = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.TextBoxCodeScanned = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxCode = New System.Windows.Forms.TextBox()
        Me.TextBoxExpiryDateScanned = New System.Windows.Forms.TextBox()
        Me.TextBoxProductionDateScanned = New System.Windows.Forms.TextBox()
        Me.TextBoxBatchScanned = New System.Windows.Forms.TextBox()
        Me.DateTimePickerExpiry = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerProduction = New System.Windows.Forms.DateTimePicker()
        Me.ButtonSave2USB = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.TextBoxBatch = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabelUserEnteredCode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelTotalCajas = New System.Windows.Forms.Label()
        Me.LabelNoCode = New System.Windows.Forms.Label()
        Me.LabelBad2DCode = New System.Windows.Forms.Label()
        Me.LabelBad1DCode = New System.Windows.Forms.Label()
        Me.LabelValidas = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelVoids = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonSetParameters = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSKUScanned = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBoxQr = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSku = New System.Windows.Forms.PictureBox()
        Me.ButtonOperator = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBoxQr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBoxSku,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ToolStripStatusLabelScannedQr
        '
        resources.ApplyResources(Me.ToolStripStatusLabelScannedQr, "ToolStripStatusLabelScannedQr")
        Me.ToolStripStatusLabelScannedQr.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.ToolStripStatusLabelScannedQr.Name = "ToolStripStatusLabelScannedQr"
        '
        'SerialPortIO
        '
        Me.SerialPortIO.BaudRate = 115200
        Me.SerialPortIO.PortName = "COM5"
        Me.SerialPortIO.RtsEnable = true
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        '
        'TextBoxTimeOut
        '
        resources.ApplyResources(Me.TextBoxTimeOut, "TextBoxTimeOut")
        Me.TextBoxTimeOut.Name = "TextBoxTimeOut"
        Me.ToolTip1.SetToolTip(Me.TextBoxTimeOut, resources.GetString("TextBoxTimeOut.ToolTip"))
        '
        'TextBoxTOff
        '
        resources.ApplyResources(Me.TextBoxTOff, "TextBoxTOff")
        Me.TextBoxTOff.Name = "TextBoxTOff"
        Me.ToolTip1.SetToolTip(Me.TextBoxTOff, resources.GetString("TextBoxTOff.ToolTip"))
        '
        'TextBoxTOn
        '
        resources.ApplyResources(Me.TextBoxTOn, "TextBoxTOn")
        Me.TextBoxTOn.Name = "TextBoxTOn"
        Me.ToolTip1.SetToolTip(Me.TextBoxTOn, resources.GetString("TextBoxTOn.ToolTip"))
        '
        'TextBoxSKU
        '
        resources.ApplyResources(Me.TextBoxSKU, "TextBoxSKU")
        Me.TextBoxSKU.Name = "TextBoxSKU"
        Me.ToolTip1.SetToolTip(Me.TextBoxSKU, resources.GetString("TextBoxSKU.ToolTip"))
        '
        'ToolStripStatusLabelScannerBarcode
        '
        resources.ApplyResources(Me.ToolStripStatusLabelScannerBarcode, "ToolStripStatusLabelScannerBarcode")
        Me.ToolStripStatusLabelScannerBarcode.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.ToolStripStatusLabelScannerBarcode.Name = "ToolStripStatusLabelScannerBarcode"
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        '
        'LiveviewForm1
        '
        resources.ApplyResources(Me.LiveviewForm1, "LiveviewForm1")
        Me.LiveviewForm1.BackColor = System.Drawing.Color.Black
        Me.LiveviewForm1.BinningType = Keyence.AutoID.SDK.LiveviewForm.ImageBinningType.OneQuarter
        Me.LiveviewForm1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LiveviewForm1.ImageFormat = Keyence.AutoID.SDK.LiveviewForm.ImageFormatType.Jpeg
        Me.LiveviewForm1.ImageQuality = 5
        Me.LiveviewForm1.IpAddress = "192.168.100.100"
        Me.LiveviewForm1.Name = "LiveviewForm1"
        Me.LiveviewForm1.PullTimeSpan = 100
        Me.LiveviewForm1.TimeoutMs = 2000
        Me.ToolTip1.SetToolTip(Me.LiveviewForm1, resources.GetString("LiveviewForm1.ToolTip"))
        '
        'LabelPresentacion
        '
        resources.ApplyResources(Me.LabelPresentacion, "LabelPresentacion")
        Me.LabelPresentacion.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelPresentacion.Name = "LabelPresentacion"
        Me.ToolTip1.SetToolTip(Me.LabelPresentacion, resources.GetString("LabelPresentacion.ToolTip"))
        '
        'LabelTime
        '
        resources.ApplyResources(Me.LabelTime, "LabelTime")
        Me.LabelTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTime.ForeColor = System.Drawing.Color.Red
        Me.LabelTime.Name = "LabelTime"
        Me.ToolTip1.SetToolTip(Me.LabelTime, resources.GetString("LabelTime.ToolTip"))
        '
        'LabelDate
        '
        resources.ApplyResources(Me.LabelDate, "LabelDate")
        Me.LabelDate.Name = "LabelDate"
        Me.ToolTip1.SetToolTip(Me.LabelDate, resources.GetString("LabelDate.ToolTip"))
        '
        'TextBoxCodeScanned
        '
        resources.ApplyResources(Me.TextBoxCodeScanned, "TextBoxCodeScanned")
        Me.TextBoxCodeScanned.Name = "TextBoxCodeScanned"
        Me.TextBoxCodeScanned.TabStop = false
        Me.ToolTip1.SetToolTip(Me.TextBoxCodeScanned, resources.GetString("TextBoxCodeScanned.ToolTip"))
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        Me.ToolTip1.SetToolTip(Me.Label15, resources.GetString("Label15.ToolTip"))
        '
        'TextBoxCode
        '
        resources.ApplyResources(Me.TextBoxCode, "TextBoxCode")
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.ToolTip1.SetToolTip(Me.TextBoxCode, resources.GetString("TextBoxCode.ToolTip"))
        '
        'TextBoxExpiryDateScanned
        '
        resources.ApplyResources(Me.TextBoxExpiryDateScanned, "TextBoxExpiryDateScanned")
        Me.TextBoxExpiryDateScanned.Name = "TextBoxExpiryDateScanned"
        Me.TextBoxExpiryDateScanned.TabStop = false
        Me.ToolTip1.SetToolTip(Me.TextBoxExpiryDateScanned, resources.GetString("TextBoxExpiryDateScanned.ToolTip"))
        '
        'TextBoxProductionDateScanned
        '
        resources.ApplyResources(Me.TextBoxProductionDateScanned, "TextBoxProductionDateScanned")
        Me.TextBoxProductionDateScanned.Name = "TextBoxProductionDateScanned"
        Me.TextBoxProductionDateScanned.TabStop = false
        Me.ToolTip1.SetToolTip(Me.TextBoxProductionDateScanned, resources.GetString("TextBoxProductionDateScanned.ToolTip"))
        '
        'TextBoxBatchScanned
        '
        resources.ApplyResources(Me.TextBoxBatchScanned, "TextBoxBatchScanned")
        Me.TextBoxBatchScanned.Name = "TextBoxBatchScanned"
        Me.TextBoxBatchScanned.TabStop = false
        Me.ToolTip1.SetToolTip(Me.TextBoxBatchScanned, resources.GetString("TextBoxBatchScanned.ToolTip"))
        '
        'DateTimePickerExpiry
        '
        resources.ApplyResources(Me.DateTimePickerExpiry, "DateTimePickerExpiry")
        Me.DateTimePickerExpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerExpiry.MinDate = New Date(2020, 6, 1, 0, 0, 0, 0)
        Me.DateTimePickerExpiry.Name = "DateTimePickerExpiry"
        Me.ToolTip1.SetToolTip(Me.DateTimePickerExpiry, resources.GetString("DateTimePickerExpiry.ToolTip"))
        '
        'DateTimePickerProduction
        '
        resources.ApplyResources(Me.DateTimePickerProduction, "DateTimePickerProduction")
        Me.DateTimePickerProduction.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerProduction.MinDate = New Date(2020, 6, 1, 0, 0, 0, 0)
        Me.DateTimePickerProduction.Name = "DateTimePickerProduction"
        Me.ToolTip1.SetToolTip(Me.DateTimePickerProduction, resources.GetString("DateTimePickerProduction.ToolTip"))
        '
        'ButtonSave2USB
        '
        resources.ApplyResources(Me.ButtonSave2USB, "ButtonSave2USB")
        Me.ButtonSave2USB.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSave2USB.BackgroundImage = Global.CodeChecker.My.Resources.Resources.botonGris
        Me.ButtonSave2USB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonSave2USB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonSave2USB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonSave2USB.ForeColor = System.Drawing.Color.White
        Me.ButtonSave2USB.Name = "ButtonSave2USB"
        Me.ToolTip1.SetToolTip(Me.ButtonSave2USB, resources.GetString("ButtonSave2USB.ToolTip"))
        Me.ButtonSave2USB.UseVisualStyleBackColor = false
        '
        'ButtonStart
        '
        resources.ApplyResources(Me.ButtonStart, "ButtonStart")
        Me.ButtonStart.BackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.BackgroundImage = Global.CodeChecker.My.Resources.Resources.BotonVerde
        Me.ButtonStart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.ForeColor = System.Drawing.Color.White
        Me.ButtonStart.Name = "ButtonStart"
        Me.ToolTip1.SetToolTip(Me.ButtonStart, resources.GetString("ButtonStart.ToolTip"))
        Me.ButtonStart.UseVisualStyleBackColor = false
        '
        'ButtonExit
        '
        resources.ApplyResources(Me.ButtonExit, "ButtonExit")
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.BackgroundImage = Global.CodeChecker.My.Resources.Resources.botonRojo
        Me.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.ForeColor = System.Drawing.Color.White
        Me.ButtonExit.Name = "ButtonExit"
        Me.ToolTip1.SetToolTip(Me.ButtonExit, resources.GetString("ButtonExit.ToolTip"))
        Me.ButtonExit.UseVisualStyleBackColor = false
        '
        'TextBoxBatch
        '
        resources.ApplyResources(Me.TextBoxBatch, "TextBoxBatch")
        Me.TextBoxBatch.Name = "TextBoxBatch"
        Me.ToolTip1.SetToolTip(Me.TextBoxBatch, resources.GetString("TextBoxBatch.ToolTip"))
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        Me.ToolTip1.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip"))
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        Me.ToolTip1.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip"))
        '
        'ToolStripStatusLabelUserEnteredCode
        '
        resources.ApplyResources(Me.ToolStripStatusLabelUserEnteredCode, "ToolStripStatusLabelUserEnteredCode")
        Me.ToolStripStatusLabelUserEnteredCode.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.ToolStripStatusLabelUserEnteredCode.Name = "ToolStripStatusLabelUserEnteredCode"
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabelUserEnteredCode, Me.ToolStripStatusLabelScannedQr, Me.ToolStripStatusLabelScannerBarcode})
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.ToolTip1.SetToolTip(Me.StatusStrip1, resources.GetString("StatusStrip1.ToolTip"))
        '
        'ToolStripStatusLabel1
        '
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.LabelTotalCajas)
        Me.GroupBox2.Controls.Add(Me.LabelNoCode)
        Me.GroupBox2.Controls.Add(Me.LabelBad2DCode)
        Me.GroupBox2.Controls.Add(Me.LabelBad1DCode)
        Me.GroupBox2.Controls.Add(Me.LabelValidas)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LabelVoids)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = false
        Me.ToolTip1.SetToolTip(Me.GroupBox2, resources.GetString("GroupBox2.ToolTip"))
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.CodeChecker.My.Resources.Resources.Verde_f01
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        '
        'LabelTotalCajas
        '
        resources.ApplyResources(Me.LabelTotalCajas, "LabelTotalCajas")
        Me.LabelTotalCajas.BackColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelTotalCajas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTotalCajas.ForeColor = System.Drawing.Color.Red
        Me.LabelTotalCajas.Name = "LabelTotalCajas"
        Me.ToolTip1.SetToolTip(Me.LabelTotalCajas, resources.GetString("LabelTotalCajas.ToolTip"))
        '
        'LabelNoCode
        '
        resources.ApplyResources(Me.LabelNoCode, "LabelNoCode")
        Me.LabelNoCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNoCode.Name = "LabelNoCode"
        Me.ToolTip1.SetToolTip(Me.LabelNoCode, resources.GetString("LabelNoCode.ToolTip"))
        '
        'LabelBad2DCode
        '
        resources.ApplyResources(Me.LabelBad2DCode, "LabelBad2DCode")
        Me.LabelBad2DCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBad2DCode.Name = "LabelBad2DCode"
        Me.ToolTip1.SetToolTip(Me.LabelBad2DCode, resources.GetString("LabelBad2DCode.ToolTip"))
        '
        'LabelBad1DCode
        '
        resources.ApplyResources(Me.LabelBad1DCode, "LabelBad1DCode")
        Me.LabelBad1DCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBad1DCode.Name = "LabelBad1DCode"
        Me.ToolTip1.SetToolTip(Me.LabelBad1DCode, resources.GetString("LabelBad1DCode.ToolTip"))
        '
        'LabelValidas
        '
        resources.ApplyResources(Me.LabelValidas, "LabelValidas")
        Me.LabelValidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelValidas.Name = "LabelValidas"
        Me.ToolTip1.SetToolTip(Me.LabelValidas, resources.GetString("LabelValidas.ToolTip"))
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        Me.ToolTip1.SetToolTip(Me.Label8, resources.GetString("Label8.ToolTip"))
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        Me.ToolTip1.SetToolTip(Me.Label14, resources.GetString("Label14.ToolTip"))
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        Me.ToolTip1.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip"))
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        Me.ToolTip1.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip"))
        '
        'LabelVoids
        '
        resources.ApplyResources(Me.LabelVoids, "LabelVoids")
        Me.LabelVoids.Name = "LabelVoids"
        Me.ToolTip1.SetToolTip(Me.LabelVoids, resources.GetString("LabelVoids.ToolTip"))
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        Me.ToolTip1.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ButtonSetParameters)
        Me.GroupBox1.Controls.Add(Me.TextBoxTimeOut)
        Me.GroupBox1.Controls.Add(Me.TextBoxTOff)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBoxTOn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = false
        Me.ToolTip1.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip"))
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        Me.ToolTip1.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip"))
        '
        'ButtonSetParameters
        '
        resources.ApplyResources(Me.ButtonSetParameters, "ButtonSetParameters")
        Me.ButtonSetParameters.Name = "ButtonSetParameters"
        Me.ToolTip1.SetToolTip(Me.ButtonSetParameters, resources.GetString("ButtonSetParameters.ToolTip"))
        Me.ButtonSetParameters.UseVisualStyleBackColor = true
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        Me.ToolTip1.SetToolTip(Me.Label9, resources.GetString("Label9.ToolTip"))
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        Me.ToolTip1.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        Me.ToolTip1.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
        '
        'TextBoxSKUScanned
        '
        resources.ApplyResources(Me.TextBoxSKUScanned, "TextBoxSKUScanned")
        Me.TextBoxSKUScanned.Name = "TextBoxSKUScanned"
        Me.TextBoxSKUScanned.TabStop = false
        Me.ToolTip1.SetToolTip(Me.TextBoxSKUScanned, resources.GetString("TextBoxSKUScanned.ToolTip"))
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        Me.ToolTip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Verde_f01.gif")
        Me.ImageList1.Images.SetKeyName(1, "Verde_f02.gif")
        Me.ImageList1.Images.SetKeyName(2, "Rojo_f01.gif")
        Me.ImageList1.Images.SetKeyName(3, "Rojo_f02.gif")
        '
        'PictureBoxQr
        '
        resources.ApplyResources(Me.PictureBoxQr, "PictureBoxQr")
        Me.PictureBoxQr.Image = Global.CodeChecker.My.Resources.Resources.right_or_wrong_3
        Me.PictureBoxQr.Name = "PictureBoxQr"
        Me.PictureBoxQr.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PictureBoxQr, resources.GetString("PictureBoxQr.ToolTip"))
        '
        'PictureBoxSku
        '
        resources.ApplyResources(Me.PictureBoxSku, "PictureBoxSku")
        Me.PictureBoxSku.Image = Global.CodeChecker.My.Resources.Resources.right_or_wrong_3
        Me.PictureBoxSku.Name = "PictureBoxSku"
        Me.PictureBoxSku.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PictureBoxSku, resources.GetString("PictureBoxSku.ToolTip"))
        '
        'ButtonOperator
        '
        resources.ApplyResources(Me.ButtonOperator, "ButtonOperator")
        Me.ButtonOperator.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOperator.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonOperator.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonOperator.FlatAppearance.BorderSize = 0
        Me.ButtonOperator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonOperator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonOperator.ForeColor = System.Drawing.Color.White
        Me.ButtonOperator.Name = "ButtonOperator"
        Me.ToolTip1.SetToolTip(Me.ButtonOperator, resources.GetString("ButtonOperator.ToolTip"))
        Me.ButtonOperator.UseVisualStyleBackColor = false
        '
        'Verifier
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.LiveviewForm1)
        Me.Controls.Add(Me.LabelPresentacion)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.PictureBoxQr)
        Me.Controls.Add(Me.PictureBoxSku)
        Me.Controls.Add(Me.TextBoxCodeScanned)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBoxCode)
        Me.Controls.Add(Me.TextBoxExpiryDateScanned)
        Me.Controls.Add(Me.TextBoxProductionDateScanned)
        Me.Controls.Add(Me.TextBoxBatchScanned)
        Me.Controls.Add(Me.DateTimePickerExpiry)
        Me.Controls.Add(Me.DateTimePickerProduction)
        Me.Controls.Add(Me.ButtonOperator)
        Me.Controls.Add(Me.ButtonSave2USB)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.TextBoxBatch)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxSKUScanned)
        Me.Controls.Add(Me.TextBoxSKU)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Verifier"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBoxQr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBoxSku,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ToolStripStatusLabelScannedQr As ToolStripStatusLabel
    Friend WithEvents SerialPortIO As SerialPort
    Friend WithEvents BackgroundWorker1 As BackgroundWorker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBoxTimeOut As TextBox
    Friend WithEvents TextBoxTOff As TextBox
    Friend WithEvents TextBoxTOn As TextBox
    Friend WithEvents TextBoxSKU As TextBox
    Friend WithEvents ToolStripStatusLabelScannerBarcode As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LiveviewForm1 As LiveviewForm
    Friend WithEvents LabelPresentacion As Label
    Friend WithEvents LabelTime As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents PictureBoxQr As PictureBox
    Friend WithEvents PictureBoxSku As PictureBox
    Friend WithEvents TextBoxCodeScanned As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxCode As TextBox
    Friend WithEvents TextBoxExpiryDateScanned As TextBox
    Friend WithEvents TextBoxProductionDateScanned As TextBox
    Friend WithEvents TextBoxBatchScanned As TextBox
    Friend WithEvents DateTimePickerExpiry As DateTimePicker
    Friend WithEvents DateTimePickerProduction As DateTimePicker
    Friend WithEvents ButtonOperator As Button
    Friend WithEvents ButtonSave2USB As Button
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents TextBoxBatch As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ToolStripStatusLabelUserEnteredCode As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelTotalCajas As Label
    Friend WithEvents LabelNoCode As Label
    Friend WithEvents LabelBad2DCode As Label
    Friend WithEvents LabelBad1DCode As Label
    Friend WithEvents LabelValidas As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelVoids As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonSetParameters As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSKUScanned As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
