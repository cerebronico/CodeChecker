Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Login))
        Me.Cancel = New Button()
        Me.OK = New Button()
        Me.PasswordTextBox = New TextBox()
        Me.UsernameTextBox = New TextBox()
        Me.PasswordLabel = New Label()
        Me.UsernameLabel = New Label()
        Me.LogoPictureBox = New PictureBox()
        CType(Me.LogoPictureBox,ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Cancel
        '
        Me.Cancel.DialogResult = DialogResult.Cancel
        Me.Cancel.Location = New Point(305, 150)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New Size(94, 23)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "&Cancel"
        '
        'OK
        '
        Me.OK.Location = New Point(202, 150)
        Me.OK.Name = "OK"
        Me.OK.Size = New Size(94, 23)
        Me.OK.TabIndex = 11
        Me.OK.Text = "&OK"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New Point(179, 90)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = ChrW(42)
        Me.PasswordTextBox.Size = New Size(220, 20)
        Me.PasswordTextBox.TabIndex = 10
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New Point(179, 33)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New Size(220, 20)
        Me.UsernameTextBox.TabIndex = 8
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New Point(177, 70)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New Size(220, 23)
        Me.PasswordLabel.TabIndex = 9
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New Point(177, 13)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New Size(220, 23)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"),Image)
        Me.LogoPictureBox.Location = New Point(-2, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New Size(165, 193)
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = false
        '
        'Login
        '
        Me.AutoScaleDimensions = New SizeF(6!, 13!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(427, 196)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"),Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.LogoPictureBox,ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
End Class
