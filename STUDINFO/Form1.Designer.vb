<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.STUDENT_INFODataSet = New STUDINFO.STUDENT_INFODataSet
        Me.STUDENT_INFOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENT_INFOTableAdapter = New STUDINFO.STUDENT_INFODataSetTableAdapters.STUDENT_INFOTableAdapter
        Me.TableAdapterManager = New STUDINFO.STUDENT_INFODataSetTableAdapters.TableAdapterManager
        Me.STUDENT_INFOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.STUDENT_INFOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.STUDENT_INFODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ADD = New System.Windows.Forms.Button
        Me.SAVE = New System.Windows.Forms.Button
        Me.DELETE = New System.Windows.Forms.Button
        Me.CLEAR = New System.Windows.Forms.Button
        Me.CANCEL = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.UPDATE = New System.Windows.Forms.Button
        CType(Me.STUDENT_INFODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENT_INFOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENT_INFOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STUDENT_INFOBindingNavigator.SuspendLayout()
        CType(Me.STUDENT_INFODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'STUDENT_INFODataSet
        '
        Me.STUDENT_INFODataSet.DataSetName = "STUDENT_INFODataSet"
        Me.STUDENT_INFODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STUDENT_INFOBindingSource
        '
        Me.STUDENT_INFOBindingSource.DataMember = "STUDENT_INFO"
        Me.STUDENT_INFOBindingSource.DataSource = Me.STUDENT_INFODataSet
        '
        'STUDENT_INFOTableAdapter
        '
        Me.STUDENT_INFOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.STUDENT_INFOTableAdapter = Me.STUDENT_INFOTableAdapter
        Me.TableAdapterManager.UpdateOrder = STUDINFO.STUDENT_INFODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STUDENT_INFOBindingNavigator
        '
        Me.STUDENT_INFOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.STUDENT_INFOBindingNavigator.BindingSource = Me.STUDENT_INFOBindingSource
        Me.STUDENT_INFOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.STUDENT_INFOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.STUDENT_INFOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.STUDENT_INFOBindingNavigatorSaveItem})
        Me.STUDENT_INFOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.STUDENT_INFOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.STUDENT_INFOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.STUDENT_INFOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.STUDENT_INFOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.STUDENT_INFOBindingNavigator.Name = "STUDENT_INFOBindingNavigator"
        Me.STUDENT_INFOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.STUDENT_INFOBindingNavigator.Size = New System.Drawing.Size(555, 25)
        Me.STUDENT_INFOBindingNavigator.TabIndex = 0
        Me.STUDENT_INFOBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'STUDENT_INFOBindingNavigatorSaveItem
        '
        Me.STUDENT_INFOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.STUDENT_INFOBindingNavigatorSaveItem.Image = CType(resources.GetObject("STUDENT_INFOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.STUDENT_INFOBindingNavigatorSaveItem.Name = "STUDENT_INFOBindingNavigatorSaveItem"
        Me.STUDENT_INFOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.STUDENT_INFOBindingNavigatorSaveItem.Text = "Save Data"
        '
        'STUDENT_INFODataGridView
        '
        Me.STUDENT_INFODataGridView.AutoGenerateColumns = False
        Me.STUDENT_INFODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STUDENT_INFODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.STUDENT_INFODataGridView.DataSource = Me.STUDENT_INFOBindingSource
        Me.STUDENT_INFODataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.STUDENT_INFODataGridView.Location = New System.Drawing.Point(12, 312)
        Me.STUDENT_INFODataGridView.Name = "STUDENT_INFODataGridView"
        Me.STUDENT_INFODataGridView.Size = New System.Drawing.Size(444, 220)
        Me.STUDENT_INFODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ROLL_NO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ROLL_NO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLASS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CLASS"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DIVISION"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DIVISION"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ROLL_NO."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DIVISION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CLASS"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENT_INFOBindingSource, "NAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(136, 121)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENT_INFOBindingSource, "ROLL_NO", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(138, 169)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(97, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENT_INFOBindingSource, "CLASS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Location = New System.Drawing.Point(136, 211)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(99, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENT_INFOBindingSource, "DIVISION", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Location = New System.Drawing.Point(136, 252)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(99, 20)
        Me.TextBox4.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.STUDENT_INFOBindingSource
        Me.ComboBox1.DisplayMember = "NAME"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(136, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(320, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'ADD
        '
        Me.ADD.Location = New System.Drawing.Point(468, 312)
        Me.ADD.Name = "ADD"
        Me.ADD.Size = New System.Drawing.Size(75, 23)
        Me.ADD.TabIndex = 11
        Me.ADD.Text = "ADD"
        Me.ADD.UseVisualStyleBackColor = True
        '
        'SAVE
        '
        Me.SAVE.Location = New System.Drawing.Point(468, 354)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(75, 23)
        Me.SAVE.TabIndex = 12
        Me.SAVE.Text = "SAVE"
        Me.SAVE.UseVisualStyleBackColor = True
        '
        'DELETE
        '
        Me.DELETE.Location = New System.Drawing.Point(468, 431)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(75, 23)
        Me.DELETE.TabIndex = 13
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'CLEAR
        '
        Me.CLEAR.Location = New System.Drawing.Point(468, 471)
        Me.CLEAR.Name = "CLEAR"
        Me.CLEAR.Size = New System.Drawing.Size(75, 23)
        Me.CLEAR.TabIndex = 14
        Me.CLEAR.Text = "CLEAR"
        Me.CLEAR.UseVisualStyleBackColor = True
        '
        'CANCEL
        '
        Me.CANCEL.Location = New System.Drawing.Point(468, 509)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(75, 23)
        Me.CANCEL.TabIndex = 15
        Me.CANCEL.Text = "CANCEL"
        Me.CANCEL.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("AR JULIAN", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(146, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 32)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "STUDENT_DATA_ENTRY"
        '
        'UPDATE
        '
        Me.UPDATE.Location = New System.Drawing.Point(468, 392)
        Me.UPDATE.Name = "UPDATE"
        Me.UPDATE.Size = New System.Drawing.Size(75, 23)
        Me.UPDATE.TabIndex = 17
        Me.UPDATE.Text = "UPDATE"
        Me.UPDATE.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(555, 571)
        Me.Controls.Add(Me.UPDATE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CANCEL)
        Me.Controls.Add(Me.CLEAR)
        Me.Controls.Add(Me.DELETE)
        Me.Controls.Add(Me.SAVE)
        Me.Controls.Add(Me.ADD)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.STUDENT_INFODataGridView)
        Me.Controls.Add(Me.STUDENT_INFOBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "STUDENT_INFO"
        CType(Me.STUDENT_INFODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENT_INFOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENT_INFOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STUDENT_INFOBindingNavigator.ResumeLayout(False)
        Me.STUDENT_INFOBindingNavigator.PerformLayout()
        CType(Me.STUDENT_INFODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents STUDENT_INFODataSet As STUDINFO.STUDENT_INFODataSet
    Friend WithEvents STUDENT_INFOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STUDENT_INFOTableAdapter As STUDINFO.STUDENT_INFODataSetTableAdapters.STUDENT_INFOTableAdapter
    Friend WithEvents TableAdapterManager As STUDINFO.STUDENT_INFODataSetTableAdapters.TableAdapterManager
    Friend WithEvents STUDENT_INFOBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents STUDENT_INFOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents STUDENT_INFODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ADD As System.Windows.Forms.Button
    Friend WithEvents SAVE As System.Windows.Forms.Button
    Friend WithEvents DELETE As System.Windows.Forms.Button
    Friend WithEvents CLEAR As System.Windows.Forms.Button
    Friend WithEvents CANCEL As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UPDATE As System.Windows.Forms.Button

End Class
