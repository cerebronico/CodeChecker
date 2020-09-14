
Imports System.IO
imports Newtonsoft.Json.Linq

Public Class Admin
    Structure BoxFormat
        Public barcode as String
        Public client As String
        Public format As String
        Public size As String
    End Structure

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CLIENTE	PRESENTACION	    TALLA	CÓDIGO DE BARRA DE LA BASE
        'Mercadona 	8X1 KG	            52-58	8410063037851
        'Mercadona	6X2KG	            32-38	8410063066141
        'Mercadona	8X1KG	            32-38	8410063068152
        'Pescanova  España 6X2KG    	30-40   8410063080666
        'Pescanova  España 6X2KG ASC	60-70	8410063086323

        Dim packageFormat as List(Of BoxFormat) = New List(Of BoxFormat)()
        Dim package As BoxFormat

        Dim path As String = My.Application.Info.DirectoryPath
        
        if My.Computer.FileSystem.FileExists(path & "\boxes.json") Then

            Dim json as String = File.ReadAllText("boxes.json")
            Dim jsonres = JToken.Parse(json)
            If TypeOf jsonres.SelectToken("code") Is JObject Then
                Console.WriteLine("Checked JSON type : Token result is an object")
            End If

            Dim obj As JObject = JObject.Parse(json)
            
            Console.WriteLine("JSON string is " & obj.ToString)

            Dim objResult = obj.SelectToken("code")

            dim i as integer 

            For each code in obj
                'Dim cod as String = obj.SelectToken("customer").ToString
                i+=1    
                Console.WriteLine(i.ToString() & ": " & code.ToString())

            Next
            '    code.SelectToken("code").
            '    r ("customer")
            'Next



            'Dim jbarcode As String = objResult.SelectToken("codes").ToString
            'Dim jformat As String= objResult.SelectToken("Format").ToString
            'Dim jsize As String = objResult.SelectToken("Size").ToString

            

        End If

        
        Dim row As String() = New String(){"8410063037851","Mercadona","8X1 KG","52-58"}
        DataGridViewFormats.Rows.Add(row)
         
        
    End Sub

    Private Sub DataGridViewOperators_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewOperators.CellFormatting
        If e.ColumnIndex = 1  AndAlso e.Value IsNot Nothing Then
            DataGridViewOperators.Rows(e.RowIndex).Tag = e.Value
            e.Value = New [String]("●"c, e.Value.ToString().Length)
        End If
    End Sub


    Private Sub DataGridViewOperators_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridViewOperators.EditingControlShowing

        If DataGridViewOperators.CurrentCell.ColumnIndex = 1 Then 'select target column
            Dim textBox As TextBox = TryCast(e.Control, TextBox)

            If textBox IsNot Nothing Then
                textBox.UseSystemPasswordChar = True
            End If
        Else
            Dim textBox As TextBox = TryCast(e.Control, TextBox)

            If textBox IsNot Nothing Then
                textBox.UseSystemPasswordChar = False
            End If
        End If

        Dim txtBox = TryCast(e.Control, TextBox)
        'txtBox.KeyDown -= New KeyEventHandler(underlyingTextBox_KeyDown)
        'txtBox.KeyDown += New KeyEventHandler(underlyingTextBox_KeyDown)
        For Each row As DataGridViewRow In DataGridViewOperators.Rows
            If Not row.IsNewRow Then
                MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
            End If
        Next

    End Sub

End Class


