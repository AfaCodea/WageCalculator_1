<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        tbWorkedHours = New TextBox()
        tbPayrate = New TextBox()
        lblGrossPay = New Label()
        btnCalculate = New Button()
        Label4 = New Label()
        Label5 = New Label()
        tbBasicWage = New TextBox()
        tbExtraWage = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(119, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 0
        Label1.Text = "Worked Hours:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(119, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 1
        Label2.Text = "Hourly Payrate:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(105, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 15)
        Label3.TabIndex = 2
        Label3.Text = "Gross pay earned:"
        ' 
        ' tbWorkedHours
        ' 
        tbWorkedHours.Location = New Point(248, 76)
        tbWorkedHours.Name = "tbWorkedHours"
        tbWorkedHours.Size = New Size(100, 23)
        tbWorkedHours.TabIndex = 3
        ' 
        ' tbPayrate
        ' 
        tbPayrate.Location = New Point(248, 114)
        tbPayrate.Name = "tbPayrate"
        tbPayrate.Size = New Size(100, 23)
        tbPayrate.TabIndex = 4
        ' 
        ' lblGrossPay
        ' 
        lblGrossPay.AutoSize = True
        lblGrossPay.Location = New Point(248, 236)
        lblGrossPay.Name = "lblGrossPay"
        lblGrossPay.Size = New Size(17, 15)
        lblGrossPay.TabIndex = 5
        lblGrossPay.Text = "--"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(248, 266)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(124, 44)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Calculate Gross Pay"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(139, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 15)
        Label4.TabIndex = 7
        Label4.Text = "Basic wage:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(138, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 8
        Label5.Text = "Extra wage:"
        ' 
        ' tbBasicWage
        ' 
        tbBasicWage.Location = New Point(248, 166)
        tbBasicWage.Name = "tbBasicWage"
        tbBasicWage.Size = New Size(100, 23)
        tbBasicWage.TabIndex = 9
        ' 
        ' tbExtraWage
        ' 
        tbExtraWage.Location = New Point(248, 200)
        tbExtraWage.Name = "tbExtraWage"
        tbExtraWage.Size = New Size(100, 23)
        tbExtraWage.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(572, 346)
        Controls.Add(tbExtraWage)
        Controls.Add(tbBasicWage)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnCalculate)
        Controls.Add(lblGrossPay)
        Controls.Add(tbPayrate)
        Controls.Add(tbWorkedHours)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Wage Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbWorkedHours As TextBox
    Friend WithEvents tbPayrate As TextBox
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbBasicWage As TextBox
    Friend WithEvents tbExtraWage As TextBox

End Class
