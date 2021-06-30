Imports MySql.Data.MySqlClient
Public Class addnew
    Private Sub btnSaveAdd_Click(sender As Object, e As EventArgs) Handles btnSaveAdd.Click
        Dim intId As Integer
        Dim strAuthor As String = txtAuthorAdd.Text
        Dim strPublisher As String = txtPublisherAdd.Text
        Dim intPages As Integer = nudPageAdd.Value
        Dim strSql = "INSERT INTO books VALUES ('" & intId & "', '" & strAuthor & "', '" & strPublisher & "', '" & intPages & "')"
        Dim CreateMySQL As New VBMYSQL
        Try
            If strAuthor = "" And strPublisher = "" AndAlso intPages = 0 Then
                MessageBox.Show("Please insert data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                CreateMySQL.Insert_Row(strSql)
                MessageBox.Show("Data successfully saved.", "Congratulations", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
            MessageBox.Show("The data failed to stored." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Close()
            Form1.ReadDataFromDB()
            Form1.Show()
        End Try
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancelAdd.Click
        Dim result = MessageBox.Show(" Are you sure you want to Cancel?", "Books", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub
End Class