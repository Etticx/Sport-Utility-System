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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Customer_LoginDataSet = New Sport_Utility_System.Customer_LoginDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Sport_Utility_System.Customer_LoginDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Sport_Utility_System.Customer_LoginDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAboutUs = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNaviOutdoor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnIndoor = New System.Windows.Forms.Button()
        Me.btnOutdoor = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.btnShows = New System.Windows.Forms.Button()
        CType(Me.Customer_LoginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.grpLogin.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.grpCategory.SuspendLayout()
        Me.SuspendLayout()
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 25)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "mnu"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAboutUs, Me.AdminToolStripMenuItem})
        Me.mnuHelp.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(52, 21)
        Me.mnuHelp.Text = "Help"
        '
        'mnAboutUs
        '
        Me.mnAboutUs.Name = "mnAboutUs"
        Me.mnAboutUs.Size = New System.Drawing.Size(224, 26)
        Me.mnAboutUs.Text = "About Us"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.LightBlue
        Me.MenuStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.mnuLogOut})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(736, 28)
        Me.MenuStrip2.TabIndex = 26
        Me.MenuStrip2.Text = "MenuStrip2"
        Me.MenuStrip2.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.mnuNaviOutdoor})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(79, 24)
        Me.ToolStripMenuItem1.Text = "Navigate"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(145, 26)
        Me.ToolStripMenuItem2.Text = "Indoor"
        '
        'mnuNaviOutdoor
        '
        Me.mnuNaviOutdoor.Name = "mnuNaviOutdoor"
        Me.mnuNaviOutdoor.Size = New System.Drawing.Size(145, 26)
        Me.mnuNaviOutdoor.Text = "Outdoor"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.AdminToolStripMenuItem1})
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(52, 24)
        Me.ToolStripMenuItem3.Text = "Help"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(151, 26)
        Me.ToolStripMenuItem4.Text = "About Us"
        '
        'AdminToolStripMenuItem1
        '
        Me.AdminToolStripMenuItem1.Name = "AdminToolStripMenuItem1"
        Me.AdminToolStripMenuItem1.Size = New System.Drawing.Size(151, 26)
        Me.AdminToolStripMenuItem1.Text = "Admin"
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(75, 24)
        Me.mnuLogOut.Text = "Log Out"
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(146, 129)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(75, 32)
        Me.btnSignUp.TabIndex = 4
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(268, 129)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(64, 32)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'grpLogin
        '
        Me.grpLogin.BackColor = System.Drawing.Color.Transparent
        Me.grpLogin.Controls.Add(Me.btnShows)
        Me.grpLogin.Controls.Add(Me.txtPassword)
        Me.grpLogin.Controls.Add(Me.txtUsername)
        Me.grpLogin.Controls.Add(Me.lblPassword)
        Me.grpLogin.Controls.Add(Me.lblUsername)
        Me.grpLogin.Location = New System.Drawing.Point(24, 10)
        Me.grpLogin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpLogin.Size = New System.Drawing.Size(490, 120)
        Me.grpLogin.TabIndex = 2
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(122, 67)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(264, 25)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(122, 26)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(264, 25)
        Me.txtUsername.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(48, 70)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 17)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(48, 29)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(81, 17)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'grpInput
        '
        Me.grpInput.BackColor = System.Drawing.Color.Transparent
        Me.grpInput.Controls.Add(Me.grpLogin)
        Me.grpInput.Controls.Add(Me.btnLogin)
        Me.grpInput.Controls.Add(Me.btnSignUp)
        Me.grpInput.Location = New System.Drawing.Point(129, 181)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(493, 161)
        Me.grpInput.TabIndex = 5
        Me.grpInput.TabStop = False
        '
        'btnIndoor
        '
        Me.btnIndoor.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIndoor.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIndoor.Location = New System.Drawing.Point(94, 58)
        Me.btnIndoor.Name = "btnIndoor"
        Me.btnIndoor.Size = New System.Drawing.Size(143, 60)
        Me.btnIndoor.TabIndex = 0
        Me.btnIndoor.Text = "Indoor"
        Me.btnIndoor.UseVisualStyleBackColor = False
        '
        'btnOutdoor
        '
        Me.btnOutdoor.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOutdoor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOutdoor.Location = New System.Drawing.Point(274, 58)
        Me.btnOutdoor.Name = "btnOutdoor"
        Me.btnOutdoor.Size = New System.Drawing.Size(144, 60)
        Me.btnOutdoor.TabIndex = 1
        Me.btnOutdoor.Text = "Outdoor"
        Me.btnOutdoor.UseVisualStyleBackColor = False
        '
        'grpCategory
        '
        Me.grpCategory.BackColor = System.Drawing.Color.Transparent
        Me.grpCategory.Controls.Add(Me.btnOutdoor)
        Me.grpCategory.Controls.Add(Me.btnIndoor)
        Me.grpCategory.Location = New System.Drawing.Point(123, 179)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(499, 163)
        Me.grpCategory.TabIndex = 5
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        Me.grpCategory.Visible = False
        '
        'btnShows
        '
        Me.btnShows.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShows.Location = New System.Drawing.Point(394, 69)
        Me.btnShows.Name = "btnShows"
        Me.btnShows.Size = New System.Drawing.Size(75, 23)
        Me.btnShows.TabIndex = 4
        Me.btnShows.Text = "Show"
        Me.btnShows.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(736, 368)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.grpInput)
        Me.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.Customer_LoginDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpCategory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Customer_LoginDataSet As Customer_LoginDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As Customer_LoginDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Customer_LoginDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnAboutUs As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents mnuNaviOutdoor As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents btnIndoor As Button
    Friend WithEvents btnOutdoor As Button
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents btnShows As Button
End Class
