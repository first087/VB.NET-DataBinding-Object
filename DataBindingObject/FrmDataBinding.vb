Public Class FrmDataBinding

    Private emp As Employee

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        emp = New Employee("Ethan Hunt M", 18, Employee.GenderEnum.Unknown)
    End Sub

    Private Sub FrmDataBinding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeBindingSource.DataSource = emp
    End Sub

    Private Sub BtnAgePlus1_Click(sender As Object, e As EventArgs) Handles BtnAgePlus1.Click
        emp.Age += 1
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim strEmp As String = String.Format("Name={0}{3}Age={1}{3}Gender={2}", _
                                             emp.Name, emp.Age, emp.Gender, vbCrLf)
        MessageBox.Show(strEmp, "Employee")
    End Sub
End Class
