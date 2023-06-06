Public Class Social_Form
    Private Sub WorkoutFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkoutFormToolStripMenuItem.Click
        Workouts_Form.Show()
        Me.Hide()
    End Sub

    Private Sub PlansFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlansFormToolStripMenuItem.Click
        Plans_Form.Show()
        Me.Hide()
    End Sub

    Private Sub SocialFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocialFormToolStripMenuItem.Click
        Me.Hide()
        Me.Show()

    End Sub

    Private Sub PersonalInformationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalInformationFormToolStripMenuItem.Click
        Personal_Information_Form.Show()
        Me.Hide()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login_Screen.Show()
        Me.Hide()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home_Screen.Show()
        Me.Hide()

    End Sub
End Class