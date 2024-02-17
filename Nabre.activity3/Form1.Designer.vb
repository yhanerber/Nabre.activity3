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
        num1 = New TextBox()
        Label2 = New Label()
        num2 = New TextBox()
        resultkineme = New Label()
        btnMultiply = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter First Number"
        ' 
        ' num1
        ' 
        num1.Location = New Point(28, 32)
        num1.Name = "num1"
        num1.Size = New Size(125, 27)
        num1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 20)
        Label2.TabIndex = 2
        Label2.Text = "Enter Second Number"
        ' 
        ' num2
        ' 
        num2.Location = New Point(28, 106)
        num2.Name = "num2"
        num2.Size = New Size(125, 27)
        num2.TabIndex = 3
        ' 
        ' resultkineme
        ' 
        resultkineme.AutoSize = True
        resultkineme.Location = New Point(55, 242)
        resultkineme.Name = "resultkineme"
        resultkineme.Size = New Size(49, 20)
        resultkineme.TabIndex = 4
        resultkineme.Text = "Result"
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(39, 169)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(94, 29)
        btnMultiply.TabIndex = 5
        btnMultiply.Text = "Multiply"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnMultiply)
        Controls.Add(resultkineme)
        Controls.Add(num2)
        Controls.Add(Label2)
        Controls.Add(num1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents num1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents num2 As TextBox
    Friend WithEvents resultkineme As Label
    Friend WithEvents btnMultiply As Button

End Class
