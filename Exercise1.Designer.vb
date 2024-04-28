<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise1
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
        OutPutlbl = New Label()
        firstNum = New TextBox()
        SecondNum = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Sumlbl = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' OutPutlbl
        ' 
        OutPutlbl.AutoSize = True
        OutPutlbl.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point)
        OutPutlbl.Location = New Point(471, 110)
        OutPutlbl.Name = "OutPutlbl"
        OutPutlbl.Size = New Size(0, 29)
        OutPutlbl.TabIndex = 0
        ' 
        ' firstNum
        ' 
        firstNum.Location = New Point(150, 87)
        firstNum.Name = "firstNum"
        firstNum.Size = New Size(155, 23)
        firstNum.TabIndex = 1
        ' 
        ' SecondNum
        ' 
        SecondNum.Location = New Point(150, 135)
        SecondNum.Name = "SecondNum"
        SecondNum.Size = New Size(155, 23)
        SecondNum.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCoral
        Button1.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(150, 199)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 48)
        Button1.TabIndex = 3
        Button1.Text = "جمع"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightCoral
        Button2.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(271, 199)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 48)
        Button2.TabIndex = 4
        Button2.Text = "تفریق"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.IndianRed
        Button3.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(406, 199)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 48)
        Button3.TabIndex = 5
        Button3.Text = "خروج"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Sumlbl
        ' 
        Sumlbl.AutoSize = True
        Sumlbl.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Sumlbl.Location = New Point(54, 87)
        Sumlbl.Name = "Sumlbl"
        Sumlbl.Size = New Size(83, 19)
        Sumlbl.TabIndex = 6
        Sumlbl.Text = "عدد اول  :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(54, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 19)
        Label2.TabIndex = 7
        Label2.Text = "عدد دوم  :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(363, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 19)
        Label1.TabIndex = 8
        Label1.Text = "محاسبه   :"
        ' 
        ' Exercise1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGreen
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Sumlbl)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(SecondNum)
        Controls.Add(firstNum)
        Controls.Add(OutPutlbl)
        Name = "Exercise1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "جمع و تفریق"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OutPutlbl As Label
    Friend WithEvents firstNum As TextBox
    Friend WithEvents SecondNum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Sumlbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
