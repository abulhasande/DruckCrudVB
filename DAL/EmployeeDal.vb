Imports System.Data.SqlClient

Public Class EmployeeDal


    Private db As New DatabaseHelper()

    ' Craete Employee

    Public Function Create(employee As Employee) As Boolean
        Dim insertQuery As String = "INSERT INTO Employees (Name, Position, Department, Email) VALUES (@Name, @Position, @Department, @Email)"

        Using conn As SqlConnection = db.GetConnection()
            Using cmd As New SqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@Name", employee.Name)
                cmd.Parameters.AddWithValue("@Position", employee.Position)
                cmd.Parameters.AddWithValue("@Department", employee.Department)
                cmd.Parameters.AddWithValue("@Email", employee.Email)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function



    ' Edit Employee
    Public Function Edit(employee As Employee) As Boolean
        Dim editQuery As String = "UPDATE Employees set Name = @Name, Position = @Position, Department = @Department, Email = @Email Where Id = @Id"

        Using conn As SqlConnection = db.GetConnection()
            Using cmd As New SqlCommand(editQuery, conn)
                cmd.Parameters.AddWithValue("@Id", employee.Id)
                cmd.Parameters.AddWithValue("@Name", employee.Name)
                cmd.Parameters.AddWithValue("@Position", employee.Position)
                cmd.Parameters.AddWithValue("@Department", employee.Department)
                cmd.Parameters.AddWithValue("@Email", employee.Email)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Delete Employee
    Public Function Delete(employeeId As Integer) As Boolean
        Dim delQuery As String = "Delete from Employees Where Id = @Id"

        Using conn As SqlConnection = db.GetConnection()
            Using cmd As New SqlCommand(delQuery, conn)
                cmd.Parameters.AddWithValue("@Id", employeeId)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    'Get All Employees 

    Public Function GetAll() As List(Of Employee)
        Dim employees As New List(Of Employee)()
        Dim selQuery As String = "Select * from Employees"
        Try
            Using conn As SqlConnection = db.GetConnection()
                Using cmd As New SqlCommand(selQuery, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()

                                Dim emp As New Employee()
                                emp.Id = If(IsDBNull(reader("Id")), 0, Convert.ToInt32(reader("Id")))
                                emp.Name = If(IsDBNull(reader("Name")), String.Empty, reader("Name"))
                                emp.Position = If(IsDBNull(reader("Position")), String.Empty, reader("Position"))
                                emp.Email = If(IsDBNull(reader("Email")), String.Empty, reader("Email"))
                                emp.Department = If(IsDBNull(reader("Department")), String.Empty, reader("Department"))

                                employees.Add(emp)

                            End While
                        End If

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        Return employees
    End Function


End Class
