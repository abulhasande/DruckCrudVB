Imports System.Diagnostics.Eventing.Reader

Public Class EmployeeFrm

    Private empBll As New EmployeeBll

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextField()
    End Sub


    Private Sub EmployeeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        Me.txtName.Focus()

    End Sub

    Private Sub dgvEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellClick

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Dim emp As New Employee()
            Dim flag As Integer = 0

            If String.IsNullOrEmpty(cbDepartment.Text) Then
                flag = 1
                MessageBox.Show("Please select a department")
                cbDepartment.Focus()
            Else
                emp.Department = cbDepartment.Text
            End If

            If String.IsNullOrEmpty(txtName.Text) Then
                flag = 2
                MessageBox.Show("Please type Employee Name")
                txtName.Focus()
            Else
                emp.Name = txtName.Text
            End If

            If String.IsNullOrEmpty(txtPosition.Text) Then
                flag = 3
                MessageBox.Show("Please type Employee Position")
                txtName.Focus()
            Else
                emp.Position = txtPosition.Text
            End If

            If String.IsNullOrEmpty(txtEmail.Text) Then
                flag = 3
                MessageBox.Show("Please type Employee Email")
                txtEmail.Focus()
            Else
                emp.Email = txtEmail.Text
            End If


            If flag = 0 Then
                empBll.AddEmployee(emp)
                LoadEmployees()
                ClearTextField()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub LoadEmployees()
        Dim employees As New List(Of Employee)()
        employees = empBll.GetAllEmployees()
        If employees.Count > 0 Then
            dgvEmployee.DataSource = employees
        End If
    End Sub

    Private Sub ClearTextField()
        Me.txtEmail.Clear()
        Me.txtName.Clear()
        Me.txtPosition.Clear()
        Me.cbDepartment.SelectedItem = Me.cbDepartment.Items(0)
        Me.txtName.Focus()
    End Sub

End Class