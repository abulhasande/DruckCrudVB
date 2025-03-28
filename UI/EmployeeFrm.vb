Imports System.Diagnostics.Eventing.Reader

Public Class EmployeeFrm

    Private empBll As New EmployeeBll
    Private selectedRowIndex As Integer
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextField()
    End Sub


    Private Sub EmployeeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadEmployees()

        ' Add Edit Button Column if not already added
        If dgvEmployee.Columns("btnEdit") Is Nothing Then
            Dim btnEditColumn As New DataGridViewButtonColumn()
            btnEditColumn.Name = "btnEdit"
            btnEditColumn.HeaderText = "Action"
            btnEditColumn.Text = "Edit"
            btnEditColumn.UseColumnTextForButtonValue = True
            dgvEmployee.Columns.Add(btnEditColumn)

        End If

        ' Add Delete Button Column if not already added
        If dgvEmployee.Columns("btnDelete") Is Nothing Then
            Dim btnColumn As New DataGridViewButtonColumn()
            btnColumn.Name = "btnDelete"
            btnColumn.HeaderText = "Action"
            btnColumn.Text = "Delete"
            btnColumn.UseColumnTextForButtonValue = True
            dgvEmployee.Columns.Add(btnColumn)
        End If

    End Sub

    Private Sub dgvEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellClick

        If e.ColumnIndex >= 0 AndAlso dgvEmployee.Columns(e.ColumnIndex).Name = "btnDelete" Then
            Dim rowIndex As Integer = e.RowIndex
            If rowIndex >= 0 Then
                Dim selectedEmployeeId As Integer = Convert.ToInt32(dgvEmployee.Rows(rowIndex).Cells("Id").Value)

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    empBll.DeleteEmployee(selectedEmployeeId)
                    LoadEmployees()
                    ClearTextField()
                End If
            End If
        End If

        If e.ColumnIndex >= 0 AndAlso dgvEmployee.Columns(e.ColumnIndex).Name = "btnEdit" Then
            Dim rowIndex As Integer = e.RowIndex
            If rowIndex >= 0 Then

                selectedRowIndex = rowIndex
                txtName.Text = dgvEmployee.Rows(rowIndex).Cells("Name").Value.ToString()
                txtPosition.Text = dgvEmployee.Rows(rowIndex).Cells("Position").Value.ToString()
                txtEmail.Text = dgvEmployee.Rows(rowIndex).Cells("Email").Value.ToString()
                cbDepartment.Text = dgvEmployee.Rows(rowIndex).Cells("Department").Value.ToString()

                dgvEmployee.Rows(rowIndex).Selected = True
                dgvEmployee.CurrentCell = dgvEmployee.Rows(rowIndex).Cells(0)
                btnSave.Text = "EDIT"

            End If
        End If


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

                If btnSave.Text = "SAVE" Then
                    empBll.AddEmployee(emp)
                    MessageBox.Show("Employee Saved Successfully")
                ElseIf btnSave.Text = "EDIT" Then
                    emp.Id = Convert.ToInt32(dgvEmployee.Rows(selectedRowIndex).Cells("Id").Value)
                    empBll.EditEmployee(emp)
                    MessageBox.Show("Employee updated Successfully")
                End If

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
        If employees.Count >= 0 Then
            dgvEmployee.DataSource = employees
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        End If
    End Sub

    Private Sub ClearTextField()
        Me.txtEmail.Clear()
        Me.txtName.Clear()
        Me.txtPosition.Clear()
        Me.cbDepartment.SelectedItem = Me.cbDepartment.Items(0)
        btnSave.Text = "SAVE"
        selectedRowIndex = 0
        Me.txtName.Focus()
    End Sub


End Class