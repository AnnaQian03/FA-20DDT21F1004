Public Class Workouts_Form
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub WorkoutFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkoutFormToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
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

    Private Sub Workouts_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDuration.Text = "in minutes"
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home_Screen.Show()
        Me.Hide()

    End Sub
End Class