Public Class Form1
    'Variables
    Dim FTNAME As String
    Dim LNAME As String
    Dim PASSWORD As String
    Dim USERNAME As String

    'LoginControls
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        usernameLoginBox.Clear()
        passwordLoginBox.Clear()
    End Sub

    Private Sub register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LG_register.LinkClicked
        RegisterForm.Show()
        LoginForm.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LG_recoveraccountLink.LinkClicked
        LoginForm.Hide()
        RecoverForm.Show()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        If usernameLoginBox.Text.Trim() = "" And passwordLoginBox.Text.Trim() = "" Then
            MsgBox("All fields is empty!")

        ElseIf usernameLoginBox.Text.Trim() = "" Then
            MsgBox("Username is empty!")

        ElseIf passwordLoginBox.Text.Trim() = "" Then
            MsgBox("Password is empty!")
        Else
            If usernameLoginBox.Text = USERNAME And passwordLoginBox.Text = PASSWORD Then
                MsgBox("Login successfully!")
            Else
                MsgBox("Wrong username and password!")

            End If
        End If

    End Sub

    'RecoverAccountControls
    Private Sub RA_loginLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RA_loginLink.LinkClicked
        LoginForm.Show()
        RecoverForm.Hide()
    End Sub

    'RegisterFormControls
    Private Sub R_LoginLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles R_LoginLink.LinkClicked
        LoginForm.Show()
        RegisterForm.Hide()
    End Sub


    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click

        If regFnameBox.Text.Trim() = "" And regLnameBox.Text.Trim() = "" And regUsernameBox.Text.Trim() = "" And regPassBox.Text.Trim() = "" And regCpassBox.Text.Trim() = "" Then
            MsgBox("All fields is empty!")
        ElseIf regFnameBox.Text.Trim() = "" Then
            MsgBox("Firstname is empty!")

        ElseIf regLnameBox.Text.Trim() = "" Then
            MsgBox("Lastname is Empty!")

        ElseIf regUsernameBox.Text.Trim() = "" Then
            MsgBox("Username is Empty!")

        ElseIf regPassBox.Text.Trim() = "" Then
            MsgBox("Password is empty")

        ElseIf regCpassBox.Text.Trim() = "" Then
            MsgBox("Confirm password is Empty!")

        Else
            If regPassBox.Text.Trim() <> regCpassBox.Text.Trim Then
                MsgBox("Password is not matched!")
                Return
            End If
            FTNAME = regFnameBox.Text
            LNAME = regLnameBox.Text
            USERNAME = regUsernameBox.Text
            PASSWORD = regPassBox.Text
            MsgBox("Account created successfully!")
            RegisterForm.Hide()
            LoginForm.Show()
        End If
    End Sub
    Private Sub regCpassBox_TextChanged(sender As Object, e As EventArgs) Handles regCpassBox.TextChanged
        If regPassBox.Text.Trim() <> regCpassBox.Text.Trim() Then
            cpassIndicator.Text = "Password is not matched!"
            cpassIndicator.ForeColor = Color.Red
            cpassIndicator.Visible = True
            Return
        End If
        cpassIndicator.Text = "Password is matched!"
        cpassIndicator.ForeColor = Color.Green
        cpassIndicator.Visible = True
    End Sub

    Private Sub regPassBox_TextChanged(sender As Object, e As EventArgs) Handles regPassBox.TextChanged
        If regPassBox.Text.Trim() <> regCpassBox.Text.Trim() Then
            cpassIndicator.Text = "Password is not matched!"
            cpassIndicator.ForeColor = Color.Red
            cpassIndicator.Visible = True
            Return
        End If
        cpassIndicator.Text = "Password is matched!"
        cpassIndicator.ForeColor = Color.Green
        cpassIndicator.Visible = True
    End Sub

    'ChangeAccountFormControls
    Private Sub CA_LoginLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CA_LoginLink.LinkClicked
        LoginForm.Show()
        ChangeAccountForm.Hide()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If CA_FnameBox.Text.Trim() = "" And CA_LnameBox.Text.Trim() = "" And CA_unameBox.Text.Trim() = "" And CA_passBox.Text.Trim() = "" And CA_newUnameBox.Text.Trim() = "" And CA_NewPassBox.Text.Trim() = "" And CA_Cpass.Text.Trim() = "" Then
            MsgBox("All fields is empty!")
        ElseIf CA_FnameBox.Text.Trim() = "" Then
            MsgBox("Firstname is empty!")
        ElseIf CA_LnameBox.Text.Trim() = "" Then
            MsgBox("Lastname is empty!")
        ElseIf CA_unameBox.Text.Trim() = "" Then
            MsgBox("Username is empty!")
        ElseIf CA_passBox.Text.Trim() = "" Then
            MsgBox("Password is empty!")
        ElseIf CA_newUnameBox.Text.Trim() = "" Then
            MsgBox("New username is empty!")
        ElseIf CA_NewPassBox.Text.Trim() = "" Then
            MsgBox("New password is empty!")
        ElseIf CA_Cpass.Text.Trim() = "" Then
            MsgBox("Confirm password is empty!")
        Else

            If CA_NewPassBox.Text.Trim() <> CA_Cpass.Text.Trim() Then
                MsgBox("Password is not matched!")
                Return
            End If

            If CA_FnameBox.Text.Trim() = FTNAME And CA_LnameBox.Text.Trim() = LNAME And CA_unameBox.Text.Trim() = USERNAME And CA_passBox.Text.Trim() = PASSWORD Then
                USERNAME = CA_newUnameBox.Text.Trim()
                PASSWORD = CA_NewPassBox.Text.Trim()
                MsgBox("Updated successfully!")
                ChangeAccountForm.Hide()
                LoginForm.Show()
            Else
                MsgBox("Can't update, account is not found")
            End If
        End If
    End Sub

    'RecoverAccountFOrm
    Private Sub RecoverBtn_Click(sender As Object, e As EventArgs) Handles RecoverBtn.Click
        If RA_fnameBox.Text.Trim() = "" And RA_lnameBox.Text.Trim() = "" Then
            MsgBox("All fields is empty!")
        ElseIf RA_fnameBox.Text.Trim() = "" Then
            MsgBox("Firstname is empty!")
        ElseIf RA_lnameBox.Text.Trim() = "" Then
            MsgBox("Lastname is empty!")
        Else
            If RA_fnameBox.Text.Trim() = FTNAME And RA_lnameBox.Text.Trim() = LNAME Then
                ChangeAccountForm.Show()
                RecoverForm.Hide()
            Else
                MsgBox("Fistname and Lastname is not found!")
            End If
        End If
    End Sub

    Private Sub CA_CancelBtn_Click(sender As Object, e As EventArgs) Handles CA_CancelBtn.Click
        ChangeAccountForm.Hide()
        LoginForm.Show()

    End Sub

    Private Sub regCancelBtn_Click(sender As Object, e As EventArgs) Handles regCancelBtn.Click
        RegisterForm.Hide()
        LoginForm.Show()
    End Sub

    Private Sub RA_CancelBtn_Click(sender As Object, e As EventArgs) Handles RA_CancelBtn.Click
        RecoverForm.Hide()
        LoginForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginForm.Dock = DockStyle.Fill
        RegisterForm.Dock = DockStyle.Fill
        RecoverForm.Dock = DockStyle.Fill
        ChangeAccountForm.Dock = DockStyle.Fill
        LoginForm.Show()
    End Sub


End Class
