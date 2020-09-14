Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Numpad
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
        Me.Button1 = New Button()
        Me.Button2 = New Button()
        Me.Button3 = New Button()
        Me.Button4 = New Button()
        Me.Button5 = New Button()
        Me.Button6 = New Button()
        Me.Button7 = New Button()
        Me.Button8 = New Button()
        Me.Button9 = New Button()
        Me.Button10 = New Button()
        Me.Button11 = New Button()
        Me.Button13 = New Button()
        Me.Button14 = New Button()
        Me.Button15 = New Button()
        Me.Button16 = New Button()
        Me.FocusedTextbox = New TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New Point(4, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(43, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Tag = "7"
        Me.Button1.Text = "7"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New Point(47, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New Size(43, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Tag = "8"
        Me.Button2.Text = "8"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New Point(90, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New Size(43, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Tag = "9"
        Me.Button3.Text = "9"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New Point(133, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New Size(43, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "BCK"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New Point(4, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New Size(43, 41)
        Me.Button5.TabIndex = 4
        Me.Button5.Tag = "4"
        Me.Button5.Text = "4"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New Point(47, 72)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New Size(43, 41)
        Me.Button6.TabIndex = 5
        Me.Button6.Tag = "5"
        Me.Button6.Text = "5"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New Point(90, 72)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New Size(43, 41)
        Me.Button7.TabIndex = 6
        Me.Button7.Tag = "6"
        Me.Button7.Text = "6"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New Point(133, 72)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New Size(43, 41)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "CLR"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New Point(4, 114)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New Size(43, 41)
        Me.Button9.TabIndex = 8
        Me.Button9.Tag = "1"
        Me.Button9.Text = "1"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New Point(47, 114)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New Size(43, 41)
        Me.Button10.TabIndex = 9
        Me.Button10.Tag = "2"
        Me.Button10.Text = "2"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New Point(90, 114)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New Size(43, 41)
        Me.Button11.TabIndex = 10
        Me.Button11.Tag = "3"
        Me.Button11.Text = "3"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New Point(4, 156)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New Size(43, 41)
        Me.Button13.TabIndex = 12
        Me.Button13.Tag = "0"
        Me.Button13.Text = "0"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New Point(47, 156)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New Size(43, 41)
        Me.Button14.TabIndex = 13
        Me.Button14.Text = "-/+"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New Point(90, 156)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New Size(43, 41)
        Me.Button15.TabIndex = 14
        Me.Button15.Text = "."
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New Point(133, 156)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New Size(43, 41)
        Me.Button16.TabIndex = 15
        Me.Button16.Text = "ENT"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'FocusedTextbox
        '
        Me.FocusedTextbox.BorderStyle = BorderStyle.FixedSingle
        Me.FocusedTextbox.Font = New Font("Microsoft Sans Serif", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.FocusedTextbox.Location = New Point(5, 4)
        Me.FocusedTextbox.Name = "FocusedTextbox"
        Me.FocusedTextbox.Size = New Size(170, 24)
        Me.FocusedTextbox.TabIndex = 16
        Me.FocusedTextbox.Text = "0.00"
        Me.FocusedTextbox.TextAlign = HorizontalAlignment.Right
        '
        'frmOnScreenNumpad
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(179, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.FocusedTextbox)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Name = "frmOnScreenNumpad"
        Me.Opacity = 0.8R
        Me.SizeGripStyle = SizeGripStyle.Show
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "On-Screen Numpad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents FocusedTextbox As TextBox

End Class
