<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.lblIndoor = New System.Windows.Forms.Label()
        Me.Customer_LoginDataSet = New Sport_Utility_System.Customer_LoginDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Sport_Utility_System.Customer_LoginDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Sport_Utility_System.Customer_LoginDataSetTableAdapters.TableAdapterManager()
        Me.Customer_LoginDataSet1 = New Sport_Utility_System.Customer_LoginDataSet1()
        Me.IndoorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndoorTableAdapter = New Sport_Utility_System.Customer_LoginDataSet1TableAdapters.IndoorTableAdapter()
        Me.TableAdapterManager1 = New Sport_Utility_System.Customer_LoginDataSet1TableAdapters.TableAdapterManager()
        Me.OutdoorTableAdapter = New Sport_Utility_System.Customer_LoginDataSet1TableAdapters.OutdoorTableAdapter()
        Me.IndoorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblOutdoor = New System.Windows.Forms.Label()
        Me.OutdoorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OutdoorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.Customer_LoginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_LoginDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndoorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndoorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutdoorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutdoorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIndoor
        '
        Me.lblIndoor.AutoSize = True
        Me.lblIndoor.BackColor = System.Drawing.Color.Transparent
        Me.lblIndoor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndoor.Location = New System.Drawing.Point(31, 130)
        Me.lblIndoor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIndoor.Name = "lblIndoor"
        Me.lblIndoor.Size = New System.Drawing.Size(165, 25)
        Me.lblIndoor.TabIndex = 8
        Me.lblIndoor.Text = "Indoor Items List: "
        '
        'Customer_LoginDataSet
        '
        Me.Customer_LoginDataSet.DataSetName = "Customer_LoginDataSet"
        Me.Customer_LoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Customer_LoginDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sport_Utility_System.Customer_LoginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Customer_LoginDataSet1
        '
        Me.Customer_LoginDataSet1.DataSetName = "Customer_LoginDataSet1"
        Me.Customer_LoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IndoorBindingSource
        '
        Me.IndoorBindingSource.DataMember = "Indoor"
        Me.IndoorBindingSource.DataSource = Me.Customer_LoginDataSet1
        '
        'IndoorTableAdapter
        '
        Me.IndoorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AdminTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.IndoorTableAdapter = Me.IndoorTableAdapter
        Me.TableAdapterManager1.LoginTableAdapter = Nothing
        Me.TableAdapterManager1.OutdoorTableAdapter = Me.OutdoorTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Sport_Utility_System.Customer_LoginDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OutdoorTableAdapter
        '
        Me.OutdoorTableAdapter.ClearBeforeFill = True
        '
        'IndoorDataGridView
        '
        Me.IndoorDataGridView.AllowUserToAddRows = False
        Me.IndoorDataGridView.AllowUserToDeleteRows = False
        Me.IndoorDataGridView.AutoGenerateColumns = False
        Me.IndoorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IndoorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.IndoorDataGridView.DataSource = Me.IndoorBindingSource
        Me.IndoorDataGridView.Location = New System.Drawing.Point(36, 158)
        Me.IndoorDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.IndoorDataGridView.Name = "IndoorDataGridView"
        Me.IndoorDataGridView.RowHeadersWidth = 51
        Me.IndoorDataGridView.Size = New System.Drawing.Size(456, 271)
        Me.IndoorDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Item_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item_Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'lblOutdoor
        '
        Me.lblOutdoor.AutoSize = True
        Me.lblOutdoor.BackColor = System.Drawing.Color.Transparent
        Me.lblOutdoor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutdoor.Location = New System.Drawing.Point(31, 432)
        Me.lblOutdoor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutdoor.Name = "lblOutdoor"
        Me.lblOutdoor.Size = New System.Drawing.Size(181, 25)
        Me.lblOutdoor.TabIndex = 9
        Me.lblOutdoor.Text = "Outdoor Items List: "
        '
        'OutdoorBindingSource
        '
        Me.OutdoorBindingSource.DataMember = "Outdoor"
        Me.OutdoorBindingSource.DataSource = Me.Customer_LoginDataSet1
        '
        'OutdoorDataGridView
        '
        Me.OutdoorDataGridView.AllowUserToAddRows = False
        Me.OutdoorDataGridView.AllowUserToDeleteRows = False
        Me.OutdoorDataGridView.AutoGenerateColumns = False
        Me.OutdoorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OutdoorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.OutdoorDataGridView.DataSource = Me.OutdoorBindingSource
        Me.OutdoorDataGridView.Location = New System.Drawing.Point(36, 459)
        Me.OutdoorDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.OutdoorDataGridView.Name = "OutdoorDataGridView"
        Me.OutdoorDataGridView.RowHeadersWidth = 51
        Me.OutdoorDataGridView.Size = New System.Drawing.Size(456, 271)
        Me.OutdoorDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Item_Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Item_Name"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(825, 702)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(965, 754)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.OutdoorDataGridView)
        Me.Controls.Add(Me.lblOutdoor)
        Me.Controls.Add(Me.IndoorDataGridView)
        Me.Controls.Add(Me.lblIndoor)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form6"
        Me.Text = "Admin"
        CType(Me.Customer_LoginDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_LoginDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndoorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndoorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutdoorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutdoorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIndoor As Label
    Friend WithEvents Customer_LoginDataSet As Customer_LoginDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As Customer_LoginDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Customer_LoginDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Customer_LoginDataSet1 As Customer_LoginDataSet1
    Friend WithEvents IndoorBindingSource As BindingSource
    Friend WithEvents IndoorTableAdapter As Customer_LoginDataSet1TableAdapters.IndoorTableAdapter
    Friend WithEvents TableAdapterManager1 As Customer_LoginDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IndoorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents OutdoorTableAdapter As Customer_LoginDataSet1TableAdapters.OutdoorTableAdapter
    Friend WithEvents lblOutdoor As Label
    Friend WithEvents OutdoorBindingSource As BindingSource
    Friend WithEvents OutdoorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
End Class
