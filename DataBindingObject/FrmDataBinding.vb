Public Class FrmDataBinding

    Dim emp As Employee

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        emp = New Employee("Ethan Hunt M", 18, Employee.GenderEnum.Male)
    End Sub

    Private Sub FrmDataBinding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblName.Text = emp.Name
        NumAge.Value = emp.Age

        Select Case emp.Gender
            Case Employee.GenderEnum.Unknown : RdoGenderUnknown.Checked = True
            Case Employee.GenderEnum.Male : RdoGenderMale.Checked = True
            Case Employee.GenderEnum.Female : RdoGenderFemale.Checked = True
        End Select

        'EmployeeBindingSource.DataSource = emp
    End Sub

    Private Sub NumAge_ValueChanged(sender As Object, e As EventArgs) Handles NumAge.ValueChanged
        emp.Age = NumAge.Value
    End Sub

    Private Sub BtnAgePlus1_Click(sender As Object, e As EventArgs) Handles BtnAgePlus1.Click
        emp.Age += 1

        NumAge.Value = emp.Age
    End Sub

    Private Sub RdoGenderUnknown_CheckedChanged(sender As Object, e As EventArgs) Handles RdoGenderUnknown.CheckedChanged
        If emp Is Nothing Then Return
        If Not RdoGenderUnknown.Checked Then Return

        emp.Gender = Employee.GenderEnum.Unknown
    End Sub

    Private Sub RdoGenderMale_CheckedChanged(sender As Object, e As EventArgs) Handles RdoGenderMale.CheckedChanged
        If emp Is Nothing Then Return
        If Not RdoGenderMale.Checked Then Return

        emp.Gender = Employee.GenderEnum.Male
    End Sub

    Private Sub RdoGenderFemale_CheckedChanged(sender As Object, e As EventArgs) Handles RdoGenderFemale.CheckedChanged
        If emp Is Nothing Then Return
        If Not RdoGenderFemale.Checked Then Return

        emp.Gender = Employee.GenderEnum.Female
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim strEmp As String = String.Format("Name={0}, Age={1}, Gender={2}", _
                                             emp.Name, emp.Age, emp.Gender)
        MessageBox.Show(strEmp, "emp")
    End Sub
End Class
