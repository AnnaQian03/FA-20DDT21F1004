Imports System.Data.SqlClient

Public Class Login_Screen
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connectionString As String = "Data Source=Z4P5-064;Initial Catalog = FAVB; Trusted_Connection=True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "SELECT * FROM Login WHERE username=@username AND password=@password"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", txtUsername.Text)
        command.Parameters.AddWithValue("@password", txtPassword.Text)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                Dim username As String = reader("username").ToString
                Dim password As String = reader("password").ToString
            End While
            MsgBox("Welcome to the Fitness Tracker ")
            Home_Screen.Show()
            Controls.Clear()
            InitializeComponent()
            Me.Hide()


        Else
            MsgBox("Invalid Username or Password. Please try again.")
            Controls.Clear()
            InitializeComponent()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignUp.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
