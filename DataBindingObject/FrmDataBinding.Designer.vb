<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataBinding
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAgePlus1 = New System.Windows.Forms.Button()
        Me.RdoGenderFemale = New System.Windows.Forms.RadioButton()
        Me.RdoGenderMale = New System.Windows.Forms.RadioButton()
        Me.RdoGenderUnknown = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumAge = New System.Windows.Forms.NumericUpDown()
        Me.LblName = New System.Windows.Forms.Label()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnAgePlus1)
        Me.GroupBox1.Controls.Add(Me.RdoGenderFemale)
        Me.GroupBox1.Controls.Add(Me.RdoGenderMale)
        Me.GroupBox1.Controls.Add(Me.RdoGenderUnknown)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumAge)
        Me.GroupBox1.Controls.Add(Me.LblName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee"
        '
        'BtnAgePlus1
        '
        Me.BtnAgePlus1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgePlus1.Location = New System.Drawing.Point(161, 53)
        Me.BtnAgePlus1.Name = "BtnAgePlus1"
        Me.BtnAgePlus1.Size = New System.Drawing.Size(37, 23)
        Me.BtnAgePlus1.TabIndex = 1
        Me.BtnAgePlus1.Text = "+1"
        Me.BtnAgePlus1.UseVisualStyleBackColor = True
        '
        'RdoGenderFemale
        '
        Me.RdoGenderFemale.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RdoGenderFemale.AutoSize = True
        Me.RdoGenderFemale.Location = New System.Drawing.Point(226, 82)
        Me.RdoGenderFemale.Name = "RdoGenderFemale"
        Me.RdoGenderFemale.Size = New System.Drawing.Size(68, 20)
        Me.RdoGenderFemale.TabIndex = 4
        Me.RdoGenderFemale.Text = "Female"
        Me.RdoGenderFemale.UseVisualStyleBackColor = True
        '
        'RdoGenderMale
        '
        Me.RdoGenderMale.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RdoGenderMale.AutoSize = True
        Me.RdoGenderMale.Location = New System.Drawing.Point(167, 82)
        Me.RdoGenderMale.Name = "RdoGenderMale"
        Me.RdoGenderMale.Size = New System.Drawing.Size(53, 20)
        Me.RdoGenderMale.TabIndex = 3
        Me.RdoGenderMale.Text = "Male"
        Me.RdoGenderMale.UseVisualStyleBackColor = True
        '
        'RdoGenderUnknown
        '
        Me.RdoGenderUnknown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RdoGenderUnknown.AutoSize = True
        Me.RdoGenderUnknown.Checked = True
        Me.RdoGenderUnknown.Location = New System.Drawing.Point(83, 82)
        Me.RdoGenderUnknown.Name = "RdoGenderUnknown"
        Me.RdoGenderUnknown.Size = New System.Drawing.Size(78, 20)
        Me.RdoGenderUnknown.TabIndex = 2
        Me.RdoGenderUnknown.TabStop = True
        Me.RdoGenderUnknown.Text = "Unknown"
        Me.RdoGenderUnknown.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'NumAge
        '
        Me.NumAge.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NumAge.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "Age", True))
        Me.NumAge.Location = New System.Drawing.Point(83, 54)
        Me.NumAge.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.NumAge.Name = "NumAge"
        Me.NumAge.Size = New System.Drawing.Size(72, 23)
        Me.NumAge.TabIndex = 0
        '
        'LblName
        '
        Me.LblName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblName.AutoSize = True
        Me.LblName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Name", True))
        Me.LblName.Location = New System.Drawing.Point(80, 28)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(57, 16)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "LblName"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataSource = GetType(DataBindingObject.Employee)
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnSave.Location = New System.Drawing.Point(135, 166)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmDataBinding
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(344, 201)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Name = "FrmDataBinding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataBinding with Object"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents RdoGenderFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RdoGenderMale As System.Windows.Forms.RadioButton
    Friend WithEvents RdoGenderUnknown As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumAge As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnAgePlus1 As System.Windows.Forms.Button
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource

End Class
