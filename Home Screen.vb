Imports System.Data.SqlClient

Public Class Home_Screen
    Private Sub WorkoutFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkoutFormToolStripMenuItem.Click
        Workouts_Form.Show()
        Me.Hide()

    End Sub

    Private Sub PlansFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlansFormToolStripMenuItem.Click
        Plans_Form.Show()
        Me.Hide()

    End Sub

    Private Sub SocialFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocialFormToolStripMenuItem.Click
        Social_Form.Show()
        Me.Hide()

    End Sub


    Private Sub PersonalInformationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalInformationFormToolStripMenuItem.Click
        Personal_Information_Form.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login_Screen.Show()
        Me.Hide()
    End Sub

    Private Sub Home_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "Enter username here"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim connectionString As String = "Data Source=Z4P5-064;Initial Catalog = FAVB; Trusted_Connection=True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "SELECT * FROM Login WHERE username=@username"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", txtUsername.Text)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read
            txtName.Text = reader("name").ToString
            txtCurrent.Text = reader("weight").ToString
            txtTarget.Text = reader("target").ToString
        End While
    End Sub
End Class