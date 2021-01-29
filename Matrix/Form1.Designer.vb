<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.NavPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.navLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SideMenuPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.NavPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideMenuPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavPanel
        '
        Me.NavPanel.Controls.Add(Me.navLabel)
        Me.NavPanel.Controls.Add(Me.PictureBox1)
        Me.NavPanel.Controls.Add(Me.Guna2Button1)
        Me.NavPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.NavPanel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.NavPanel.Location = New System.Drawing.Point(0, 0)
        Me.NavPanel.Name = "NavPanel"
        Me.NavPanel.ShadowDecoration.Parent = Me.NavPanel
        Me.NavPanel.Size = New System.Drawing.Size(962, 71)
        Me.NavPanel.TabIndex = 0
        '
        'navLabel
        '
        Me.navLabel.AutoSize = True
        Me.navLabel.BackColor = System.Drawing.Color.Transparent
        Me.navLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.navLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.navLabel.Location = New System.Drawing.Point(450, 19)
        Me.navLabel.Name = "navLabel"
        Me.navLabel.Size = New System.Drawing.Size(86, 32)
        Me.navLabel.TabIndex = 1
        Me.navLabel.Text = "Matrix"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(862, 19)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(88, 32)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "About"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(23, 32)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(66, 34)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Menu"
        '
        'SideMenuPanel
        '
        Me.SideMenuPanel.Controls.Add(Me.Button3)
        Me.SideMenuPanel.Controls.Add(Me.Button2)
        Me.SideMenuPanel.Controls.Add(Me.Button1)
        Me.SideMenuPanel.Controls.Add(Me.btnAdd)
        Me.SideMenuPanel.Controls.Add(Me.Panel1)
        Me.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideMenuPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.SideMenuPanel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.SideMenuPanel.Location = New System.Drawing.Point(0, 71)
        Me.SideMenuPanel.Name = "SideMenuPanel"
        Me.SideMenuPanel.ShadowDecoration.Parent = Me.SideMenuPanel
        Me.SideMenuPanel.Size = New System.Drawing.Size(254, 523)
        Me.SideMenuPanel.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(0, 294)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(254, 63)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "E&xit"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(0, 231)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(254, 63)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Multiplication"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(0, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(254, 63)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Subtraction"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(0, 105)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.btnAdd.Size = New System.Drawing.Size(254, 63)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Addition"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 105)
        Me.Panel1.TabIndex = 2
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.BackgroundImage = CType(resources.GetObject("MainPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(254, 71)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(708, 523)
        Me.MainPanel.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 594)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SideMenuPanel)
        Me.Controls.Add(Me.NavPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.NavPanel.ResumeLayout(False)
        Me.NavPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideMenuPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NavPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents SideMenuPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents navLabel As System.Windows.Forms.Label

End Class
