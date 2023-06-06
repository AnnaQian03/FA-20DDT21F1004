<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Screen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WorkoutFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlansFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalInformationFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkoutFormToolStripMenuItem, Me.PlansFormToolStripMenuItem, Me.SocialFormToolStripMenuItem, Me.PersonalInformationFormToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WorkoutFormToolStripMenuItem
        '
        Me.WorkoutFormToolStripMenuItem.Name = "WorkoutFormToolStripMenuItem"
        Me.WorkoutFormToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.WorkoutFormToolStripMenuItem.Text = "&Workout Form"
        '
        'PlansFormToolStripMenuItem
        '
        Me.PlansFormToolStripMenuItem.Name = "PlansFormToolStripMenuItem"
        Me.PlansFormToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.PlansFormToolStripMenuItem.Text = "&Plans Form"
        '
        'SocialFormToolStripMenuItem
        '
        Me.SocialFormToolStripMenuItem.Name = "SocialFormToolStripMenuItem"
        Me.SocialFormToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.SocialFormToolStripMenuItem.Text = "&Social Form"
        '
        'PersonalInformationFormToolStripMenuItem
        '
        Me.PersonalInformationFormToolStripMenuItem.Name = "PersonalInformationFormToolStripMenuItem"
        Me.PersonalInformationFormToolStripMenuItem.Size = New System.Drawing.Size(161, 20)
        Me.PersonalInformationFormToolStripMenuItem.Text = "Personal &Information Form"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "&Log Out"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtName.Location = New System.Drawing.Point(154, 83)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(140, 30)
        Me.txtName.TabIndex = 6
        Me.txtName.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(32, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'txtTarget
        '
        Me.txtTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtTarget.Location = New System.Drawing.Point(530, 119)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.ReadOnly = True
        Me.txtTarget.Size = New System.Drawing.Size(140, 30)
        Me.txtTarget.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(390, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Target"
        '
        'txtCurrent
        '
        Me.txtCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCurrent.Location = New System.Drawing.Point(154, 119)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.ReadOnly = True
        Me.txtCurrent.Size = New System.Drawing.Size(140, 30)
        Me.txtCurrent.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(32, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Current"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(32, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(647, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "‘If you think lifting is dangerous, try being weak. Being weak is dangerous.’"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 169)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 282)
        Me.Panel1.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(32, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(338, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Stock Your Fridge with Healthy Foods"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(32, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Stay Hydrated"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Tips of the day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(32, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(708, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "‘Things may come to those who wait, but only the things left by those who hustle." &
    "’"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quote of the day"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtUsername.Location = New System.Drawing.Point(154, 36)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(179, 30)
        Me.txtUsername.TabIndex = 14
        Me.txtUsername.Text = " "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(32, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 25)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Username"
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnCheck.Location = New System.Drawing.Point(339, 36)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(158, 30)
        Me.btnCheck.TabIndex = 15
        Me.btnCheck.Text = "Check Now"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Home_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Screen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WorkoutFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlansFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocialFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalInformationFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTarget As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCheck As Button
End Class
