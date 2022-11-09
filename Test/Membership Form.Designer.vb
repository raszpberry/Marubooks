<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Membership_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Membership_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_FN = New System.Windows.Forms.TextBox()
        Me.TextBox_LN = New System.Windows.Forms.TextBox()
        Me.BttnCrt = New System.Windows.Forms.Button()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Gender = New System.Windows.Forms.TextBox()
        Me.ComboBox_Dept = New System.Windows.Forms.ComboBox()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.TextBox_chckpass = New System.Windows.Forms.TextBox()
        Me.TextBox_Pass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_user = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblchcker = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Number:"
        '
        'TextBox_FN
        '
        Me.TextBox_FN.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_FN.Location = New System.Drawing.Point(180, 78)
        Me.TextBox_FN.Name = "TextBox_FN"
        Me.TextBox_FN.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_FN.TabIndex = 2
        '
        'TextBox_LN
        '
        Me.TextBox_LN.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_LN.Location = New System.Drawing.Point(286, 78)
        Me.TextBox_LN.Name = "TextBox_LN"
        Me.TextBox_LN.Size = New System.Drawing.Size(113, 20)
        Me.TextBox_LN.TabIndex = 3
        '
        'BttnCrt
        '
        Me.BttnCrt.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnCrt.Location = New System.Drawing.Point(323, 295)
        Me.BttnCrt.Name = "BttnCrt"
        Me.BttnCrt.Size = New System.Drawing.Size(76, 23)
        Me.BttnCrt.TabIndex = 4
        Me.BttnCrt.Text = "Create"
        Me.BttnCrt.UseVisualStyleBackColor = True
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ID.Location = New System.Drawing.Point(180, 130)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gender:"
        '
        'TextBox_Gender
        '
        Me.TextBox_Gender.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gender.Location = New System.Drawing.Point(180, 161)
        Me.TextBox_Gender.Name = "TextBox_Gender"
        Me.TextBox_Gender.ReadOnly = True
        Me.TextBox_Gender.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Gender.TabIndex = 7
        '
        'ComboBox_Dept
        '
        Me.ComboBox_Dept.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Dept.FormattingEnabled = True
        Me.ComboBox_Dept.Items.AddRange(New Object() {"CEN", "CED", "CAS", "CAFA", "CPAC"})
        Me.ComboBox_Dept.Location = New System.Drawing.Point(180, 188)
        Me.ComboBox_Dept.Name = "ComboBox_Dept"
        Me.ComboBox_Dept.Size = New System.Drawing.Size(219, 21)
        Me.ComboBox_Dept.TabIndex = 8
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Email.Location = New System.Drawing.Point(180, 215)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(219, 20)
        Me.TextBox_Email.TabIndex = 9
        '
        'TextBox_chckpass
        '
        Me.TextBox_chckpass.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_chckpass.Location = New System.Drawing.Point(180, 241)
        Me.TextBox_chckpass.Name = "TextBox_chckpass"
        Me.TextBox_chckpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_chckpass.Size = New System.Drawing.Size(219, 20)
        Me.TextBox_chckpass.TabIndex = 10
        '
        'TextBox_Pass
        '
        Me.TextBox_Pass.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Pass.Location = New System.Drawing.Point(180, 267)
        Me.TextBox_Pass.Name = "TextBox_Pass"
        Me.TextBox_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Pass.Size = New System.Drawing.Size(219, 20)
        Me.TextBox_Pass.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Department:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Email ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Enter Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Re - enter Password:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(286, 161)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(335, 161)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(141, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "NEW USER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 66)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'TextBox_user
        '
        Me.TextBox_user.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_user.Location = New System.Drawing.Point(180, 104)
        Me.TextBox_user.Name = "TextBox_user"
        Me.TextBox_user.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_user.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Username:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(177, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 24
        '
        'lblchcker
        '
        Me.lblchcker.AutoSize = True
        Me.lblchcker.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.lblchcker.ForeColor = System.Drawing.Color.Lime
        Me.lblchcker.Location = New System.Drawing.Point(183, 290)
        Me.lblchcker.Name = "lblchcker"
        Me.lblchcker.Size = New System.Drawing.Size(0, 13)
        Me.lblchcker.TabIndex = 25
        Me.lblchcker.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(286, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Return to main"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Membership_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(433, 348)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblchcker)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox_user)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Pass)
        Me.Controls.Add(Me.TextBox_chckpass)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.ComboBox_Dept)
        Me.Controls.Add(Me.TextBox_Gender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.BttnCrt)
        Me.Controls.Add(Me.TextBox_LN)
        Me.Controls.Add(Me.TextBox_FN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Membership_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_FN As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_LN As System.Windows.Forms.TextBox
    Friend WithEvents BttnCrt As System.Windows.Forms.Button
    Friend WithEvents TextBox_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Gender As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Dept As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_Email As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_chckpass As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_user As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblchcker As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
