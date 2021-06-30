Public Class Form1
    Public Sub ReadDataFromDB()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMYSQL
        retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM books")
        If retrieveTable.CreateDataReader.HasRows = False Then
            MessageBox.Show("No data found.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim row As DataRow
        dgvList.Rows.Clear()
        For Each row In retrieveTable.Rows
            dgvList.Rows.Add(row("Author"), row("Publisher"), row("Pages"))
        Next
        retrieveTable = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadDataFromDB()
    End Sub

    Private Sub dgvList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellClick
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMYSQL
        Dim strAuthor As String
        If e.RowIndex < 0 Then Exit Sub
        strAuthor = dgvList.Item(0, e.RowIndex).Value.ToString()
        Dim strSql As String = "SELECT * FROM books WHERE Author = '" + strAuthor + "'"
        Try
            Result = retrieveRow.Retrieve_Row(strSql)

        Catch ex As Exception
            MessageBox.Show("The data reading process failed." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each row As Dictionary(Of String, Object) In Result
            With detail
                .txtAuthorDetail.Text = row("Author").ToString
                .txtPublisherDetail.Text = row("Publisher").ToString
                .nudPagesDetail.Value = CInt(row("Pages").ToString)
            End With

            With edit
                .txtAuthorEdit.Text = row("Author").ToString
                .txtPublisherEdit.Text = row("Publisher").ToString
                .nudPagesEdit.Value = CInt(row("Pages").ToString)
            End With
        Next
        Me.Hide()
        detail.Show()
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Me.Hide()
        addnew.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show(" Are you sure you want to Exit?", "Books", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
