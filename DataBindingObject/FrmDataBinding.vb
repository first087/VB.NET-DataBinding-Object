Public Class FrmDataBinding

    Dim emp As Employee

    Private Sub FrmDataBinding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emp = New Employee("Ethan Hunt M", 18, Employee.GenderEnum.Male)
        EmployeeBindingSource.DataSource = emp
    End Sub
End Class
