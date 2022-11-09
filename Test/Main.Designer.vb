<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BttnExt = New System.Windows.Forms.Button()
        Me.BttnStatus = New System.Windows.Forms.Button()
        Me.BttnIssue = New System.Windows.Forms.Button()
        Me.BttnMember = New System.Windows.Forms.Button()
        Me.LblLibNme = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(68, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Admin Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BttnExt
        '
        Me.BttnExt.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnExt.Location = New System.Drawing.Point(178, 115)
        Me.BttnExt.Name = "BttnExt"
        Me.BttnExt.Size = New System.Drawing.Size(104, 26)
        Me.BttnExt.TabIndex = 9
        Me.BttnExt.Text = "Exit"
        Me.BttnExt.UseVisualStyleBackColor = True
        '
        'BttnStatus
        '
        Me.BttnStatus.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnStatus.Location = New System.Drawing.Point(227, 62)
        Me.BttnStatus.Name = "BttnStatus"
        Me.BttnStatus.Size = New System.Drawing.Size(104, 47)
        Me.BttnStatus.TabIndex = 8
        Me.BttnStatus.Text = "View Book Status"
        Me.BttnStatus.UseVisualStyleBackColor = True
        '
        'BttnIssue
        '
        Me.BttnIssue.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnIssue.Location = New System.Drawing.Point(122, 62)
        Me.BttnIssue.Name = "BttnIssue"
        Me.BttnIssue.Size = New System.Drawing.Size(104, 47)
        Me.BttnIssue.TabIndex = 7
        Me.BttnIssue.Text = "Issue / Return Book"
        Me.BttnIssue.UseVisualStyleBackColor = True
        '
        'BttnMember
        '
        Me.BttnMember.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnMember.Location = New System.Drawing.Point(17, 62)
        Me.BttnMember.Name = "BttnMember"
        Me.BttnMember.Size = New System.Drawing.Size(104, 47)
        Me.BttnMember.TabIndex = 6
        Me.BttnMember.Text = "Membership Form"
        Me.BttnMember.UseVisualStyleBackColor = True
        '
        'LblLibNme
        '
        Me.LblLibNme.AutoSize = True
        Me.LblLibNme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblLibNme.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLibNme.ForeColor = System.Drawing.Color.Navy
        Me.LblLibNme.Location = New System.Drawing.Point(84, 9)
        Me.LblLibNme.Name = "LblLibNme"
        Me.LblLibNme.Size = New System.Drawing.Size(181, 39)
        Me.LblLibNme.TabIndex = 5
        Me.LblLibNme.Text = "MARUBOOKS"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(347, 165)
        Me.Controls.Add(Me.BttnExt)
        Me.Controls.Add(Me.BttnStatus)
        Me.Controls.Add(Me.BttnIssue)
        Me.Controls.Add(Me.BttnMember)
        Me.Controls.Add(Me.LblLibNme)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BttnExt As System.Windows.Forms.Button
    Friend WithEvents BttnStatus As System.Windows.Forms.Button
    Friend WithEvents BttnIssue As System.Windows.Forms.Button
    Friend WithEvents BttnMember As System.Windows.Forms.Button
    Friend WithEvents LblLibNme As System.Windows.Forms.Label

End Class
