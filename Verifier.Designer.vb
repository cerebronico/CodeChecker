<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verifier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.DataText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBoxQr = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSku = New System.Windows.Forms.PictureBox()
        Me.ButtonOperator = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBoxQr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBoxSku,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ToolStripStatusLabelScannedQr
        '
        Me.ToolStripStatusLabelScannedQr.AutoSize = false
        Me.ToolStripStatusLabelScannedQr.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.ToolStripStatusLabelScannedQr.Name = "ToolStripStatusLabelScannedQr"
        Me.ToolStripStatusLabelScannedQr.Size = New System.Drawing.Size(230, 17)
        Me.ToolStripStatusLabelScannedQr.Text = "Scanned QR code"
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
        Me.TextBoxTimeOut.Location = New System.Drawing.Point(66, 59)
        Me.TextBoxTimeOut.Name = "TextBoxTimeOut"
        Me.TextBoxTimeOut.Size = New System.Drawing.Size(49, 26)
        Me.TextBoxTimeOut.TabIndex = 12
        Me.TextBoxTimeOut.Text = "0"
        Me.TextBoxTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBoxTimeOut, "Tiempo máximo de detección de código")
        '
        'TextBoxTOff
        '
        Me.TextBoxTOff.Location = New System.Drawing.Point(211, 29)
        Me.TextBoxTOff.Name = "TextBoxTOff"
        Me.TextBoxTOff.Size = New System.Drawing.Size(49, 26)
        Me.TextBoxTOff.TabIndex = 11
        Me.TextBoxTOff.Text = "0"
        Me.TextBoxTOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBoxTOff, "Tiempo de permanencia activa del empujador")
        '
        'TextBoxTOn
        '
        Me.TextBoxTOn.Location = New System.Drawing.Point(66, 29)
        Me.TextBoxTOn.Name = "TextBoxTOn"
        Me.TextBoxTOn.Size = New System.Drawing.Size(49, 26)
        Me.TextBoxTOn.TabIndex = 10
        Me.TextBoxTOn.Text = "0"
        Me.TextBoxTOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBoxTOn, "Tiempo de espera para expulsar la caja")
        '
        'TextBoxSKU
        '
        Me.TextBoxSKU.Enabled = false
        Me.TextBoxSKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBoxSKU.Location = New System.Drawing.Point(141, 48)
        Me.TextBoxSKU.Name = "TextBoxSKU"
        Me.TextBoxSKU.Size = New System.Drawing.Size(214, 38)
        Me.TextBoxSKU.TabIndex = 40
        Me.TextBoxSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBoxSKU, "código de barras")
        '
        'ToolStripStatusLabelScannerBarcode
        '
        Me.ToolStripStatusLabelScannerBarcode.AutoSize = false
        Me.ToolStripStatusLabelScannerBarcode.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.ToolStripStatusLabelScannerBarcode.Name = "ToolStripStatusLabelScannerBarcode"
        Me.ToolStripStatusLabelScannerBarcode.Size = New System.Drawing.Size(350, 17)
        Me.ToolStripStatusLabelScannerBarcode.Text = "Scanner Barcode"
        Me.ToolStripStatusLabelScannerBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        '
        'LiveviewForm1
        '
        Me.LiveviewForm1.BackColor = System.Drawing.Color.Black
        Me.LiveviewForm1.BinningType = Keyence.AutoID.SDK.LiveviewForm.ImageBinningType.OneQuarter
        Me.LiveviewForm1.ImageFormat = Keyence.AutoID.SDK.LiveviewForm.ImageFormatType.Jpeg
        Me.LiveviewForm1.ImageQuality = 5
        Me.LiveviewForm1.IpAddress = "192.168.100.100"
        Me.LiveviewForm1.Location = New System.Drawing.Point(794, 48)
        Me.LiveviewForm1.Name = "LiveviewForm1"
        Me.LiveviewForm1.PullTimeSpan = 100
        Me.LiveviewForm1.Size = New System.Drawing.Size(202, 174)
        Me.LiveviewForm1.TabIndex = 67
        Me.LiveviewForm1.TimeoutMs = 2000
        '
        'LabelPresentacion
        '
        Me.LabelPresentacion.AutoSize = true
        Me.LabelPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelPresentacion.Location = New System.Drawing.Point(12, 5)
        Me.LabelPresentacion.Name = "LabelPresentacion"
        Me.LabelPresentacion.Size = New System.Drawing.Size(133, 37)
        Me.LabelPresentacion.TabIndex = 66
        Me.LabelPresentacion.Text = "Cliente: "
        '
        'LabelTime
        '
        Me.LabelTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTime.Font = New System.Drawing.Font("Digital", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelTime.ForeColor = System.Drawing.Color.Red
        Me.LabelTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelTime.Location = New System.Drawing.Point(53, 519)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(397, 100)
        Me.LabelTime.TabIndex = 65
        Me.LabelTime.Text = "00:00:00"
        Me.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = true
        Me.LabelDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelDate.Location = New System.Drawing.Point(12, 630)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(102, 33)
        Me.LabelDate.TabIndex = 64
        Me.LabelDate.Text = "Fecha"
        '
        'TextBoxCodeScanned
        '
        Me.TextBoxCodeScanned.Enabled = false
        Me.TextBoxCodeScanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBoxCodeScanned.Location = New System.Drawing.Point(393, 146)
        Me.TextBoxCodeScanned.Name = "TextBoxCodeScanned"
        Me.TextBoxCodeScanned.Size = New System.Drawing.Size(182, 38)
        Me.TextBoxCodeScanned.TabIndex = 61
        Me.TextBoxCodeScanned.TabStop = false
        Me.TextBoxCodeScanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 25)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Código:"
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Enabled = false
        Me.TextBoxCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBoxCode.Location = New System.Drawing.Point(173, 146)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(182, 38)
        Me.TextBoxCode.TabIndex = 42
        Me.TextBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxExpiryDateScanned
        '
        Me.TextBoxExpiryDateScanned.Enabled = false
        Me.TextBoxExpiryDateScanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBoxExpiryDateScanned.Location = New System.Drawing.Point(393, 244)
        Me.TextBoxExpiryDateScanned.Name = "TextBoxExpiryDateScanned"
        Me.TextBoxExpiryDateScanned.Size = New System.Drawing.Size(182, 38)
        Me.TextBoxExpiryDateScanned.TabIndex = 59
        Me.TextBoxExpiryDateScanned.TabStop = false
        Me.TextBoxExpiryDateScanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxProductionDateScanned
        '
        Me.TextBoxProductionDateScanned.Enabled = false
        Me.TextBoxProductionDateScanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBoxProductionDateScanned.Location = New System.Drawing.Point(393, 195)
        Me.TextBoxProductionDateScanned.Name = "TextBoxProductionDateScanned"
        Me.TextBoxProductionDateScanned.Size = New System.Drawing.Size(182, 38)
        Me.TextBoxProductionDateScanned.TabIndex = 58
        Me.TextBoxProductionDateScanned.TabStop = false
        Me.TextBoxProductionDateScanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxBatchScanned
        '
        Me.TextBoxBatchScanned.Enabled = false
        Me.TextBoxBatchScanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBoxBatchScanned.Location = New System.Drawing.Point(393, 97)
        Me.TextBoxBatchScanned.Name = "TextBoxBatchScanned"
        Me.TextBoxBatchScanned.Size = New System.Drawing.Size(182, 38)
        Me.TextBoxBatchScanned.TabIndex = 57
        Me.TextBoxBatchScanned.TabStop = false
        Me.TextBoxBatchScanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePickerExpiry
        '
        Me.DateTimePickerExpiry.CustomFormat = "yyMMdd"
        Me.DateTimePickerExpiry.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerExpiry.Enabled = false
        Me.DateTimePickerExpiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DateTimePickerExpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerExpiry.Location = New System.Drawing.Point(173, 244)
        Me.DateTimePickerExpiry.MinDate = New Date(2020, 6, 1, 0, 0, 0, 0)
        Me.DateTimePickerExpiry.Name = "DateTimePickerExpiry"
        Me.DateTimePickerExpiry.Size = New System.Drawing.Size(182, 38)
        Me.DateTimePickerExpiry.TabIndex = 44
        '
        'DateTimePickerProduction
        '
        Me.DateTimePickerProduction.CustomFormat = "yyMMdd"
        Me.DateTimePickerProduction.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerProduction.Enabled = false
        Me.DateTimePickerProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DateTimePickerProduction.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerProduction.Location = New System.Drawing.Point(173, 195)
        Me.DateTimePickerProduction.MinDate = New Date(2020, 6, 1, 0, 0, 0, 0)
        Me.DateTimePickerProduction.Name = "DateTimePickerProduction"
        Me.DateTimePickerProduction.Size = New System.Drawing.Size(182, 38)
        Me.DateTimePickerProduction.TabIndex = 43
        '
        'ButtonSave2USB
        '
        Me.ButtonSave2USB.AutoSize = true
        Me.ButtonSave2USB.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSave2USB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSave2USB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonSave2USB.Enabled = false
        Me.ButtonSave2USB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonSave2USB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonSave2USB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSave2USB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonSave2USB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.ButtonSave2USB.Location = New System.Drawing.Point(828, 465)
        Me.ButtonSave2USB.Name = "ButtonSave2USB"
        Me.ButtonSave2USB.Size = New System.Drawing.Size(168, 86)
        Me.ButtonSave2USB.TabIndex = 53
        Me.ButtonSave2USB.Text = "GUARDAR A USB"
        Me.ButtonSave2USB.UseVisualStyleBackColor = false
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonStart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonStart.Enabled = false
        Me.ButtonStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonStart.ForeColor = System.Drawing.Color.White
        Me.ButtonStart.Location = New System.Drawing.Point(828, 358)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(168, 86)
        Me.ButtonStart.TabIndex = 51
        Me.ButtonStart.Text = "INICIAR"
        Me.ButtonStart.UseVisualStyleBackColor = false
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonExit.ForeColor = System.Drawing.Color.White
        Me.ButtonExit.Location = New System.Drawing.Point(828, 572)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(168, 86)
        Me.ButtonExit.TabIndex = 39
        Me.ButtonExit.Text = "SALIR"
        Me.ButtonExit.UseVisualStyleBackColor = false
        '
        'TextBoxBatch
        '
        Me.TextBoxBatch.Enabled = false
        Me.TextBoxBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBoxBatch.Location = New System.Drawing.Point(173, 97)
        Me.TextBoxBatch.Name = "TextBoxBatch"
        Me.TextBoxBatch.Size = New System.Drawing.Size(182, 38)
        Me.TextBoxBatch.TabIndex = 41
        Me.TextBoxBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 25)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Fec. Caducidad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 25)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Fec. Producción:"
        '
        'ToolStripStatusLabelUserEnteredCode
        '
        Me.ToolStripStatusLabelUserEnteredCode.AutoSize = false
        Me.ToolStripStatusLabelUserEnteredCode.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.ToolStripStatusLabelUserEnteredCode.Name = "ToolStripStatusLabelUserEnteredCode"
        Me.ToolStripStatusLabelUserEnteredCode.Size = New System.Drawing.Size(230, 17)
        Me.ToolStripStatusLabelUserEnteredCode.Text = "QR User entered code"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabelUserEnteredCode, Me.ToolStripStatusLabelScannedQr, Me.ToolStripStatusLabelScannerBarcode})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 746)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1122, 22)
        Me.StatusStrip1.TabIndex = 56
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel1.Text = "IO status"
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(778, 199)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Cajas"
        '
        'LabelTotalCajas
        '
        Me.LabelTotalCajas.BackColor = System.Drawing.Color.FromArgb(CType(CType(20,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.LabelTotalCajas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTotalCajas.Font = New System.Drawing.Font("GSE 7-Segment VFD", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelTotalCajas.ForeColor = System.Drawing.Color.Red
        Me.LabelTotalCajas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelTotalCajas.Location = New System.Drawing.Point(523, 109)
        Me.LabelTotalCajas.Name = "LabelTotalCajas"
        Me.LabelTotalCajas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelTotalCajas.Size = New System.Drawing.Size(243, 75)
        Me.LabelTotalCajas.TabIndex = 15
        Me.LabelTotalCajas.Text = "99999"
        Me.LabelTotalCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNoCode
        '
        Me.LabelNoCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNoCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNoCode.Location = New System.Drawing.Point(344, 146)
        Me.LabelNoCode.Name = "LabelNoCode"
        Me.LabelNoCode.Size = New System.Drawing.Size(156, 38)
        Me.LabelNoCode.TabIndex = 14
        Me.LabelNoCode.Text = "0"
        Me.LabelNoCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelBad2DCode
        '
        Me.LabelBad2DCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBad2DCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelBad2DCode.Location = New System.Drawing.Point(344, 101)
        Me.LabelBad2DCode.Name = "LabelBad2DCode"
        Me.LabelBad2DCode.Size = New System.Drawing.Size(156, 38)
        Me.LabelBad2DCode.TabIndex = 14
        Me.LabelBad2DCode.Text = "0"
        Me.LabelBad2DCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelBad1DCode
        '
        Me.LabelBad1DCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBad1DCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelBad1DCode.Location = New System.Drawing.Point(344, 56)
        Me.LabelBad1DCode.Name = "LabelBad1DCode"
        Me.LabelBad1DCode.Size = New System.Drawing.Size(156, 38)
        Me.LabelBad1DCode.TabIndex = 14
        Me.LabelBad1DCode.Text = "0"
        Me.LabelBad1DCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelValidas
        '
        Me.LabelValidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelValidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelValidas.Location = New System.Drawing.Point(9, 146)
        Me.LabelValidas.Name = "LabelValidas"
        Me.LabelValidas.Size = New System.Drawing.Size(145, 38)
        Me.LabelValidas.TabIndex = 13
        Me.LabelValidas.Text = "0"
        Me.LabelValidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(518, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "TOTAL"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.Location = New System.Drawing.Point(169, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(169, 29)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Mal codificado"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.Location = New System.Drawing.Point(204, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 29)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Código QR"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(138, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Código de barras"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelVoids
        '
        Me.LabelVoids.AutoSize = true
        Me.LabelVoids.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelVoids.Location = New System.Drawing.Point(340, 26)
        Me.LabelVoids.Name = "LabelVoids"
        Me.LabelVoids.Size = New System.Drawing.Size(96, 20)
        Me.LabelVoids.TabIndex = 9
        Me.LabelVoids.Text = "No válidas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Válidas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 25)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "CdB:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ButtonSetParameters)
        Me.GroupBox1.Controls.Add(Me.TextBoxTimeOut)
        Me.GroupBox1.Controls.Add(Me.TextBoxTOff)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBoxTOn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(521, 499)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 156)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Parámetros"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Tiempo en 1/10 segundos"
        '
        'ButtonSetParameters
        '
        Me.ButtonSetParameters.Location = New System.Drawing.Point(156, 64)
        Me.ButtonSetParameters.Name = "ButtonSetParameters"
        Me.ButtonSetParameters.Size = New System.Drawing.Size(106, 61)
        Me.ButtonSetParameters.TabIndex = 14
        Me.ButtonSetParameters.Text = "Actualizar"
        Me.ButtonSetParameters.UseVisualStyleBackColor = true
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "T OUT"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(153, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "T OFF"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "T ON"
        '
        'TextBoxSKUScanned
        '
        Me.TextBoxSKUScanned.Enabled = false
        Me.TextBoxSKUScanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBoxSKUScanned.Location = New System.Drawing.Point(361, 48)
        Me.TextBoxSKUScanned.Name = "TextBoxSKUScanned"
        Me.TextBoxSKUScanned.Size = New System.Drawing.Size(214, 38)
        Me.TextBoxSKUScanned.TabIndex = 47
        Me.TextBoxSKUScanned.TabStop = false
        Me.TextBoxSKUScanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataText
        '
        Me.DataText.Enabled = false
        Me.DataText.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DataText.Location = New System.Drawing.Point(141, 4)
        Me.DataText.Name = "DataText"
        Me.DataText.Size = New System.Drawing.Size(495, 38)
        Me.DataText.TabIndex = 46
        Me.DataText.TabStop = false
        Me.DataText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 25)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Lote:"
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
        Me.PictureBoxQr.Location = New System.Drawing.Point(593, 96)
        Me.PictureBoxQr.Name = "PictureBoxQr"
        Me.PictureBoxQr.Size = New System.Drawing.Size(43, 37)
        Me.PictureBoxQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxQr.TabIndex = 63
        Me.PictureBoxQr.TabStop = false
        '
        'PictureBoxSku
        '
        Me.PictureBoxSku.Location = New System.Drawing.Point(593, 49)
        Me.PictureBoxSku.Name = "PictureBoxSku"
        Me.PictureBoxSku.Size = New System.Drawing.Size(43, 37)
        Me.PictureBoxSku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSku.TabIndex = 62
        Me.PictureBoxSku.TabStop = false
        '
        'ButtonOperator
        '
        Me.ButtonOperator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonOperator.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOperator.BackgroundImage = CType(resources.GetObject("ButtonOperator.BackgroundImage"),System.Drawing.Image)
        Me.ButtonOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonOperator.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonOperator.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonOperator.FlatAppearance.BorderSize = 0
        Me.ButtonOperator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonOperator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonOperator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonOperator.ForeColor = System.Drawing.Color.White
        Me.ButtonOperator.Location = New System.Drawing.Point(828, 251)
        Me.ButtonOperator.Name = "ButtonOperator"
        Me.ButtonOperator.Size = New System.Drawing.Size(168, 86)
        Me.ButtonOperator.TabIndex = 45
        Me.ButtonOperator.Text = "OPERADOR"
        Me.ButtonOperator.UseVisualStyleBackColor = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(87, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = false
        '
        'Verifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 768)
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
        Me.Controls.Add(Me.DataText)
        Me.Controls.Add(Me.TextBoxSKU)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Verifier"
        Me.Text = "Verifier"
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBoxQr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBoxSku,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ToolStripStatusLabelScannedQr As ToolStripStatusLabel
    Friend WithEvents SerialPortIO As IO.Ports.SerialPort
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBoxTimeOut As TextBox
    Friend WithEvents TextBoxTOff As TextBox
    Friend WithEvents TextBoxTOn As TextBox
    Friend WithEvents TextBoxSKU As TextBox
    Friend WithEvents ToolStripStatusLabelScannerBarcode As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LiveviewForm1 As Keyence.AutoID.SDK.LiveviewForm
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
    Friend WithEvents DataText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
