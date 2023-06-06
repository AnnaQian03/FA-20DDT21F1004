Imports System.Data.SqlClient

Public Class Personal_Information_Form
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
        Me.Hide()
        Me.Show()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim connectionString As String = "Data Source=Z4P5-064;Initial Catalog = FAVB; Trusted_Connection=True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "SELECT * FROM Health WHERE name=@name"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", txtName.Text)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read
            txtName.Text = reader("name").ToString
            txtAge.Text = reader("age").ToString
            txtGender.Text = reader("gender").ToString
            txtBMI.Text = reader("bmi").ToString
            txtCurrent.Text = reader("weight").ToString
            txtTarget.Text = reader("target").ToString
            txtResult.Text = reader("result").ToString
            txtHeight.Text = reader("height").ToString
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim connectionString As String = "Data Source=Z4P5-064;Initial Catalog = FAVB; Trusted_Connection=True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "INSERT INTO Health (name,gender,age,height,weight,target,bmi,result) VALUES (@name,@gender,@age,@height,@weight,@target,@bmi,@result)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", txtName.Text)
        command.Parameters.AddWithValue("@gender", txtGender.Text)
        command.Parameters.AddWithValue("@age", txtAge.Text)
        command.Parameters.AddWithValue("@height", txtHeight.Text)
        command.Parameters.AddWithValue("@weight", txtCurrent.Text)
        command.Parameters.AddWithValue("@target", txtTarget.Text)
        command.Parameters.AddWithValue("@bmi", txtBMI.Text)
        command.Parameters.AddWithValue("@result", txtResult.Text)
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("Data has been added.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Controls.Clear()
        InitializeComponent()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim value1 As Decimal = Val(txtValue1.Text)
        Dim value2 As Decimal = Val(txtValue2.Text)
        Dim calculatebmi As Decimal = Val(txtTotalBMI.Text)
        calculatebmi = getBMIStatus(value1, value2)
        txtTotalBMI.Text = calculatebmi.ToString

        If calculatebmi < 18.5 Then
            txtFinalResult.Text = "Underweight"
        ElseIf calculatebmi > 18.5 And calculatebmi < 24.9 Then
            txtFinalResult.Text = "Normal Weight"
        ElseIf calculatebmi > 24.9 And calculatebmi < 30 Then
            txtFinalResult.Text = " Overweight"
        Else
            txtFinalResult.Text = "Obese"
        End If
    End Sub

    Function getBMIStatus(x, y)
        Dim value1 As Decimal = x
        Dim value2 As Decimal = y
        Dim total As Decimal = y / ((x / 100) * (x / 100))
        Return total
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim connectionString As String = "Data Source=Z4P5-064;Initial Catalog = FAVB; Trusted_Connection=True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "DELETE FROM Health WHERE name=@name"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", txtName.Text)
        Dim rowsAffected As Integer = command.ExecuteNonQuery()
        If rowsAffected > 0 Then
            MsgBox("Data has been deleted.")
        Else
            MsgBox("Data does not exists")
        End If
        connection.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim connectionString As String = "Data Source=Z4P5-064;Initial Catalog = FAVB; Trusted_Connection=True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "UPDATE Health SET height=@newheight,weight=@newweight,target=@newtarget WHERE name=@name"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", txtName.Text)
        command.Parameters.AddWithValue("@newweight", txtCurrent.Text)
        command.Parameters.AddWithValue("@newtarget", txtTarget.Text)
        command.Parameters.AddWithValue("@newheight", txtHeight.Text)
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("Data has been Updated")

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub Personal_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class