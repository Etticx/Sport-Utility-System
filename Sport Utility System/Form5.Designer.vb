<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.grpInput.SuspendLayout()
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.BackColor = System.Drawing.Color.Transparent
        Me.grpInput.Controls.Add(Me.btnCancel)
        Me.grpInput.Controls.Add(Me.grpLogin)
        Me.grpInput.Controls.Add(Me.btnLogin)
        Me.grpInput.Location = New System.Drawing.Point(157, 213)
        Me.grpInput.Margin = New System.Windows.Forms.Padding(4)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Padding = New System.Windows.Forms.Padding(4)
        Me.grpInput.Size = New System.Drawing.Size(665, 226)
        Me.grpInput.TabIndex = 7
        Me.grpInput.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(235, 166)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 39)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpLogin
        '
        Me.grpLogin.BackColor = System.Drawing.Color.Transparent
        Me.grpLogin.Controls.Add(Me.btnshow)
        Me.grpLogin.Controls.Add(Me.txtPassword)
        Me.grpLogin.Controls.Add(Me.txtUsername)
        Me.grpLogin.Controls.Add(Me.lblPassword)
        Me.grpLogin.Controls.Add(Me.lblUsername)
        Me.grpLogin.Location = New System.Drawing.Point(29, 11)
        Me.grpLogin.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.grpLogin.Size = New System.Drawing.Size(604, 148)
        Me.grpLogin.TabIndex = 2
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(522, 81)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(75, 23)
        Me.btnshow.TabIndex = 8
        Me.btnshow.Text = "Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(163, 82)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(351, 22)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(163, 32)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(351, 22)
        Me.txtUsername.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(64, 86)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 16)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(64, 36)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 16)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(357, 166)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(85, 39)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(965, 454)
        Me.Controls.Add(Me.grpInput)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form5"
        Me.Text = "Admin"
        Me.grpInput.ResumeLayout(False)
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnshow As Button
End Class
