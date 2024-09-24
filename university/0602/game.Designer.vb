<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.zombie1 = New System.Windows.Forms.PictureBox()
        Me.zombie2 = New System.Windows.Forms.PictureBox()
        Me.zombie3 = New System.Windows.Forms.PictureBox()
        Me.zombie4 = New System.Windows.Forms.PictureBox()
        Me.time = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.score_text = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zombie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zombie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zombie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zombie4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 515)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(208, 515)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 126)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(392, 515)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 126)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Timer1
        '
        '
        'zombie1
        '
        Me.zombie1.Image = CType(resources.GetObject("zombie1.Image"), System.Drawing.Image)
        Me.zombie1.Location = New System.Drawing.Point(46, 396)
        Me.zombie1.Name = "zombie1"
        Me.zombie1.Size = New System.Drawing.Size(92, 84)
        Me.zombie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zombie1.TabIndex = 4
        Me.zombie1.TabStop = False
        '
        'zombie2
        '
        Me.zombie2.Image = CType(resources.GetObject("zombie2.Image"), System.Drawing.Image)
        Me.zombie2.Location = New System.Drawing.Point(46, 278)
        Me.zombie2.Name = "zombie2"
        Me.zombie2.Size = New System.Drawing.Size(92, 84)
        Me.zombie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zombie2.TabIndex = 5
        Me.zombie2.TabStop = False
        '
        'zombie3
        '
        Me.zombie3.Image = CType(resources.GetObject("zombie3.Image"), System.Drawing.Image)
        Me.zombie3.Location = New System.Drawing.Point(46, 153)
        Me.zombie3.Name = "zombie3"
        Me.zombie3.Size = New System.Drawing.Size(92, 84)
        Me.zombie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zombie3.TabIndex = 6
        Me.zombie3.TabStop = False
        '
        'zombie4
        '
        Me.zombie4.Image = CType(resources.GetObject("zombie4.Image"), System.Drawing.Image)
        Me.zombie4.Location = New System.Drawing.Point(46, 28)
        Me.zombie4.Name = "zombie4"
        Me.zombie4.Size = New System.Drawing.Size(92, 84)
        Me.zombie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zombie4.TabIndex = 7
        Me.zombie4.TabStop = False
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.time.Font = New System.Drawing.Font("DFKai-SB", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.time.ForeColor = System.Drawing.Color.Red
        Me.time.Location = New System.Drawing.Point(448, 9)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(51, 33)
        Me.time.TabIndex = 8
        Me.time.Text = "30"
        '
        'Timer2
        '
        '
        'score_text
        '
        Me.score_text.AutoSize = True
        Me.score_text.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.score_text.Font = New System.Drawing.Font("DFKai-SB", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.score_text.ForeColor = System.Drawing.Color.Teal
        Me.score_text.Location = New System.Drawing.Point(16, 240)
        Me.score_text.Name = "score_text"
        Me.score_text.Size = New System.Drawing.Size(320, 80)
        Me.score_text.TabIndex = 9
        Me.score_text.Text = "Score："
        Me.score_text.Visible = False
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 653)
        Me.Controls.Add(Me.score_text)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.zombie4)
        Me.Controls.Add(Me.zombie3)
        Me.Controls.Add(Me.zombie2)
        Me.Controls.Add(Me.zombie1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "game"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zombie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zombie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zombie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zombie4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents zombie1 As System.Windows.Forms.PictureBox
    Friend WithEvents zombie2 As System.Windows.Forms.PictureBox
    Friend WithEvents zombie3 As System.Windows.Forms.PictureBox
    Friend WithEvents zombie4 As System.Windows.Forms.PictureBox
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents score_text As System.Windows.Forms.Label
End Class
