Imports System.Data.SqlClient

Public Class EmployeeDal


    Private db As New DatabaseHelper()

    ' Craete Employee

    Public Function Create(employee As Employee) As Boolean
        Dim insertQuery As String = "INSERT INTO Employee (Name, Position, Department, Email) VALUES (@Name, @Position, @Department, @Email)"

        Using conn As SqlConnection = db.GetConnection()
            Using cmd As New SqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@Name", employee.Name)
                cmd.Parameters.AddWithValue("@Position", employee.Position)
                cmd.Parameters.AddWithValue("@Department", employee.Department)
                cmd.Parameters.AddWithValue("@Name", employee.Email)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function



    ' Edit Employee
    Public Function Edit(employee As Employee) As Boolean
        Dim employeeQuery As String = "UPDATE Employees set Name = @Name, Position = @Position, Department = @Department, Email = @Email Where Id = @Id"

        Using conn As SqlConnection = db.GetConnection()
            Using cmd As New SqlCommand(employeeQuery, conn)
                cmd.Parameters.AddWithValue("@Id", employee.Id)
                cmd.Parameters.AddWithValue("@Name", employee.Name)
                cmd.Parameters.AddWithValue("@Position", employee.Position)
                cmd.Parameters.AddWithValue("@Department", employee.Department)
                cmd.Parameters.AddWithValue("@Name", employee.Email)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function




End Class
