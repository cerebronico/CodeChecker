Module modMain
    Dim _onScreenNumpad As Numpad

    Public Declare Function SetParent Lib "user32.dll" (ByVal ChildHandle As IntPtr, ByVal ParentHandle As IntPtr) As IntPtr

    Public Sub LoadOnScreenNumpad(ByVal FocusedTextbox As TextBox, Optional ByVal parent As Object = Nothing)
        If _onScreenNumpad Is Nothing Then
            _onScreenNumpad = New Numpad(FocusedTextbox)
        End If
        If parent IsNot Nothing Then
            Call SetParent(_onScreenNumpad.Handle, parent.Handle)
        End If
        With _onScreenNumpad
            .Location = FocusedTextbox.PointToScreen(FocusedTextbox.Location)
            .Top = 250 'OnScreenNumpad.Top - (OnScreenNumpad.Height + FocusedTextbox.Top + 8)
            .Left = _onScreenNumpad.Left - (FocusedTextbox.Left + (_onScreenNumpad.Width / 2 - FocusedTextbox.Width / 2))
            .TopMost = True
            .Show()
        End With
    End Sub
    Public Sub UnloadOnScreenNumpad()
        _onScreenNumpad.Dispose()
        _onScreenNumpad = Nothing
    End Sub

End Module
