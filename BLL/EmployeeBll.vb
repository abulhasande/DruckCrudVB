Public Class EmployeeBll

    Private dal As New EmployeeDal()

    Public Function AddEmployee(employee As Employee) As Boolean
        Return dal.Create(employee)
    End Function

    Public Function EditEmployee(employee As Employee) As Boolean
        Return dal.Edit(employee)
    End Function

    Public Function DeleteEmployee(employeeId As Integer) As Boolean
        Return dal.Delete(employeeId)
    End Function

    Public Function GetAllEmployees() As List(Of Employee)
        Return dal.GetAll()
    End Function

End Class
