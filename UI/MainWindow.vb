Public Class MainWindow


    Private Sub btnEmployeeMenu_Click(sender As Object, e As EventArgs) Handles btnEmployeeMenu.Click
        Dim employeeFrm As New EmployeeFrm
        employeeFrm.Show()
    End Sub

    Private Sub btnAboutMenu_Click(sender As Object, e As EventArgs) Handles btnAboutMenu.Click
        Dim aboutFrm As New AboutFrm
        aboutFrm.Show()
    End Sub

    Private Sub btnHelpMenu_Click(sender As Object, e As EventArgs) Handles btnHelpMenu.Click
        Dim helpFrm As New HelpFrm
        helpFrm.Show()
    End Sub
End Class