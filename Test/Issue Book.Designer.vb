<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Issue_Book
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MblibdbDataSet = New Test.mblibdbDataSet()
        Me.BttnIssue = New System.Windows.Forms.Button()
        Me.BttnReturn = New System.Windows.Forms.Button()
        Me.bttnback = New System.Windows.Forms.Button()
        Me.BooksTableAdapter = New Test.mblibdbDataSetTableAdapters.booksTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MblibdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn, Me.ReturnDateDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.BookStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BooksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 291)
        Me.DataGridView1.TabIndex = 0
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        '
        'IssueDateDataGridViewTextBoxColumn
        '
        Me.IssueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.Name = "IssueDateDataGridViewTextBoxColumn"
        '
        'ReturnDateDataGridViewTextBoxColumn
        '
        Me.ReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate"
        Me.ReturnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate"
        Me.ReturnDateDataGridViewTextBoxColumn.Name = "ReturnDateDataGridViewTextBoxColumn"
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        '
        'BookStatusDataGridViewTextBoxColumn
        '
        Me.BookStatusDataGridViewTextBoxColumn.DataPropertyName = "BookStatus"
        Me.BookStatusDataGridViewTextBoxColumn.HeaderText = "BookStatus"
        Me.BookStatusDataGridViewTextBoxColumn.Name = "BookStatusDataGridViewTextBoxColumn"
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.MblibdbDataSet
        '
        'MblibdbDataSet
        '
        Me.MblibdbDataSet.DataSetName = "mblibdbDataSet"
        Me.MblibdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BttnIssue
        '
        Me.BttnIssue.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.BttnIssue.Location = New System.Drawing.Point(381, 309)
        Me.BttnIssue.Name = "BttnIssue"
        Me.BttnIssue.Size = New System.Drawing.Size(83, 31)
        Me.BttnIssue.TabIndex = 2
        Me.BttnIssue.Text = "Issue Book"
        Me.BttnIssue.UseVisualStyleBackColor = True
        '
        'BttnReturn
        '
        Me.BttnReturn.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.BttnReturn.Location = New System.Drawing.Point(473, 309)
        Me.BttnReturn.Name = "BttnReturn"
        Me.BttnReturn.Size = New System.Drawing.Size(83, 31)
        Me.BttnReturn.TabIndex = 3
        Me.BttnReturn.Text = "Return Book"
        Me.BttnReturn.UseVisualStyleBackColor = True
        '
        'bttnback
        '
        Me.bttnback.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.bttnback.Location = New System.Drawing.Point(473, 346)
        Me.bttnback.Name = "bttnback"
        Me.bttnback.Size = New System.Drawing.Size(83, 23)
        Me.bttnback.TabIndex = 4
        Me.bttnback.Text = "Back"
        Me.bttnback.UseVisualStyleBackColor = True
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 6
        '
        'Issue_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 375)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnback)
        Me.Controls.Add(Me.BttnReturn)
        Me.Controls.Add(Me.BttnIssue)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Issue_Book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issue_Book"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MblibdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BttnIssue As System.Windows.Forms.Button
    Friend WithEvents BttnReturn As System.Windows.Forms.Button
    Friend WithEvents bttnback As System.Windows.Forms.Button
    Friend WithEvents MblibdbDataSet As Test.mblibdbDataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As Test.mblibdbDataSetTableAdapters.booksTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BookIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
