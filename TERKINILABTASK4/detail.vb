Public Class detail
    Private Sub btnCloseDetail_Click(sender As Object, e As EventArgs) Handles btnCloseDetail.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub btnEditDetail_Click(sender As Object, e As EventArgs) Handles btnEditDetail.Click
        Me.Hide()
        edit.Show()
    End Sub

    Private Sub btnDeleteDetail_Click(sender As Object, e As EventArgs) Handles btnDeleteDetail.Click
        Dim strAuthor As String = txtAuthorDetail.Text
        Dim strPublisher As String = txtPublisherDetail.Text
        Dim intPages As Integer = nudPagesDetail.Value
        Dim strSql = "DELETE FROM books WHERE Author=('" & strAuthor & "')"
        Dim DeleteMySQL As New VBMYSQL
        Try
            DeleteMySQL.Delete_Row(strSql)
            MessageBox.Show("Successfully deleted.", "Congratulations", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Failed to delete data" & vbCrLf & ex.Message,
           "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
        Form1.ReadDataFromDB()
        Form1.Show()
    End Sub

End Class