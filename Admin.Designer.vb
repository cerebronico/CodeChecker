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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Admin))
        Me.DataGridViewOperators = New DataGridView()
        Me.operatorName = New DataGridViewTextBoxColumn()
        Me.password = New DataGridViewTextBoxColumn()
        Me.DataGridViewFormats = New DataGridView()
        Me.DataGridViewTextBoxBarcode = New DataGridViewTextBoxColumn()
        Me.customer = New DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxFormat = New DataGridViewTextBoxColumn()
        Me.size = New DataGridViewTextBoxColumn()
        Me.Label2 = New Label()
        Me.Label1 = New Label()
        Me.Button2 = New Button()
        Me.Button1 = New Button()
        CType(Me.DataGridViewOperators,ISupportInitialize).BeginInit
        CType(Me.DataGridViewFormats,ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridViewOperators
        '
        Me.DataGridViewOperators.BorderStyle = BorderStyle.Fixed3D
        Me.DataGridViewOperators.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Sienna
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12!, FontStyle.Bold, GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.[True]
        Me.DataGridViewOperators.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewOperators.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOperators.Columns.AddRange(New DataGridViewColumn() {Me.operatorName, Me.password})
        Me.DataGridViewOperators.EnableHeadersVisualStyles = false
        Me.DataGridViewOperators.Location = New Point(12, 39)
        Me.DataGridViewOperators.Name = "DataGridViewOperators"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Sienna
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.[True]
        Me.DataGridViewOperators.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewOperators.ScrollBars = ScrollBars.Vertical
        Me.DataGridViewOperators.Size = New Size(482, 160)
        Me.DataGridViewOperators.TabIndex = 3
        '
        'operatorName
        '
        Me.operatorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.operatorName.HeaderText = "Nombre"
        Me.operatorName.Name = "operatorName"
        Me.operatorName.Resizable = DataGridViewTriState.[False]
        Me.operatorName.Width = 300
        '
        'password
        '
        Me.password.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.password.HeaderText = "Contraseña"
        Me.password.MaxInputLength = 8
        Me.password.Name = "password"
        Me.password.Resizable = DataGridViewTriState.[False]
        Me.password.Width = 120
        '
        'DataGridViewFormats
        '
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Sienna
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = SystemColors.MenuBar
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.[True]
        Me.DataGridViewFormats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewFormats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFormats.Columns.AddRange(New DataGridViewColumn() {Me.DataGridViewTextBoxBarcode, Me.customer, Me.DataGridViewTextBoxFormat, Me.size})
        Me.DataGridViewFormats.EnableHeadersVisualStyles = false
        Me.DataGridViewFormats.Location = New Point(12, 243)
        Me.DataGridViewFormats.Name = "DataGridViewFormats"
        Me.DataGridViewFormats.Size = New Size(482, 176)
        Me.DataGridViewFormats.TabIndex = 4
        '
        'DataGridViewTextBoxBarcode
        '
        Me.DataGridViewTextBoxBarcode.HeaderText = "Cód. de barra"
        Me.DataGridViewTextBoxBarcode.Name = "DataGridViewTextBoxBarcode"
        Me.DataGridViewTextBoxBarcode.Resizable = DataGridViewTriState.[False]
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
        Me.Label2.Font = New Font("Microsoft Sans Serif", 16!, FontStyle.Regular, GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = SystemColors.ButtonFace
        Me.Label2.Location = New Point(12, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(139, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Presentación"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New Font("Microsoft Sans Serif", 16!, FontStyle.Regular, GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = SystemColors.ButtonFace
        Me.Label1.Location = New Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(126, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Operadores"
        '
        'Button2
        '
        Me.Button2.Location = New Point(302, 438)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New Size(75, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "VOLVER"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New Point(131, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(75, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Admin
        '
        Me.AutoScaleDimensions = New SizeF(6!, 13!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(509, 484)
        Me.Controls.Add(Me.DataGridViewOperators)
        Me.Controls.Add(Me.DataGridViewFormats)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),Icon)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.DataGridViewOperators,ISupportInitialize).EndInit
        CType(Me.DataGridViewFormats,ISupportInitialize).EndInit
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
