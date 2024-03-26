<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.txtSignUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSignPassword = New System.Windows.Forms.TextBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.grpSignin = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpSignin.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSignUsername
        '
        Me.txtSignUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSignUsername.Location = New System.Drawing.Point(168, 37)
        Me.txtSignUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSignUsername.Name = "txtSignUsername"
        Me.txtSignUsername.Size = New System.Drawing.Size(321, 22)
        Me.txtSignUsername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PASSWORD :"
        '
        'txtSignPassword
        '
        Me.txtSignPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSignPassword.Location = New System.Drawing.Point(168, 79)
        Me.txtSignPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSignPassword.Name = "txtSignPassword"
        Me.txtSignPassword.Size = New System.Drawing.Size(321, 22)
        Me.txtSignPassword.TabIndex = 5
        '
        'btnSignUp
        '
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(316, 137)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(117, 34)
        Me.btnSignUp.TabIndex = 6
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(495, 80)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 7
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'grpSignin
        '
        Me.grpSignin.BackColor = System.Drawing.Color.Transparent
        Me.grpSignin.Controls.Add(Me.btnCancel)
        Me.grpSignin.Controls.Add(Me.btnSignUp)
        Me.grpSignin.Controls.Add(Me.btnShow)
        Me.grpSignin.Controls.Add(Me.Label2)
        Me.grpSignin.Controls.Add(Me.txtSignPassword)
        Me.grpSignin.Controls.Add(Me.txtSignUsername)
        Me.grpSignin.Controls.Add(Me.Label3)
        Me.grpSignin.Location = New System.Drawing.Point(113, 215)
        Me.grpSignin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpSignin.Name = "grpSignin"
        Me.grpSignin.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpSignin.Size = New System.Drawing.Size(612, 194)
        Me.grpSignin.TabIndex = 8
        Me.grpSignin.TabStop = False
        Me.grpSignin.Text = "Sign in Information"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(168, 137)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 34)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.grpSignin)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form4"
        Me.Text = "Sign in"
        Me.grpSignin.ResumeLayout(False)
        Me.grpSignin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSignUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSignPassword As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents grpSignin As GroupBox
    Friend WithEvents btnCancel As Button
End Class
