Imports System.Configuration
Imports System.Data.SqlClient

Public Class DatabaseHelper


    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("MyDatabase").ConnectionString

    Public Function GetConnection() As SqlConnection

        Return New SqlConnection(connectionString)

    End Function


End Class
