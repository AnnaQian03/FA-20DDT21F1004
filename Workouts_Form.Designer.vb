<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workouts_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Workouts_Form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WorkoutFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlansFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalInformationFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIntensity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkoutFormToolStripMenuItem, Me.PlansFormToolStripMenuItem, Me.SocialFormToolStripMenuItem, Me.PersonalInformationFormToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sport Type"
        '
        'txtDuration
        '
        Me.txtDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtDuration.Location = New System.Drawing.Point(191, 114)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(140, 30)
        Me.txtDuration.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Duration"
        '
        'txtIntensity
        '
        Me.txtIntensity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtIntensity.Location = New System.Drawing.Point(191, 168)
        Me.txtIntensity.Name = "txtIntensity"
        Me.txtIntensity.Size = New System.Drawing.Size(140, 30)
        Me.txtIntensity.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Intensity"
        '
        'cmbType
        '
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Running", "Weigh tLifting", "Yoga", "Jogging", "Badminton", "Tennis"})
        Me.cmbType.Location = New System.Drawing.Point(191, 56)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(140, 33)
        Me.cmbType.TabIndex = 7
        Me.cmbType.Text = "Select"
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtNotes.Location = New System.Drawing.Point(191, 221)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(329, 217)
        Me.txtNotes.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Notes"
        '
        'Workouts_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.txtIntensity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Workouts_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "git "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WorkoutFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlansFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocialFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalInformationFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIntensity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
End Class
