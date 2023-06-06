<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Social_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Social_Form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WorkoutFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlansFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalInformationFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFacebok = New System.Windows.Forms.Button()
        Me.btnInstagram = New System.Windows.Forms.Button()
        Me.btnTwitter = New System.Windows.Forms.Button()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkoutFormToolStripMenuItem, Me.PlansFormToolStripMenuItem, Me.SocialFormToolStripMenuItem, Me.PersonalInformationFormToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(285, 78)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(537, 78)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(291, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Share Your Progress"
        '
        'btnFacebok
        '
        Me.btnFacebok.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnFacebok.Location = New System.Drawing.Point(24, 299)
        Me.btnFacebok.Name = "btnFacebok"
        Me.btnFacebok.Size = New System.Drawing.Size(200, 46)
        Me.btnFacebok.TabIndex = 6
        Me.btnFacebok.Text = "Share Now"
        Me.btnFacebok.UseVisualStyleBackColor = True
        '
        'btnInstagram
        '
        Me.btnInstagram.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnInstagram.Location = New System.Drawing.Point(285, 299)
        Me.btnInstagram.Name = "btnInstagram"
        Me.btnInstagram.Size = New System.Drawing.Size(200, 46)
        Me.btnInstagram.TabIndex = 7
        Me.btnInstagram.Text = "Share Now"
        Me.btnInstagram.UseVisualStyleBackColor = True
        '
        'btnTwitter
        '
        Me.btnTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnTwitter.Location = New System.Drawing.Point(537, 299)
        Me.btnTwitter.Name = "btnTwitter"
        Me.btnTwitter.Size = New System.Drawing.Size(200, 46)
        Me.btnTwitter.TabIndex = 8
        Me.btnTwitter.Text = "Share Now"
        Me.btnTwitter.UseVisualStyleBackColor = True
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'Social_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTwitter)
        Me.Controls.Add(Me.btnInstagram)
        Me.Controls.Add(Me.btnFacebok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Social_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Social Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WorkoutFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlansFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocialFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalInformationFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFacebok As Button
    Friend WithEvents btnInstagram As Button
    Friend WithEvents btnTwitter As Button
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
End Class
