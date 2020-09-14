Public Class Numpad

    Private ReceivingTextBox As TextBox = Nothing
    Private PreventClosing As Boolean = False
    Private TextBoxNullValue As String = "0.00"

    Protected Overloads Overrides ReadOnly Property ShowWithoutActivation() As Boolean
        Get
            Return True
        End Get
    End Property


    Sub New(ByVal ReceivingTextBox As TextBox)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ReceivingTextBox = New TextBox()
        Me.ReceivingTextBox = ReceivingTextBox
        Me.FocusedTextbox.Text = ReceivingTextBox.Text
        Me.BackColor = Color.Magenta
        Me.TransparencyKey = Me.BackColor
        If Not ReceivingTextBox.Text = TextBoxNullValue Or Not String.IsNullOrEmpty(ReceivingTextBox.Text) Then
            Me.FocusedTextbox.SelectionStart = Me.FocusedTextbox.Text.Length
        End If
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        If FocusedTextbox IsNot Nothing Then
            AddHandler FocusedTextbox.MouseEnter, AddressOf FocusedTextbox_MouseEnter
            AddHandler FocusedTextbox.MouseLeave, AddressOf FocusedTextbox_MouseLeave
            AddHandler FocusedTextbox.LostFocus, AddressOf FocusedTextbox_LostFocus
            AddHandler FocusedTextbox.GotFocus, AddressOf FocusedTextbox_GotFocus
        End If
    End Sub
    Protected Overrides Sub OnClosed(ByVal e As EventArgs)
        MyBase.OnClosed(e)
        Call UnloadOnScreenNumpad()
    End Sub
    Protected Overrides Sub OnDeactivate(ByVal e As EventArgs)
        MyBase.OnDeactivate(e)
        If Not PreventClosing Then
            Me.Close()
        End If
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        PreventClosing = True
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        PreventClosing = False
    End Sub

    Private Sub AllNumberButtons_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button13.Click, Button9.Click, Button10.Click, Button11.Click, Button5.Click, Button6.Click, Button7.Click, Button1.Click, Button2.Click, Button3.Click
        Dim btn As Button = Nothing

        If Me.FocusedTextbox Is Nothing Then
            MessageBox.Show("This instance of the On-Screen Numpad has no reference to an existing textbox that recieves the numeric key inputs.", "Object Null", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        btn = TryCast(sender, Button)
        If btn IsNot Nothing Then
            Dim start As Int32 = FocusedTextbox.SelectionStart

            If FocusedTextbox.SelectionLength > 0 Then
                FocusedTextbox.SelectedText = btn.Tag.ToString()
            Else
                If FocusedTextbox.Text = TextBoxNullValue Then
                    FocusedTextbox.Text = btn.Tag.ToString()
                    FocusedTextbox.SelectionStart = 1
                Else
                    If start = 0 Then 'We have to check if the we're before a negative sign when at selection start 0.
                        Dim dec As Decimal

                        If Decimal.TryParse(FocusedTextbox.Text, dec) Then
                            If dec < 0 Then 'Negative, and at position zero. Bump the selection start up to 1(after the negative sign).
                                start = 1
                            End If
                        End If
                    End If
                    FocusedTextbox.Text = FocusedTextbox.Text.Insert(start, btn.Tag.ToString())
                    FocusedTextbox.SelectionStart = start + 1
                End If
            End If

        End If

        btn = Nothing 'Dispose the object created to reference the sender as a button control to access it's methods.
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        If Me.FocusedTextbox Is Nothing Then
            MessageBox.Show("This instance of the On-Screen Numpad has no reference to an existing textbox.", "Object Null", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Me.FocusedTextbox.Text <> TextBoxNullValue Then
            If Me.FocusedTextbox.SelectionLength > 1 Then 'Removing a selected set of text.
                'My assumption is if the length is greater than 1 then both selection start and length are within range.
                'We go right into removeing the selected set of text without verifying if we're in range.
                Me.FocusedTextbox.Text = Me.FocusedTextbox.Text.Remove(Me.FocusedTextbox.SelectionStart, Me.FocusedTextbox.SelectionLength)
            Else
                'Since were removeing the 'previous' single character we need to check if we're going to be within range to do so.
                If Me.FocusedTextbox.SelectionStart > 0 AndAlso Me.FocusedTextbox.SelectionStart <= Me.FocusedTextbox.Text.Length Then
                    Dim selectionIndex As Int32

                    selectionIndex = Me.FocusedTextbox.SelectionStart - 1
                    Me.FocusedTextbox.Text = Me.FocusedTextbox.Text.Remove(selectionIndex, 1)
                    Me.FocusedTextbox.SelectionStart = selectionIndex
                End If
            End If
        End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
        If Me.FocusedTextbox Is Nothing Then
            MessageBox.Show("This instance of the On-Screen Numpad has no reference to an existing textbox.", "Object Null", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Me.FocusedTextbox.Text <> TextBoxNullValue Then
            Me.FocusedTextbox.Text = String.Empty 'Invokes the control to display it's null value.
        End If
    End Sub
    Private Sub btnTab_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.FocusedTextbox Is Nothing Then
            MessageBox.Show("This instance of the On-Screen Numpad has no reference to an existing textbox.", "Object Null", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Me.FocusedTextbox.Text <> TextBoxNullValue Then
            ' ???
        End If
    End Sub
    Private Sub btnEnter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button16.Click
        If Me.FocusedTextbox Is Nothing Then
            MessageBox.Show("This instance of the On-Screen Numpad has no reference to an existing textbox that recieves the numeric key inputs.", "Object Null", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ReceivingTextBox.Text = FocusedTextbox.Text
        Me.Close()
    End Sub

    Private Sub btnNegativePositiveToggle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button14.Click
        If Me.FocusedTextbox Is Nothing Then
            MessageBox.Show("This instance of the On-Screen Numpad has no reference to an existing textbox that recieves the numeric key inputs.", "Object Null", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim dec As Decimal = 0D
        Dim sel As Int32 = Me.FocusedTextbox.SelectionStart

        If Decimal.TryParse(Me.FocusedTextbox.Text, dec) Then
            If dec <> 0 Then 'Zero is not either positive or negative.
                dec = Decimal.Negate(dec)
                Me.FocusedTextbox.Text = dec.ToString()
                If dec < 0 Then
                    sel += 1
                Else
                    If sel <> 0 Then sel -= 1
                End If
                Me.FocusedTextbox.SelectionStart = sel
            End If
        Else
            MessageBox.Show(String.Format("{0} is not in the correct format.", Me.FocusedTextbox.Text), "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btnDecimal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button15.Click
        'Going to have this method more versitile. Instead of only allowing a single decimal and handling a second one being inserted. 
        'I'm going to remove the previous one if it exists and insert the new one at the current selected position.
        If Me.FocusedTextbox Is Nothing Then
            MessageBox.Show("This instance of the On-Screen Numpad has no reference to an existing textbox that recieves the numeric key inputs.", "Object Null", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Me.FocusedTextbox.Text <> TextBoxNullValue Then
            Dim dec As Decimal = 0D
            'Since we're remove and adding single characters frequently based upon the current position and length. 
            'We need to maintain those values ourselfs accordingly.
            Dim start As Int32 = Me.FocusedTextbox.SelectionStart
            Dim len As Int32 = Me.FocusedTextbox.Text.Length

            If start = 0 Then 'We have to check if the we're before a negative sign when at selection start 0.
                If Decimal.TryParse(FocusedTextbox.Text, dec) Then
                    If dec < 0 Then 'Negative, and at position zero. Bump the selection start up to 1(after the negative sign).
                        start = 1
                    End If
                End If
            End If
            If Me.FocusedTextbox.Text.Contains("."c) Then
                If Me.FocusedTextbox.Text.IndexOf("."c) < start Then
                    start -= 1
                End If
                Me.FocusedTextbox.Text = Me.FocusedTextbox.Text.Replace("."c, String.Empty) 'Remove the previous decimal.
                len -= 1
            End If

            If start = len Then
                Me.FocusedTextbox.Text = Me.FocusedTextbox.Text & "0"
                len += 1
            End If
            Me.FocusedTextbox.Text = Me.FocusedTextbox.Text.Insert(start, ".")
            start += 1 'Adjust the new selection start position to after the decimal.
            If Decimal.TryParse(Me.FocusedTextbox.Text, dec) Then 'Successful parse if true.
                Me.FocusedTextbox.Text = dec.ToString() 'Set the text to a property numeric format {#.#}
            End If
            Me.FocusedTextbox.SelectionStart = (start) 'Always return after the newly inserted decimal.
        End If
    End Sub

    Private Sub AllButtons_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, _
                                                                                            Button3.MouseEnter, Button4.MouseEnter, _
                                                                                            Button5.MouseEnter, Button6.MouseEnter, _
                                                                                            Button7.MouseEnter, Button8.MouseEnter, _
                                                                                            Button9.MouseEnter, Button10.MouseEnter, _
                                                                                            Button11.MouseEnter, Button13.MouseEnter, _
                                                                                            Button14.MouseEnter, Button15.MouseEnter, _
                                                                                            Button16.MouseEnter
        PreventClosing = True 'Prevent closing when we're coming back into a button.
    End Sub
    Private Sub AllButtons_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, _
                                                                                            Button3.MouseLeave, Button4.MouseLeave, _
                                                                                            Button5.MouseLeave, Button6.MouseLeave, _
                                                                                            Button7.MouseLeave, Button8.MouseLeave, _
                                                                                            Button9.MouseLeave, Button10.MouseLeave, _
                                                                                            Button11.MouseLeave, Button13.MouseLeave, _
                                                                                            Button14.MouseLeave, Button15.MouseLeave, _
                                                                                            Button16.MouseLeave
        PreventClosing = False 'Remove the prevention since we have no relevence to a button at the moment
    End Sub

    Private Sub FocusedTextbox_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        PreventClosing = True
    End Sub
    Private Sub FocusedTextbox_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        PreventClosing = False
    End Sub
    Private Sub FocusedTextbox_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
        If Not PreventClosing Then
            Me.Close()
        End If
    End Sub
    Private Sub FocusedTextbox_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
        'nothing
    End Sub

End Class
