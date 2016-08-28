Imports System.Data.SqlClient

Module Connection
    Private cn As SqlConnection
    Private connectionString As String = "Data Source=.\SQLEXPRESS;AttachedDbFilename=" & Environment.CurrentDirectory & "\Database2.mdf;Integrated Security=True;User Instance=True"
    Private cnAdapter As SqlDataAdapter
    Private cnReader As SqlDataReader
    Private command As SqlCommand
    Private dataSet As New DataSet()
    Private datatable As DataTable

    Public Sub connect()
        cn = New SqlConnection(connectionString)
        If cn.State <> ConnectionState.Closed Then cn.Close()
    End Sub

    Public Sub openReader(ByVal query As String)
        Try
            If cn.State <> ConnectionState.Closed Then cn.Close()
            cn.Open()
            command = cn.CreateCommand
            command.CommandText = query
            cnReader = command.ExecuteReader
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub

    Public Function opendatatable(ByVal query As String)
        Try
            If cn.State <> ConnectionState.Closed Then cn.Close()
            cn.Open()
            datatable = New DataTable
            cnAdapter = New SqlDataAdapter(query, connectionString)
            cnAdapter.Fill(datatable)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try

        Return datatable
    End Function
End Module