Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Admin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.DataGridViewOperators = New System.Windows.Forms.DataGridView()
        Me.operatorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewFormats = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxFormat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewOperators,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridViewFormats,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridViewOperators
        '
        Me.DataGridViewOperators.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewOperators.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewOperators.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOperators.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.operatorName, Me.password})
        Me.DataGridViewOperators.EnableHeadersVisualStyles = false
        Me.DataGridViewOperators.Location = New System.Drawing.Point(12, 39)
        Me.DataGridViewOperators.Name = "DataGridViewOperators"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewOperators.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewOperators.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewOperators.Size = New System.Drawing.Size(482, 160)
        Me.DataGridViewOperators.TabIndex = 3
        '
        'operatorName
        '
        Me.operatorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.operatorName.HeaderText = "Nombre"
        Me.operatorName.Name = "operatorName"
        Me.operatorName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.operatorName.Width = 300
        '
        'password
        '
        Me.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.password.HeaderText = "Contraseña"
        Me.password.MaxInputLength = 8
        Me.password.Name = "password"
        Me.password.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.password.Width = 120
        '
        'DataGridViewFormats
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewFormats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFormats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxBarcode, Me.customer, Me.DataGridViewTextBoxFormat, Me.size})
        Me.DataGridViewFormats.EnableHeadersVisualStyles = false
        Me.DataGridViewFormats.Location = New System.Drawing.Point(12, 243)
        Me.DataGridViewFormats.Name = "DataGridViewFormats"
        Me.DataGridViewFormats.Size = New System.Drawing.Size(482, 176)
        Me.DataGridViewFormats.TabIndex = 4
        '
        'DataGridViewTextBoxBarcode
        '
        Me.DataGridViewTextBoxBarcode.HeaderText = "Cód. de barra"
        Me.DataGridViewTextBoxBarcode.Name = "DataGridViewTextBoxBarcode"
        Me.DataGridViewTextBoxBarcode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxBarcode.Width = 120
        '
        'customer
        '
        Me.customer.HeaderText = "Cliente"
        Me.customer.Name = "customer"
        Me.customer.Width = 120
        '
        'DataGridViewTextBoxFormat
        '
        Me.DataGridViewTextBoxFormat.HeaderText = "Presentación"
        Me.DataGridViewTextBoxFormat.Name = "DataGridViewTextBoxFormat"
        Me.DataGridViewTextBoxFormat.Width = 120
        '
        'size
        '
        Me.size.HeaderText = "Talla"
        Me.size.Name = "size"
        Me.size.Width = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Presentación"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Operadores"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(302, 438)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "VOLVER"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 484)
        Me.Controls.Add(Me.DataGridViewOperators)
        Me.Controls.Add(Me.DataGridViewFormats)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.DataGridViewOperators,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridViewFormats,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents DataGridViewOperators As DataGridView
    Friend WithEvents operatorName As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewFormats As DataGridView
    Friend WithEvents DataGridViewTextBoxBarcode As DataGridViewTextBoxColumn
    Friend WithEvents customer As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFormat As DataGridViewTextBoxColumn
    Friend WithEvents size As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
