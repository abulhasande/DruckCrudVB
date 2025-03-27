Imports System.Data.SqlClient

Public Class DatabaseHelper


    Private ReadOnly connectionString As String = "Data Source=.;Initial Catalog=DruckEmployee;Integrated Security=True"


    Public Function GetConnection() As SqlConnection

        Return New SqlConnection(connectionString)

    End Function


End Class
