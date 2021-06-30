Imports MySql.Data.MySqlClient
Public Class VBMYSQL
    Public Property Server = "localhost"
    Public Property UserName = "root"
    Public Property Password = ""
    Public Property Database = "library"

    Public Function Connect_Server() As String
        Dim Conn As String
        Conn = "server=" & Server & ";userid=" & UserName & ";password=" & Password & ";database=" & Database
        Return Conn
    End Function

    Public Function Retrieve_Table(SQLStatement As String) As DataTable
        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand

        Try
            MySQL_Connection.ConnectionString = Connect_Server()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            Reader = MySQL_Command.ExecuteReader
            table.Load(Reader)
            Reader.Close()
            MySQL_Connection.Close()
        Catch ex As Exception
            MessageBox.Show("Proses baca data gagal." & vbCrLf & "Error Number = " & Err.Number & vbCrLf & ex.Message, "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
            table = Nothing
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
            Reader = Nothing
        End Try
        GC.Collect()
        Return table
    End Function

    Public Function Retrieve_Row(SQLStatement As String) As ArrayList
        Dim Result As New ArrayList
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand

        Try
            MySQL_Connection.ConnectionString = Connect_Server()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            Reader = MySQL_Command.ExecuteReader
            While Reader.Read()
                Dim dict As New Dictionary(Of String, Object)
                For count As Integer = 0 To (Reader.FieldCount - 1)
                    dict.Add(Reader.GetName(count), Reader(count))
                Next
                Result.Add(dict)
            End While
            Reader.Close()
            MySQL_Connection.Close()
        Catch ex As Exception
            MessageBox.Show("Proses baca data gagal." & vbCrLf & "Error Number = " & Err.Number & vbCrLf & ex.Message, "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
            Reader = Nothing
        End Try
        GC.Collect()
        Return Result
    End Function

    Public Function Retrieve_Value(SQLStatement As String) As String
        Dim Result As String
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand

        Try
            MySQL_Connection.ConnectionString = Connect_Server()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            Result = MySQL_Command.ExecuteScalar()
            MySQL_Connection.Close()
        Catch ex As Exception
            MessageBox.Show("Proses baca data gagal." & vbCrLf & "Error Number = " & Err.Number & vbCrLf & ex.Message, "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Result = Nothing
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
        End Try
        GC.Collect()
        Return Result
    End Function

    Public Function Insert_Row(SQLStatement As String) As Boolean
        Insert_Row = False
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand

        Try
            MySQL_Connection.ConnectionString = Connect_Server()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            MySQL_Command.ExecuteNonQuery()
            MySQL_Connection.Close()
            Insert_Row = True
        Catch ex As MySqlException
            MessageBox.Show("Proses simpan data gagal." & vbCrLf & "Error Number = " & Err.Number & vbCrLf & ex.Message, "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Insert_Row = False
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
        End Try
        GC.Collect()
    End Function

    Public Function Delete_Row(SQLStatement As String) As Boolean
        Delete_Row = False
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand

        Try
            MySQL_Connection.ConnectionString = Connect_Server()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            MySQL_Command.ExecuteNonQuery()
            MySQL_Connection.Close()
            Delete_Row = True
        Catch ex As MySqlException
            MessageBox.Show("Proses padam gagal." & vbCrLf & "Error Number = " & Err.Number & vbCrLf & ex.Message, "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Delete_Row = False
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
        End Try
        GC.Collect()
    End Function

End Class
