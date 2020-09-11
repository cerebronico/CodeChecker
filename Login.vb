Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        With Verifier
            .TextBoxSKU.Enabled=True
            .TextBoxSKU.Focus()
            .TextBoxBatch.Enabled=True
            .TextBoxCode.Enabled=True
            .DateTimePickerProduction.Enabled=True
            .DateTimePickerExpiry.Enabled=True
            
            .ButtonStart.Enabled=True
            .ButtonSave2USB.Enabled=True

#If DEBUG
            .TextBoxSKU.Text="2105322241358"
            .TextBoxBatch.Text="PR242051"
            .TextBoxCode.Text="1453-8C"
#End If

            .TextBoxSKU.Text = CodeChecker.My.MySettings.Default.SKU
            Dim mode as Integer = CodeChecker.My.MySettings.Default.mode

            
        End With
  
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        If UsernameTextBox.Text = "admin"
            Admin.ShowDialog()
        End If
    End Sub
End Class
