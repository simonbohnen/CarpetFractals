<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditMatrix
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mat20 = New System.Windows.Forms.TextBox()
        Me.mat21 = New System.Windows.Forms.TextBox()
        Me.mat22 = New System.Windows.Forms.TextBox()
        Me.mat10 = New System.Windows.Forms.TextBox()
        Me.mat11 = New System.Windows.Forms.TextBox()
        Me.mat12 = New System.Windows.Forms.TextBox()
        Me.mat00 = New System.Windows.Forms.TextBox()
        Me.mat01 = New System.Windows.Forms.TextBox()
        Me.mat02 = New System.Windows.Forms.TextBox()
        Me.matInp = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.blue = New System.Windows.Forms.TextBox()
        Me.green = New System.Windows.Forms.TextBox()
        Me.red = New System.Windows.Forms.TextBox()
        Me.editMatrixButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "-->"
        '
        'mat20
        '
        Me.mat20.Location = New System.Drawing.Point(162, 12)
        Me.mat20.Name = "mat20"
        Me.mat20.Size = New System.Drawing.Size(36, 20)
        Me.mat20.TabIndex = 3
        '
        'mat21
        '
        Me.mat21.Location = New System.Drawing.Point(162, 38)
        Me.mat21.Name = "mat21"
        Me.mat21.Size = New System.Drawing.Size(36, 20)
        Me.mat21.TabIndex = 6
        '
        'mat22
        '
        Me.mat22.Location = New System.Drawing.Point(162, 64)
        Me.mat22.Name = "mat22"
        Me.mat22.Size = New System.Drawing.Size(36, 20)
        Me.mat22.TabIndex = 9
        '
        'mat10
        '
        Me.mat10.Location = New System.Drawing.Point(120, 12)
        Me.mat10.Name = "mat10"
        Me.mat10.Size = New System.Drawing.Size(36, 20)
        Me.mat10.TabIndex = 2
        '
        'mat11
        '
        Me.mat11.Location = New System.Drawing.Point(120, 38)
        Me.mat11.Name = "mat11"
        Me.mat11.Size = New System.Drawing.Size(36, 20)
        Me.mat11.TabIndex = 5
        '
        'mat12
        '
        Me.mat12.Location = New System.Drawing.Point(120, 64)
        Me.mat12.Name = "mat12"
        Me.mat12.Size = New System.Drawing.Size(36, 20)
        Me.mat12.TabIndex = 8
        '
        'mat00
        '
        Me.mat00.Location = New System.Drawing.Point(78, 12)
        Me.mat00.Name = "mat00"
        Me.mat00.Size = New System.Drawing.Size(36, 20)
        Me.mat00.TabIndex = 1
        '
        'mat01
        '
        Me.mat01.Location = New System.Drawing.Point(78, 38)
        Me.mat01.Name = "mat01"
        Me.mat01.Size = New System.Drawing.Size(36, 20)
        Me.mat01.TabIndex = 4
        '
        'mat02
        '
        Me.mat02.Location = New System.Drawing.Point(78, 64)
        Me.mat02.Name = "mat02"
        Me.mat02.Size = New System.Drawing.Size(36, 20)
        Me.mat02.TabIndex = 7
        '
        'matInp
        '
        Me.matInp.Enabled = False
        Me.matInp.Location = New System.Drawing.Point(12, 38)
        Me.matInp.Name = "matInp"
        Me.matInp.Size = New System.Drawing.Size(38, 20)
        Me.matInp.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.blue)
        Me.GroupBox1.Controls.Add(Me.green)
        Me.GroupBox1.Controls.Add(Me.red)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 103)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Blue:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Green:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Red:"
        '
        'blue
        '
        Me.blue.Location = New System.Drawing.Point(47, 71)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(130, 20)
        Me.blue.TabIndex = 12
        '
        'green
        '
        Me.green.Location = New System.Drawing.Point(47, 45)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(130, 20)
        Me.green.TabIndex = 11
        '
        'red
        '
        Me.red.Location = New System.Drawing.Point(47, 19)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(130, 20)
        Me.red.TabIndex = 10
        '
        'editMatrixButton
        '
        Me.editMatrixButton.Location = New System.Drawing.Point(12, 199)
        Me.editMatrixButton.Name = "editMatrixButton"
        Me.editMatrixButton.Size = New System.Drawing.Size(186, 23)
        Me.editMatrixButton.TabIndex = 12
        Me.editMatrixButton.Text = "Save changes"
        Me.editMatrixButton.UseVisualStyleBackColor = True
        '
        'EditMatrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 227)
        Me.Controls.Add(Me.editMatrixButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.matInp)
        Me.Controls.Add(Me.mat02)
        Me.Controls.Add(Me.mat01)
        Me.Controls.Add(Me.mat00)
        Me.Controls.Add(Me.mat12)
        Me.Controls.Add(Me.mat11)
        Me.Controls.Add(Me.mat10)
        Me.Controls.Add(Me.mat22)
        Me.Controls.Add(Me.mat21)
        Me.Controls.Add(Me.mat20)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditMatrix"
        Me.Text = "Edit Matrix"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mat20 As TextBox
    Friend WithEvents mat21 As TextBox
    Friend WithEvents mat22 As TextBox
    Friend WithEvents mat10 As TextBox
    Friend WithEvents mat11 As TextBox
    Friend WithEvents mat12 As TextBox
    Friend WithEvents mat00 As TextBox
    Friend WithEvents mat01 As TextBox
    Friend WithEvents mat02 As TextBox
    Friend WithEvents matInp As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents blue As TextBox
    Friend WithEvents green As TextBox
    Friend WithEvents red As TextBox
    Friend WithEvents editMatrixButton As Button
End Class
