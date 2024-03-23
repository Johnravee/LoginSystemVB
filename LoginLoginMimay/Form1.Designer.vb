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
        LoginForm = New GroupBox()
        LG_recoveraccountLink = New LinkLabel()
        LG_register = New LinkLabel()
        Clear = New Button()
        LoginBtn = New Button()
        passwordLoginBox = New TextBox()
        usernameLoginBox = New TextBox()
        passwordLabel = New Label()
        usernameLabel = New Label()
        RegisterForm = New GroupBox()
        cpassIndicator = New Label()
        regCancelBtn = New Button()
        regCpassBox = New TextBox()
        regPassBox = New TextBox()
        regUsernameBox = New TextBox()
        regLnameBox = New TextBox()
        regCpass = New Label()
        regPassword = New Label()
        regUsername = New Label()
        Lastname = New Label()
        R_LoginLink = New LinkLabel()
        registerBtn = New Button()
        regFnameBox = New TextBox()
        Fname = New Label()
        RecoverForm = New GroupBox()
        RA_loginLink = New LinkLabel()
        RA_CancelBtn = New Button()
        RecoverBtn = New Button()
        RA_lnameBox = New TextBox()
        RA_fnameBox = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        ChangeAccountForm = New GroupBox()
        CA_NewPassBox = New TextBox()
        CA_newUnameBox = New TextBox()
        CA_Cpass = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        CA_CancelBtn = New Button()
        CA_passBox = New TextBox()
        CA_unameBox = New TextBox()
        CA_LnameBox = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CA_LoginLink = New LinkLabel()
        UpdateBtn = New Button()
        CA_FnameBox = New TextBox()
        Label7 = New Label()
        LoginForm.SuspendLayout()
        RegisterForm.SuspendLayout()
        RecoverForm.SuspendLayout()
        ChangeAccountForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' LoginForm
        ' 
        LoginForm.BackColor = Color.YellowGreen
        LoginForm.Controls.Add(LG_recoveraccountLink)
        LoginForm.Controls.Add(LG_register)
        LoginForm.Controls.Add(Clear)
        LoginForm.Controls.Add(LoginBtn)
        LoginForm.Controls.Add(passwordLoginBox)
        LoginForm.Controls.Add(usernameLoginBox)
        LoginForm.Controls.Add(passwordLabel)
        LoginForm.Controls.Add(usernameLabel)
        LoginForm.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginForm.Location = New Point(455, 25)
        LoginForm.Name = "LoginForm"
        LoginForm.Size = New Size(436, 338)
        LoginForm.TabIndex = 0
        LoginForm.TabStop = False
        LoginForm.Text = "Login"
        ' 
        ' LG_recoveraccountLink
        ' 
        LG_recoveraccountLink.AutoSize = True
        LG_recoveraccountLink.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LG_recoveraccountLink.Location = New Point(271, 302)
        LG_recoveraccountLink.Name = "LG_recoveraccountLink"
        LG_recoveraccountLink.Size = New Size(110, 17)
        LG_recoveraccountLink.TabIndex = 7
        LG_recoveraccountLink.TabStop = True
        LG_recoveraccountLink.Text = "Recover Account"
        ' 
        ' LG_register
        ' 
        LG_register.AutoSize = True
        LG_register.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LG_register.Location = New Point(58, 302)
        LG_register.Name = "LG_register"
        LG_register.Size = New Size(64, 17)
        LG_register.TabIndex = 6
        LG_register.TabStop = True
        LG_register.Text = "Register?"
        ' 
        ' Clear
        ' 
        Clear.Location = New Point(271, 240)
        Clear.Name = "Clear"
        Clear.Size = New Size(101, 36)
        Clear.TabIndex = 5
        Clear.Text = "Clear"
        Clear.UseVisualStyleBackColor = True
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Location = New Point(58, 240)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(101, 36)
        LoginBtn.TabIndex = 4
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' passwordLoginBox
        ' 
        passwordLoginBox.Location = New Point(159, 145)
        passwordLoginBox.Name = "passwordLoginBox"
        passwordLoginBox.Size = New Size(213, 31)
        passwordLoginBox.TabIndex = 3
        ' 
        ' usernameLoginBox
        ' 
        usernameLoginBox.Location = New Point(159, 76)
        usernameLoginBox.Name = "usernameLoginBox"
        usernameLoginBox.Size = New Size(213, 31)
        usernameLoginBox.TabIndex = 2
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        passwordLabel.Location = New Point(42, 151)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(86, 21)
        passwordLabel.TabIndex = 1
        passwordLabel.Text = "Password:"
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        usernameLabel.Location = New Point(42, 82)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(91, 21)
        usernameLabel.TabIndex = 0
        usernameLabel.Text = "Username:"
        ' 
        ' RegisterForm
        ' 
        RegisterForm.BackColor = Color.YellowGreen
        RegisterForm.Controls.Add(cpassIndicator)
        RegisterForm.Controls.Add(regCancelBtn)
        RegisterForm.Controls.Add(regCpassBox)
        RegisterForm.Controls.Add(regPassBox)
        RegisterForm.Controls.Add(regUsernameBox)
        RegisterForm.Controls.Add(regLnameBox)
        RegisterForm.Controls.Add(regCpass)
        RegisterForm.Controls.Add(regPassword)
        RegisterForm.Controls.Add(regUsername)
        RegisterForm.Controls.Add(Lastname)
        RegisterForm.Controls.Add(R_LoginLink)
        RegisterForm.Controls.Add(registerBtn)
        RegisterForm.Controls.Add(regFnameBox)
        RegisterForm.Controls.Add(Fname)
        RegisterForm.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RegisterForm.Location = New Point(485, 385)
        RegisterForm.Name = "RegisterForm"
        RegisterForm.Size = New Size(443, 384)
        RegisterForm.TabIndex = 1
        RegisterForm.TabStop = False
        RegisterForm.Text = "Register"
        RegisterForm.Visible = False
        ' 
        ' cpassIndicator
        ' 
        cpassIndicator.AutoSize = True
        cpassIndicator.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cpassIndicator.ForeColor = Color.Red
        cpassIndicator.Location = New Point(253, 271)
        cpassIndicator.Name = "cpassIndicator"
        cpassIndicator.Size = New Size(0, 15)
        cpassIndicator.TabIndex = 13
        cpassIndicator.Visible = False
        ' 
        ' regCancelBtn
        ' 
        regCancelBtn.Location = New Point(286, 289)
        regCancelBtn.Name = "regCancelBtn"
        regCancelBtn.Size = New Size(96, 40)
        regCancelBtn.TabIndex = 12
        regCancelBtn.Text = "Cancel"
        regCancelBtn.UseVisualStyleBackColor = True
        ' 
        ' regCpassBox
        ' 
        regCpassBox.Location = New Point(181, 235)
        regCpassBox.Name = "regCpassBox"
        regCpassBox.PasswordChar = "*"c
        regCpassBox.Size = New Size(217, 31)
        regCpassBox.TabIndex = 11
        ' 
        ' regPassBox
        ' 
        regPassBox.Location = New Point(181, 185)
        regPassBox.Name = "regPassBox"
        regPassBox.PasswordChar = "*"c
        regPassBox.Size = New Size(217, 31)
        regPassBox.TabIndex = 10
        ' 
        ' regUsernameBox
        ' 
        regUsernameBox.Location = New Point(181, 136)
        regUsernameBox.Name = "regUsernameBox"
        regUsernameBox.Size = New Size(217, 31)
        regUsernameBox.TabIndex = 9
        ' 
        ' regLnameBox
        ' 
        regLnameBox.Location = New Point(181, 86)
        regLnameBox.Name = "regLnameBox"
        regLnameBox.Size = New Size(217, 31)
        regLnameBox.TabIndex = 8
        ' 
        ' regCpass
        ' 
        regCpass.AutoSize = True
        regCpass.Location = New Point(22, 238)
        regCpass.Name = "regCpass"
        regCpass.Size = New Size(153, 23)
        regCpass.TabIndex = 7
        regCpass.Text = "Confirm Password"
        ' 
        ' regPassword
        ' 
        regPassword.AutoSize = True
        regPassword.Location = New Point(22, 193)
        regPassword.Name = "regPassword"
        regPassword.Size = New Size(86, 23)
        regPassword.TabIndex = 6
        regPassword.Text = "Password"
        ' 
        ' regUsername
        ' 
        regUsername.AutoSize = True
        regUsername.Location = New Point(22, 144)
        regUsername.Name = "regUsername"
        regUsername.Size = New Size(91, 23)
        regUsername.TabIndex = 5
        regUsername.Text = "Username"
        ' 
        ' Lastname
        ' 
        Lastname.AutoSize = True
        Lastname.Location = New Point(22, 94)
        Lastname.Name = "Lastname"
        Lastname.Size = New Size(86, 23)
        Lastname.TabIndex = 4
        Lastname.Text = "Lastname"
        ' 
        ' R_LoginLink
        ' 
        R_LoginLink.AutoSize = True
        R_LoginLink.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        R_LoginLink.Location = New Point(181, 351)
        R_LoginLink.Name = "R_LoginLink"
        R_LoginLink.Size = New Size(53, 19)
        R_LoginLink.TabIndex = 3
        R_LoginLink.TabStop = True
        R_LoginLink.Text = "Login?"
        ' 
        ' registerBtn
        ' 
        registerBtn.Location = New Point(44, 289)
        registerBtn.Name = "registerBtn"
        registerBtn.Size = New Size(96, 40)
        registerBtn.TabIndex = 2
        registerBtn.Text = "Register"
        registerBtn.UseVisualStyleBackColor = True
        ' 
        ' regFnameBox
        ' 
        regFnameBox.Location = New Point(181, 36)
        regFnameBox.Name = "regFnameBox"
        regFnameBox.Size = New Size(217, 31)
        regFnameBox.TabIndex = 1
        ' 
        ' Fname
        ' 
        Fname.AutoSize = True
        Fname.Location = New Point(22, 44)
        Fname.Name = "Fname"
        Fname.Size = New Size(90, 23)
        Fname.TabIndex = 0
        Fname.Text = "Firstname"
        ' 
        ' RecoverForm
        ' 
        RecoverForm.BackColor = Color.YellowGreen
        RecoverForm.Controls.Add(RA_loginLink)
        RecoverForm.Controls.Add(RA_CancelBtn)
        RecoverForm.Controls.Add(RecoverBtn)
        RecoverForm.Controls.Add(RA_lnameBox)
        RecoverForm.Controls.Add(RA_fnameBox)
        RecoverForm.Controls.Add(Label2)
        RecoverForm.Controls.Add(Label1)
        RecoverForm.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RecoverForm.Location = New Point(456, 369)
        RecoverForm.Name = "RecoverForm"
        RecoverForm.Size = New Size(347, 317)
        RecoverForm.TabIndex = 1
        RecoverForm.TabStop = False
        RecoverForm.Text = "RECOVER ACCOUNT"
        RecoverForm.Visible = False
        ' 
        ' RA_loginLink
        ' 
        RA_loginLink.AutoSize = True
        RA_loginLink.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RA_loginLink.Location = New Point(146, 295)
        RA_loginLink.Name = "RA_loginLink"
        RA_loginLink.Size = New Size(53, 19)
        RA_loginLink.TabIndex = 13
        RA_loginLink.TabStop = True
        RA_loginLink.Text = "Login?"
        ' 
        ' RA_CancelBtn
        ' 
        RA_CancelBtn.Location = New Point(215, 221)
        RA_CancelBtn.Name = "RA_CancelBtn"
        RA_CancelBtn.Size = New Size(96, 40)
        RA_CancelBtn.TabIndex = 14
        RA_CancelBtn.Text = "Cancel"
        RA_CancelBtn.UseVisualStyleBackColor = True
        ' 
        ' RecoverBtn
        ' 
        RecoverBtn.Location = New Point(40, 221)
        RecoverBtn.Name = "RecoverBtn"
        RecoverBtn.Size = New Size(96, 40)
        RecoverBtn.TabIndex = 13
        RecoverBtn.Text = "Recover"
        RecoverBtn.UseVisualStyleBackColor = True
        ' 
        ' RA_lnameBox
        ' 
        RA_lnameBox.Location = New Point(146, 133)
        RA_lnameBox.Name = "RA_lnameBox"
        RA_lnameBox.Size = New Size(178, 31)
        RA_lnameBox.TabIndex = 3
        ' 
        ' RA_fnameBox
        ' 
        RA_fnameBox.Location = New Point(146, 72)
        RA_fnameBox.Name = "RA_fnameBox"
        RA_fnameBox.Size = New Size(178, 31)
        RA_fnameBox.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 23)
        Label2.TabIndex = 1
        Label2.Text = "Lastname"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 23)
        Label1.TabIndex = 0
        Label1.Text = "Firstname"
        ' 
        ' ChangeAccountForm
        ' 
        ChangeAccountForm.BackColor = Color.YellowGreen
        ChangeAccountForm.Controls.Add(CA_NewPassBox)
        ChangeAccountForm.Controls.Add(CA_newUnameBox)
        ChangeAccountForm.Controls.Add(CA_Cpass)
        ChangeAccountForm.Controls.Add(Label10)
        ChangeAccountForm.Controls.Add(Label9)
        ChangeAccountForm.Controls.Add(Label8)
        ChangeAccountForm.Controls.Add(CA_CancelBtn)
        ChangeAccountForm.Controls.Add(CA_passBox)
        ChangeAccountForm.Controls.Add(CA_unameBox)
        ChangeAccountForm.Controls.Add(CA_LnameBox)
        ChangeAccountForm.Controls.Add(Label4)
        ChangeAccountForm.Controls.Add(Label5)
        ChangeAccountForm.Controls.Add(Label6)
        ChangeAccountForm.Controls.Add(CA_LoginLink)
        ChangeAccountForm.Controls.Add(UpdateBtn)
        ChangeAccountForm.Controls.Add(CA_FnameBox)
        ChangeAccountForm.Controls.Add(Label7)
        ChangeAccountForm.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ChangeAccountForm.ForeColor = SystemColors.ControlText
        ChangeAccountForm.Location = New Point(0, 12)
        ChangeAccountForm.Name = "ChangeAccountForm"
        ChangeAccountForm.Size = New Size(437, 515)
        ChangeAccountForm.TabIndex = 2
        ChangeAccountForm.TabStop = False
        ChangeAccountForm.Text = "CHANGE ACCOUNT"
        ChangeAccountForm.Visible = False
        ' 
        ' CA_NewPassBox
        ' 
        CA_NewPassBox.Location = New Point(189, 339)
        CA_NewPassBox.Name = "CA_NewPassBox"
        CA_NewPassBox.PasswordChar = "*"c
        CA_NewPassBox.Size = New Size(217, 31)
        CA_NewPassBox.TabIndex = 31
        ' 
        ' CA_newUnameBox
        ' 
        CA_newUnameBox.Location = New Point(189, 288)
        CA_newUnameBox.Name = "CA_newUnameBox"
        CA_newUnameBox.Size = New Size(217, 31)
        CA_newUnameBox.TabIndex = 30
        ' 
        ' CA_Cpass
        ' 
        CA_Cpass.Location = New Point(189, 386)
        CA_Cpass.Name = "CA_Cpass"
        CA_Cpass.PasswordChar = "*"c
        CA_Cpass.Size = New Size(217, 31)
        CA_Cpass.TabIndex = 29
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(30, 389)
        Label10.Name = "Label10"
        Label10.Size = New Size(153, 23)
        Label10.TabIndex = 28
        Label10.Text = "Confirm Password"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(30, 339)
        Label9.Name = "Label9"
        Label9.Size = New Size(127, 23)
        Label9.TabIndex = 27
        Label9.Text = "New Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(30, 291)
        Label8.Name = "Label8"
        Label8.Size = New Size(132, 23)
        Label8.TabIndex = 26
        Label8.Text = "New Username"
        ' 
        ' CA_CancelBtn
        ' 
        CA_CancelBtn.Location = New Point(291, 432)
        CA_CancelBtn.Name = "CA_CancelBtn"
        CA_CancelBtn.Size = New Size(96, 40)
        CA_CancelBtn.TabIndex = 25
        CA_CancelBtn.Text = "Cancel"
        CA_CancelBtn.UseVisualStyleBackColor = True
        ' 
        ' CA_passBox
        ' 
        CA_passBox.Location = New Point(189, 223)
        CA_passBox.Name = "CA_passBox"
        CA_passBox.PasswordChar = "*"c
        CA_passBox.Size = New Size(217, 31)
        CA_passBox.TabIndex = 23
        ' 
        ' CA_unameBox
        ' 
        CA_unameBox.Location = New Point(189, 174)
        CA_unameBox.Name = "CA_unameBox"
        CA_unameBox.Size = New Size(217, 31)
        CA_unameBox.TabIndex = 22
        ' 
        ' CA_LnameBox
        ' 
        CA_LnameBox.Location = New Point(189, 124)
        CA_LnameBox.Name = "CA_LnameBox"
        CA_LnameBox.Size = New Size(217, 31)
        CA_LnameBox.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 23)
        Label4.TabIndex = 19
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 23)
        Label5.TabIndex = 18
        Label5.Text = "Username"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 132)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 23)
        Label6.TabIndex = 17
        Label6.Text = "Lastname"
        ' 
        ' CA_LoginLink
        ' 
        CA_LoginLink.AutoSize = True
        CA_LoginLink.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CA_LoginLink.Location = New Point(189, 491)
        CA_LoginLink.Name = "CA_LoginLink"
        CA_LoginLink.Size = New Size(53, 19)
        CA_LoginLink.TabIndex = 16
        CA_LoginLink.TabStop = True
        CA_LoginLink.Text = "Login?"
        ' 
        ' UpdateBtn
        ' 
        UpdateBtn.Location = New Point(49, 432)
        UpdateBtn.Name = "UpdateBtn"
        UpdateBtn.Size = New Size(96, 40)
        UpdateBtn.TabIndex = 15
        UpdateBtn.Text = "Update"
        UpdateBtn.UseVisualStyleBackColor = True
        ' 
        ' CA_FnameBox
        ' 
        CA_FnameBox.Location = New Point(189, 74)
        CA_FnameBox.Name = "CA_FnameBox"
        CA_FnameBox.Size = New Size(217, 31)
        CA_FnameBox.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 82)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 23)
        Label7.TabIndex = 13
        Label7.Text = "Firstname"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(449, 529)
        Controls.Add(ChangeAccountForm)
        Controls.Add(RegisterForm)
        Controls.Add(RecoverForm)
        Controls.Add(LoginForm)
        Name = "Form1"
        Text = "Form1"
        LoginForm.ResumeLayout(False)
        LoginForm.PerformLayout()
        RegisterForm.ResumeLayout(False)
        RegisterForm.PerformLayout()
        RecoverForm.ResumeLayout(False)
        RecoverForm.PerformLayout()
        ChangeAccountForm.ResumeLayout(False)
        ChangeAccountForm.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoginForm As GroupBox
    Friend WithEvents passwordLoginBox As TextBox
    Friend WithEvents usernameLoginBox As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents LG_recoveraccountLink As LinkLabel
    Friend WithEvents LG_register As LinkLabel
    Friend WithEvents Clear As Button
    Friend WithEvents LoginBtn As Button
    Friend WithEvents RegisterForm As GroupBox
    Friend WithEvents Lastname As Label
    Friend WithEvents R_LoginLink As LinkLabel
    Friend WithEvents registerBtn As Button
    Friend WithEvents regFnameBox As TextBox
    Friend WithEvents Fname As Label
    Friend WithEvents regUsername As Label
    Friend WithEvents regCpass As Label
    Friend WithEvents regPassword As Label
    Friend WithEvents regLnameBox As TextBox
    Friend WithEvents regCpassBox As TextBox
    Friend WithEvents regPassBox As TextBox
    Friend WithEvents regUsernameBox As TextBox
    Friend WithEvents regCancelBtn As Button
    Friend WithEvents RecoverForm As GroupBox
    Friend WithEvents RA_loginLink As LinkLabel
    Friend WithEvents RA_CancelBtn As Button
    Friend WithEvents RecoverBtn As Button
    Friend WithEvents RA_lnameBox As TextBox
    Friend WithEvents RA_fnameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ChangeAccountForm As GroupBox
    Friend WithEvents CA_NewPassBox As TextBox
    Friend WithEvents CA_newUnameBox As TextBox
    Friend WithEvents CA_Cpass As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CA_CancelBtn As Button
    Friend WithEvents CA_passBox As TextBox
    Friend WithEvents CA_unameBox As TextBox
    Friend WithEvents CA_LnameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CA_LoginLink As LinkLabel
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents CA_FnameBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cpassIndicator As Label

End Class
