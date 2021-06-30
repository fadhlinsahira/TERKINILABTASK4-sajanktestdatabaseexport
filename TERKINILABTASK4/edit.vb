Public Class edit
    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        Dim strAuthor As String = txtAuthorEdit.Text
        Dim strPublisher As String = txtPublisherEdit.Text
        Dim intPages As Integer = nudPagesEdit.Value
        Dim strSql = "UPDATE books SET author='" & strAuthor & "',Publisher='" & strPublisher & "',Pages='" & intPages & "' WHERE Author= '" & strAuthor & "'"
        Dim CreateMySQL As New VBMYSQL
        Try
            CreateMySQL.Insert_Row(strSql)
            MessageBox.Show("Successfully Edited.", "Congratulations", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Failed to update data" & vbCrLf & ex.Message,
            "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
        Form1.ReadDataFromDB()
        Form1.Show()
    End Sub

    Private Sub btnCancelEdit_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
        Dim result = MessageBox.Show(" Are you sure you want to Cancel?", "Books", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub
End Class