<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookStats
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
        Me.bttnback = New System.Windows.Forms.Button()
        Me.MblibdbDataSet = New Test.mblibdbDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New Test.mblibdbDataSetTableAdapters.booksTableAdapter()
        Me.RegisterNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MblibdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegisterNumberDataGridViewTextBoxColumn, Me.BookIDDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn, Me.ReturnDateDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.BookStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BooksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(687, 291)
        Me.DataGridView1.TabIndex = 1
        '
        'bttnback
        '
        Me.bttnback.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.bttnback.Location = New System.Drawing.Point(616, 309)
        Me.bttnback.Name = "bttnback"
        Me.bttnback.Size = New System.Drawing.Size(83, 23)
        Me.bttnback.TabIndex = 5
        Me.bttnback.Text = "Back"
        Me.bttnback.UseVisualStyleBackColor = True
        '
        'MblibdbDataSet
        '
        Me.MblibdbDataSet.DataSetName = "mblibdbDataSet"
        Me.MblibdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.MblibdbDataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'RegisterNumberDataGridViewTextBoxColumn
        '
        Me.RegisterNumberDataGridViewTextBoxColumn.DataPropertyName = "RegisterNumber"
        Me.RegisterNumberDataGridViewTextBoxColumn.HeaderText = "RegisterNumber"
        Me.RegisterNumberDataGridViewTextBoxColumn.Name = "RegisterNumberDataGridViewTextBoxColumn"
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
        'BookStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 340)
        Me.Controls.Add(Me.bttnback)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "BookStats"
        Me.Text = "BookStats"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MblibdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bttnback As System.Windows.Forms.Button
    Friend WithEvents MblibdbDataSet As Test.mblibdbDataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As Test.mblibdbDataSetTableAdapters.booksTableAdapter
    Friend WithEvents RegisterNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
