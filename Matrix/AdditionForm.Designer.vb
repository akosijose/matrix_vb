<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdditionForm
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
        Me.groupAComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.groupBComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.a_row4_col4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row4_col3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row3_col4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row3_col3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row2_col4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row4_col2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row2_col3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row3_col2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row1_col4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row4_col1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row2_col2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row3_col1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row1_col3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row2_col1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row1_col2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.a_row1_col1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.b_row4_col4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row4_col3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row3_col4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row3_col3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row2_col4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row4_col2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row2_col3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row3_col2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row1_col4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row4_col1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row2_col2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row3_col1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row1_col3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row2_col1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row1_col2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.b_row1_col1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupAComboBox
        '
        Me.groupAComboBox.BackColor = System.Drawing.Color.Transparent
        Me.groupAComboBox.BorderRadius = 10
        Me.groupAComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.groupAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.groupAComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.groupAComboBox.FocusedState.Parent = Me.groupAComboBox
        Me.groupAComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupAComboBox.ForeColor = System.Drawing.Color.Black
        Me.groupAComboBox.FormattingEnabled = True
        Me.groupAComboBox.HoverState.Parent = Me.groupAComboBox
        Me.groupAComboBox.ItemHeight = 30
        Me.groupAComboBox.Items.AddRange(New Object() {"2x2", "2x3", "2x4", "3x2", "3x3", "3x4", "4x2", "4x3", "4x4"})
        Me.groupAComboBox.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.groupAComboBox.ItemsAppearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupAComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.groupAComboBox.ItemsAppearance.Parent = Me.groupAComboBox
        Me.groupAComboBox.Location = New System.Drawing.Point(135, 93)
        Me.groupAComboBox.Name = "groupAComboBox"
        Me.groupAComboBox.ShadowDecoration.Parent = Me.groupAComboBox
        Me.groupAComboBox.Size = New System.Drawing.Size(140, 36)
        Me.groupAComboBox.TabIndex = 7
        Me.groupAComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(162, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Matrix A"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(456, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Matrix B"
        '
        'groupBComboBox
        '
        Me.groupBComboBox.BackColor = System.Drawing.Color.Transparent
        Me.groupBComboBox.BorderRadius = 10
        Me.groupBComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.groupBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.groupBComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.groupBComboBox.FocusedState.Parent = Me.groupBComboBox
        Me.groupBComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBComboBox.ForeColor = System.Drawing.Color.Black
        Me.groupBComboBox.FormattingEnabled = True
        Me.groupBComboBox.HoverState.Parent = Me.groupBComboBox
        Me.groupBComboBox.ItemHeight = 30
        Me.groupBComboBox.Items.AddRange(New Object() {"2x2", "2x3", "2x4", "3x2", "3x3", "3x4", "4x2", "4x3", "4x4"})
        Me.groupBComboBox.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.groupBComboBox.ItemsAppearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.groupBComboBox.ItemsAppearance.Parent = Me.groupBComboBox
        Me.groupBComboBox.Location = New System.Drawing.Point(427, 93)
        Me.groupBComboBox.Name = "groupBComboBox"
        Me.groupBComboBox.ShadowDecoration.Parent = Me.groupBComboBox
        Me.groupBComboBox.Size = New System.Drawing.Size(140, 36)
        Me.groupBComboBox.TabIndex = 7
        Me.groupBComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.a_row4_col4)
        Me.GroupBox1.Controls.Add(Me.a_row4_col3)
        Me.GroupBox1.Controls.Add(Me.a_row3_col4)
        Me.GroupBox1.Controls.Add(Me.a_row3_col3)
        Me.GroupBox1.Controls.Add(Me.a_row2_col4)
        Me.GroupBox1.Controls.Add(Me.a_row4_col2)
        Me.GroupBox1.Controls.Add(Me.a_row2_col3)
        Me.GroupBox1.Controls.Add(Me.a_row3_col2)
        Me.GroupBox1.Controls.Add(Me.a_row1_col4)
        Me.GroupBox1.Controls.Add(Me.a_row4_col1)
        Me.GroupBox1.Controls.Add(Me.a_row2_col2)
        Me.GroupBox1.Controls.Add(Me.a_row3_col1)
        Me.GroupBox1.Controls.Add(Me.a_row1_col3)
        Me.GroupBox1.Controls.Add(Me.a_row2_col1)
        Me.GroupBox1.Controls.Add(Me.a_row1_col2)
        Me.GroupBox1.Controls.Add(Me.a_row1_col1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 190)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'a_row4_col4
        '
        Me.a_row4_col4.BorderRadius = 5
        Me.a_row4_col4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row4_col4.DefaultText = ""
        Me.a_row4_col4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row4_col4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row4_col4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row4_col4.DisabledState.Parent = Me.a_row4_col4
        Me.a_row4_col4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row4_col4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row4_col4.FocusedState.Parent = Me.a_row4_col4
        Me.a_row4_col4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row4_col4.ForeColor = System.Drawing.Color.Black
        Me.a_row4_col4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row4_col4.HoverState.Parent = Me.a_row4_col4
        Me.a_row4_col4.Location = New System.Drawing.Point(223, 139)
        Me.a_row4_col4.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row4_col4.Name = "a_row4_col4"
        Me.a_row4_col4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row4_col4.PlaceholderText = ""
        Me.a_row4_col4.SelectedText = ""
        Me.a_row4_col4.ShadowDecoration.Parent = Me.a_row4_col4
        Me.a_row4_col4.Size = New System.Drawing.Size(58, 29)
        Me.a_row4_col4.TabIndex = 0
        Me.a_row4_col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row4_col4.Visible = False
        '
        'a_row4_col3
        '
        Me.a_row4_col3.BorderRadius = 5
        Me.a_row4_col3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row4_col3.DefaultText = ""
        Me.a_row4_col3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row4_col3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row4_col3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row4_col3.DisabledState.Parent = Me.a_row4_col3
        Me.a_row4_col3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row4_col3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row4_col3.FocusedState.Parent = Me.a_row4_col3
        Me.a_row4_col3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row4_col3.ForeColor = System.Drawing.Color.Black
        Me.a_row4_col3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row4_col3.HoverState.Parent = Me.a_row4_col3
        Me.a_row4_col3.Location = New System.Drawing.Point(157, 139)
        Me.a_row4_col3.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row4_col3.Name = "a_row4_col3"
        Me.a_row4_col3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row4_col3.PlaceholderText = ""
        Me.a_row4_col3.SelectedText = ""
        Me.a_row4_col3.ShadowDecoration.Parent = Me.a_row4_col3
        Me.a_row4_col3.Size = New System.Drawing.Size(58, 29)
        Me.a_row4_col3.TabIndex = 0
        Me.a_row4_col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row4_col3.Visible = False
        '
        'a_row3_col4
        '
        Me.a_row3_col4.BorderRadius = 5
        Me.a_row3_col4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row3_col4.DefaultText = ""
        Me.a_row3_col4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row3_col4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row3_col4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row3_col4.DisabledState.Parent = Me.a_row3_col4
        Me.a_row3_col4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row3_col4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row3_col4.FocusedState.Parent = Me.a_row3_col4
        Me.a_row3_col4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row3_col4.ForeColor = System.Drawing.Color.Black
        Me.a_row3_col4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row3_col4.HoverState.Parent = Me.a_row3_col4
        Me.a_row3_col4.Location = New System.Drawing.Point(223, 102)
        Me.a_row3_col4.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row3_col4.Name = "a_row3_col4"
        Me.a_row3_col4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row3_col4.PlaceholderText = ""
        Me.a_row3_col4.SelectedText = ""
        Me.a_row3_col4.ShadowDecoration.Parent = Me.a_row3_col4
        Me.a_row3_col4.Size = New System.Drawing.Size(58, 29)
        Me.a_row3_col4.TabIndex = 0
        Me.a_row3_col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row3_col4.Visible = False
        '
        'a_row3_col3
        '
        Me.a_row3_col3.BorderRadius = 5
        Me.a_row3_col3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row3_col3.DefaultText = ""
        Me.a_row3_col3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row3_col3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row3_col3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row3_col3.DisabledState.Parent = Me.a_row3_col3
        Me.a_row3_col3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row3_col3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row3_col3.FocusedState.Parent = Me.a_row3_col3
        Me.a_row3_col3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row3_col3.ForeColor = System.Drawing.Color.Black
        Me.a_row3_col3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row3_col3.HoverState.Parent = Me.a_row3_col3
        Me.a_row3_col3.Location = New System.Drawing.Point(157, 102)
        Me.a_row3_col3.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row3_col3.Name = "a_row3_col3"
        Me.a_row3_col3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row3_col3.PlaceholderText = ""
        Me.a_row3_col3.SelectedText = ""
        Me.a_row3_col3.ShadowDecoration.Parent = Me.a_row3_col3
        Me.a_row3_col3.Size = New System.Drawing.Size(58, 29)
        Me.a_row3_col3.TabIndex = 0
        Me.a_row3_col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row3_col3.Visible = False
        '
        'a_row2_col4
        '
        Me.a_row2_col4.BorderRadius = 5
        Me.a_row2_col4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row2_col4.DefaultText = ""
        Me.a_row2_col4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row2_col4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row2_col4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row2_col4.DisabledState.Parent = Me.a_row2_col4
        Me.a_row2_col4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row2_col4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row2_col4.FocusedState.Parent = Me.a_row2_col4
        Me.a_row2_col4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row2_col4.ForeColor = System.Drawing.Color.Black
        Me.a_row2_col4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row2_col4.HoverState.Parent = Me.a_row2_col4
        Me.a_row2_col4.Location = New System.Drawing.Point(223, 63)
        Me.a_row2_col4.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row2_col4.Name = "a_row2_col4"
        Me.a_row2_col4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row2_col4.PlaceholderText = ""
        Me.a_row2_col4.SelectedText = ""
        Me.a_row2_col4.ShadowDecoration.Parent = Me.a_row2_col4
        Me.a_row2_col4.Size = New System.Drawing.Size(58, 29)
        Me.a_row2_col4.TabIndex = 0
        Me.a_row2_col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row2_col4.Visible = False
        '
        'a_row4_col2
        '
        Me.a_row4_col2.BorderRadius = 5
        Me.a_row4_col2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row4_col2.DefaultText = ""
        Me.a_row4_col2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row4_col2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row4_col2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row4_col2.DisabledState.Parent = Me.a_row4_col2
        Me.a_row4_col2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row4_col2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row4_col2.FocusedState.Parent = Me.a_row4_col2
        Me.a_row4_col2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row4_col2.ForeColor = System.Drawing.Color.Black
        Me.a_row4_col2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row4_col2.HoverState.Parent = Me.a_row4_col2
        Me.a_row4_col2.Location = New System.Drawing.Point(91, 139)
        Me.a_row4_col2.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row4_col2.Name = "a_row4_col2"
        Me.a_row4_col2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row4_col2.PlaceholderText = ""
        Me.a_row4_col2.SelectedText = ""
        Me.a_row4_col2.ShadowDecoration.Parent = Me.a_row4_col2
        Me.a_row4_col2.Size = New System.Drawing.Size(58, 29)
        Me.a_row4_col2.TabIndex = 0
        Me.a_row4_col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row4_col2.Visible = False
        '
        'a_row2_col3
        '
        Me.a_row2_col3.BorderRadius = 5
        Me.a_row2_col3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row2_col3.DefaultText = ""
        Me.a_row2_col3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row2_col3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row2_col3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row2_col3.DisabledState.Parent = Me.a_row2_col3
        Me.a_row2_col3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row2_col3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row2_col3.FocusedState.Parent = Me.a_row2_col3
        Me.a_row2_col3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row2_col3.ForeColor = System.Drawing.Color.Black
        Me.a_row2_col3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row2_col3.HoverState.Parent = Me.a_row2_col3
        Me.a_row2_col3.Location = New System.Drawing.Point(157, 63)
        Me.a_row2_col3.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row2_col3.Name = "a_row2_col3"
        Me.a_row2_col3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row2_col3.PlaceholderText = ""
        Me.a_row2_col3.SelectedText = ""
        Me.a_row2_col3.ShadowDecoration.Parent = Me.a_row2_col3
        Me.a_row2_col3.Size = New System.Drawing.Size(58, 29)
        Me.a_row2_col3.TabIndex = 0
        Me.a_row2_col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row2_col3.Visible = False
        '
        'a_row3_col2
        '
        Me.a_row3_col2.BorderRadius = 5
        Me.a_row3_col2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row3_col2.DefaultText = ""
        Me.a_row3_col2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row3_col2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row3_col2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row3_col2.DisabledState.Parent = Me.a_row3_col2
        Me.a_row3_col2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row3_col2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row3_col2.FocusedState.Parent = Me.a_row3_col2
        Me.a_row3_col2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row3_col2.ForeColor = System.Drawing.Color.Black
        Me.a_row3_col2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row3_col2.HoverState.Parent = Me.a_row3_col2
        Me.a_row3_col2.Location = New System.Drawing.Point(91, 102)
        Me.a_row3_col2.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row3_col2.Name = "a_row3_col2"
        Me.a_row3_col2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row3_col2.PlaceholderText = ""
        Me.a_row3_col2.SelectedText = ""
        Me.a_row3_col2.ShadowDecoration.Parent = Me.a_row3_col2
        Me.a_row3_col2.Size = New System.Drawing.Size(58, 29)
        Me.a_row3_col2.TabIndex = 0
        Me.a_row3_col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row3_col2.Visible = False
        '
        'a_row1_col4
        '
        Me.a_row1_col4.BorderRadius = 5
        Me.a_row1_col4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row1_col4.DefaultText = ""
        Me.a_row1_col4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row1_col4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row1_col4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row1_col4.DisabledState.Parent = Me.a_row1_col4
        Me.a_row1_col4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row1_col4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row1_col4.FocusedState.Parent = Me.a_row1_col4
        Me.a_row1_col4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row1_col4.ForeColor = System.Drawing.Color.Black
        Me.a_row1_col4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row1_col4.HoverState.Parent = Me.a_row1_col4
        Me.a_row1_col4.Location = New System.Drawing.Point(223, 26)
        Me.a_row1_col4.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row1_col4.Name = "a_row1_col4"
        Me.a_row1_col4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row1_col4.PlaceholderText = ""
        Me.a_row1_col4.SelectedText = ""
        Me.a_row1_col4.ShadowDecoration.Parent = Me.a_row1_col4
        Me.a_row1_col4.Size = New System.Drawing.Size(58, 29)
        Me.a_row1_col4.TabIndex = 0
        Me.a_row1_col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row1_col4.Visible = False
        '
        'a_row4_col1
        '
        Me.a_row4_col1.BorderRadius = 5
        Me.a_row4_col1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row4_col1.DefaultText = ""
        Me.a_row4_col1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row4_col1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row4_col1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row4_col1.DisabledState.Parent = Me.a_row4_col1
        Me.a_row4_col1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row4_col1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row4_col1.FocusedState.Parent = Me.a_row4_col1
        Me.a_row4_col1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row4_col1.ForeColor = System.Drawing.Color.Black
        Me.a_row4_col1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row4_col1.HoverState.Parent = Me.a_row4_col1
        Me.a_row4_col1.Location = New System.Drawing.Point(25, 139)
        Me.a_row4_col1.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row4_col1.Name = "a_row4_col1"
        Me.a_row4_col1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row4_col1.PlaceholderText = ""
        Me.a_row4_col1.SelectedText = ""
        Me.a_row4_col1.ShadowDecoration.Parent = Me.a_row4_col1
        Me.a_row4_col1.Size = New System.Drawing.Size(58, 29)
        Me.a_row4_col1.TabIndex = 0
        Me.a_row4_col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row4_col1.Visible = False
        '
        'a_row2_col2
        '
        Me.a_row2_col2.BorderRadius = 5
        Me.a_row2_col2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row2_col2.DefaultText = ""
        Me.a_row2_col2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row2_col2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row2_col2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row2_col2.DisabledState.Parent = Me.a_row2_col2
        Me.a_row2_col2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row2_col2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row2_col2.FocusedState.Parent = Me.a_row2_col2
        Me.a_row2_col2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row2_col2.ForeColor = System.Drawing.Color.Black
        Me.a_row2_col2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row2_col2.HoverState.Parent = Me.a_row2_col2
        Me.a_row2_col2.Location = New System.Drawing.Point(91, 63)
        Me.a_row2_col2.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row2_col2.Name = "a_row2_col2"
        Me.a_row2_col2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row2_col2.PlaceholderText = ""
        Me.a_row2_col2.SelectedText = ""
        Me.a_row2_col2.ShadowDecoration.Parent = Me.a_row2_col2
        Me.a_row2_col2.Size = New System.Drawing.Size(58, 29)
        Me.a_row2_col2.TabIndex = 0
        Me.a_row2_col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row2_col2.Visible = False
        '
        'a_row3_col1
        '
        Me.a_row3_col1.BorderRadius = 5
        Me.a_row3_col1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row3_col1.DefaultText = ""
        Me.a_row3_col1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row3_col1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row3_col1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row3_col1.DisabledState.Parent = Me.a_row3_col1
        Me.a_row3_col1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row3_col1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row3_col1.FocusedState.Parent = Me.a_row3_col1
        Me.a_row3_col1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row3_col1.ForeColor = System.Drawing.Color.Black
        Me.a_row3_col1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row3_col1.HoverState.Parent = Me.a_row3_col1
        Me.a_row3_col1.Location = New System.Drawing.Point(25, 102)
        Me.a_row3_col1.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row3_col1.Name = "a_row3_col1"
        Me.a_row3_col1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row3_col1.PlaceholderText = ""
        Me.a_row3_col1.SelectedText = ""
        Me.a_row3_col1.ShadowDecoration.Parent = Me.a_row3_col1
        Me.a_row3_col1.Size = New System.Drawing.Size(58, 29)
        Me.a_row3_col1.TabIndex = 0
        Me.a_row3_col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row3_col1.Visible = False
        '
        'a_row1_col3
        '
        Me.a_row1_col3.BorderRadius = 5
        Me.a_row1_col3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row1_col3.DefaultText = ""
        Me.a_row1_col3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row1_col3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row1_col3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row1_col3.DisabledState.Parent = Me.a_row1_col3
        Me.a_row1_col3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row1_col3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row1_col3.FocusedState.Parent = Me.a_row1_col3
        Me.a_row1_col3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row1_col3.ForeColor = System.Drawing.Color.Black
        Me.a_row1_col3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row1_col3.HoverState.Parent = Me.a_row1_col3
        Me.a_row1_col3.Location = New System.Drawing.Point(157, 26)
        Me.a_row1_col3.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row1_col3.Name = "a_row1_col3"
        Me.a_row1_col3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row1_col3.PlaceholderText = ""
        Me.a_row1_col3.SelectedText = ""
        Me.a_row1_col3.ShadowDecoration.Parent = Me.a_row1_col3
        Me.a_row1_col3.Size = New System.Drawing.Size(58, 29)
        Me.a_row1_col3.TabIndex = 0
        Me.a_row1_col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row1_col3.Visible = False
        '
        'a_row2_col1
        '
        Me.a_row2_col1.BorderRadius = 5
        Me.a_row2_col1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row2_col1.DefaultText = ""
        Me.a_row2_col1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row2_col1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row2_col1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row2_col1.DisabledState.Parent = Me.a_row2_col1
        Me.a_row2_col1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row2_col1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row2_col1.FocusedState.Parent = Me.a_row2_col1
        Me.a_row2_col1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row2_col1.ForeColor = System.Drawing.Color.Black
        Me.a_row2_col1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row2_col1.HoverState.Parent = Me.a_row2_col1
        Me.a_row2_col1.Location = New System.Drawing.Point(25, 63)
        Me.a_row2_col1.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row2_col1.Name = "a_row2_col1"
        Me.a_row2_col1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row2_col1.PlaceholderText = ""
        Me.a_row2_col1.SelectedText = ""
        Me.a_row2_col1.ShadowDecoration.Parent = Me.a_row2_col1
        Me.a_row2_col1.Size = New System.Drawing.Size(58, 29)
        Me.a_row2_col1.TabIndex = 0
        Me.a_row2_col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row2_col1.Visible = False
        '
        'a_row1_col2
        '
        Me.a_row1_col2.BorderRadius = 5
        Me.a_row1_col2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row1_col2.DefaultText = ""
        Me.a_row1_col2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row1_col2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row1_col2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row1_col2.DisabledState.Parent = Me.a_row1_col2
        Me.a_row1_col2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row1_col2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row1_col2.FocusedState.Parent = Me.a_row1_col2
        Me.a_row1_col2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row1_col2.ForeColor = System.Drawing.Color.Black
        Me.a_row1_col2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row1_col2.HoverState.Parent = Me.a_row1_col2
        Me.a_row1_col2.Location = New System.Drawing.Point(91, 26)
        Me.a_row1_col2.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row1_col2.Name = "a_row1_col2"
        Me.a_row1_col2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row1_col2.PlaceholderText = ""
        Me.a_row1_col2.SelectedText = ""
        Me.a_row1_col2.ShadowDecoration.Parent = Me.a_row1_col2
        Me.a_row1_col2.Size = New System.Drawing.Size(58, 29)
        Me.a_row1_col2.TabIndex = 0
        Me.a_row1_col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row1_col2.Visible = False
        '
        'a_row1_col1
        '
        Me.a_row1_col1.BorderRadius = 5
        Me.a_row1_col1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.a_row1_col1.DefaultText = ""
        Me.a_row1_col1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.a_row1_col1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.a_row1_col1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row1_col1.DisabledState.Parent = Me.a_row1_col1
        Me.a_row1_col1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.a_row1_col1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row1_col1.FocusedState.Parent = Me.a_row1_col1
        Me.a_row1_col1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_row1_col1.ForeColor = System.Drawing.Color.Black
        Me.a_row1_col1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a_row1_col1.HoverState.Parent = Me.a_row1_col1
        Me.a_row1_col1.Location = New System.Drawing.Point(25, 26)
        Me.a_row1_col1.Margin = New System.Windows.Forms.Padding(4)
        Me.a_row1_col1.Name = "a_row1_col1"
        Me.a_row1_col1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.a_row1_col1.PlaceholderText = ""
        Me.a_row1_col1.SelectedText = ""
        Me.a_row1_col1.ShadowDecoration.Parent = Me.a_row1_col1
        Me.a_row1_col1.Size = New System.Drawing.Size(58, 29)
        Me.a_row1_col1.TabIndex = 0
        Me.a_row1_col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.a_row1_col1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.b_row4_col4)
        Me.GroupBox2.Controls.Add(Me.b_row4_col3)
        Me.GroupBox2.Controls.Add(Me.b_row3_col4)
        Me.GroupBox2.Controls.Add(Me.b_row3_col3)
        Me.GroupBox2.Controls.Add(Me.b_row2_col4)
        Me.GroupBox2.Controls.Add(Me.b_row4_col2)
        Me.GroupBox2.Controls.Add(Me.b_row2_col3)
        Me.GroupBox2.Controls.Add(Me.b_row3_col2)
        Me.GroupBox2.Controls.Add(Me.b_row1_col4)
        Me.GroupBox2.Controls.Add(Me.b_row4_col1)
        Me.GroupBox2.Controls.Add(Me.b_row2_col2)
        Me.GroupBox2.Controls.Add(Me.b_row3_col1)
        Me.GroupBox2.Controls.Add(Me.b_row1_col3)
        Me.GroupBox2.Controls.Add(Me.b_row2_col1)
        Me.GroupBox2.Controls.Add(Me.b_row1_col2)
        Me.GroupBox2.Controls.Add(Me.b_row1_col1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(369, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 190)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'b_row4_col4
        '
        Me.b_row4_col4.BorderRadius = 5
        Me.b_row4_col4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row4_col4.DefaultText = ""
        Me.b_row4_col4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row4_col4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row4_col4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row4_col4.DisabledState.Parent = Me.b_row4_col4
        Me.b_row4_col4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row4_col4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row4_col4.FocusedState.Parent = Me.b_row4_col4
        Me.b_row4_col4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row4_col4.ForeColor = System.Drawing.Color.Black
        Me.b_row4_col4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row4_col4.HoverState.Parent = Me.b_row4_col4
        Me.b_row4_col4.Location = New System.Drawing.Point(223, 139)
        Me.b_row4_col4.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row4_col4.Name = "b_row4_col4"
        Me.b_row4_col4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row4_col4.PlaceholderText = ""
        Me.b_row4_col4.SelectedText = ""
        Me.b_row4_col4.ShadowDecoration.Parent = Me.b_row4_col4
        Me.b_row4_col4.Size = New System.Drawing.Size(58, 29)
        Me.b_row4_col4.TabIndex = 0
        Me.b_row4_col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row4_col4.Visible = False
        '
        'b_row4_col3
        '
        Me.b_row4_col3.BorderRadius = 5
        Me.b_row4_col3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row4_col3.DefaultText = ""
        Me.b_row4_col3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row4_col3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row4_col3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row4_col3.DisabledState.Parent = Me.b_row4_col3
        Me.b_row4_col3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row4_col3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row4_col3.FocusedState.Parent = Me.b_row4_col3
        Me.b_row4_col3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row4_col3.ForeColor = System.Drawing.Color.Black
        Me.b_row4_col3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row4_col3.HoverState.Parent = Me.b_row4_col3
        Me.b_row4_col3.Location = New System.Drawing.Point(157, 139)
        Me.b_row4_col3.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row4_col3.Name = "b_row4_col3"
        Me.b_row4_col3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row4_col3.PlaceholderText = ""
        Me.b_row4_col3.SelectedText = ""
        Me.b_row4_col3.ShadowDecoration.Parent = Me.b_row4_col3
        Me.b_row4_col3.Size = New System.Drawing.Size(58, 29)
        Me.b_row4_col3.TabIndex = 0
        Me.b_row4_col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row4_col3.Visible = False
        '
        'b_row3_col4
        '
        Me.b_row3_col4.BorderRadius = 5
        Me.b_row3_col4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row3_col4.DefaultText = ""
        Me.b_row3_col4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row3_col4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row3_col4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row3_col4.DisabledState.Parent = Me.b_row3_col4
        Me.b_row3_col4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row3_col4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row3_col4.FocusedState.Parent = Me.b_row3_col4
        Me.b_row3_col4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row3_col4.ForeColor = System.Drawing.Color.Black
        Me.b_row3_col4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row3_col4.HoverState.Parent = Me.b_row3_col4
        Me.b_row3_col4.Location = New System.Drawing.Point(223, 102)
        Me.b_row3_col4.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row3_col4.Name = "b_row3_col4"
        Me.b_row3_col4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row3_col4.PlaceholderText = ""
        Me.b_row3_col4.SelectedText = ""
        Me.b_row3_col4.ShadowDecoration.Parent = Me.b_row3_col4
        Me.b_row3_col4.Size = New System.Drawing.Size(58, 29)
        Me.b_row3_col4.TabIndex = 0
        Me.b_row3_col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row3_col4.Visible = False
        '
        'b_row3_col3
        '
        Me.b_row3_col3.BorderRadius = 5
        Me.b_row3_col3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row3_col3.DefaultText = ""
        Me.b_row3_col3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row3_col3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row3_col3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row3_col3.DisabledState.Parent = Me.b_row3_col3
        Me.b_row3_col3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row3_col3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row3_col3.FocusedState.Parent = Me.b_row3_col3
        Me.b_row3_col3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row3_col3.ForeColor = System.Drawing.Color.Black
        Me.b_row3_col3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row3_col3.HoverState.Parent = Me.b_row3_col3
        Me.b_row3_col3.Location = New System.Drawing.Point(157, 102)
        Me.b_row3_col3.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row3_col3.Name = "b_row3_col3"
        Me.b_row3_col3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row3_col3.PlaceholderText = ""
        Me.b_row3_col3.SelectedText = ""
        Me.b_row3_col3.ShadowDecoration.Parent = Me.b_row3_col3
        Me.b_row3_col3.Size = New System.Drawing.Size(58, 29)
        Me.b_row3_col3.TabIndex = 0
        Me.b_row3_col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row3_col3.Visible = False
        '
        'b_row2_col4
        '
        Me.b_row2_col4.BorderRadius = 5
        Me.b_row2_col4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row2_col4.DefaultText = ""
        Me.b_row2_col4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row2_col4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row2_col4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row2_col4.DisabledState.Parent = Me.b_row2_col4
        Me.b_row2_col4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row2_col4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row2_col4.FocusedState.Parent = Me.b_row2_col4
        Me.b_row2_col4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row2_col4.ForeColor = System.Drawing.Color.Black
        Me.b_row2_col4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row2_col4.HoverState.Parent = Me.b_row2_col4
        Me.b_row2_col4.Location = New System.Drawing.Point(223, 63)
        Me.b_row2_col4.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row2_col4.Name = "b_row2_col4"
        Me.b_row2_col4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row2_col4.PlaceholderText = ""
        Me.b_row2_col4.SelectedText = ""
        Me.b_row2_col4.ShadowDecoration.Parent = Me.b_row2_col4
        Me.b_row2_col4.Size = New System.Drawing.Size(58, 29)
        Me.b_row2_col4.TabIndex = 0
        Me.b_row2_col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row2_col4.Visible = False
        '
        'b_row4_col2
        '
        Me.b_row4_col2.BorderRadius = 5
        Me.b_row4_col2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row4_col2.DefaultText = ""
        Me.b_row4_col2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row4_col2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row4_col2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row4_col2.DisabledState.Parent = Me.b_row4_col2
        Me.b_row4_col2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row4_col2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row4_col2.FocusedState.Parent = Me.b_row4_col2
        Me.b_row4_col2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row4_col2.ForeColor = System.Drawing.Color.Black
        Me.b_row4_col2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row4_col2.HoverState.Parent = Me.b_row4_col2
        Me.b_row4_col2.Location = New System.Drawing.Point(91, 139)
        Me.b_row4_col2.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row4_col2.Name = "b_row4_col2"
        Me.b_row4_col2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row4_col2.PlaceholderText = ""
        Me.b_row4_col2.SelectedText = ""
        Me.b_row4_col2.ShadowDecoration.Parent = Me.b_row4_col2
        Me.b_row4_col2.Size = New System.Drawing.Size(58, 29)
        Me.b_row4_col2.TabIndex = 0
        Me.b_row4_col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row4_col2.Visible = False
        '
        'b_row2_col3
        '
        Me.b_row2_col3.BorderRadius = 5
        Me.b_row2_col3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row2_col3.DefaultText = ""
        Me.b_row2_col3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row2_col3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row2_col3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row2_col3.DisabledState.Parent = Me.b_row2_col3
        Me.b_row2_col3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row2_col3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row2_col3.FocusedState.Parent = Me.b_row2_col3
        Me.b_row2_col3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row2_col3.ForeColor = System.Drawing.Color.Black
        Me.b_row2_col3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row2_col3.HoverState.Parent = Me.b_row2_col3
        Me.b_row2_col3.Location = New System.Drawing.Point(157, 63)
        Me.b_row2_col3.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row2_col3.Name = "b_row2_col3"
        Me.b_row2_col3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row2_col3.PlaceholderText = ""
        Me.b_row2_col3.SelectedText = ""
        Me.b_row2_col3.ShadowDecoration.Parent = Me.b_row2_col3
        Me.b_row2_col3.Size = New System.Drawing.Size(58, 29)
        Me.b_row2_col3.TabIndex = 0
        Me.b_row2_col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row2_col3.Visible = False
        '
        'b_row3_col2
        '
        Me.b_row3_col2.BorderRadius = 5
        Me.b_row3_col2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row3_col2.DefaultText = ""
        Me.b_row3_col2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row3_col2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row3_col2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row3_col2.DisabledState.Parent = Me.b_row3_col2
        Me.b_row3_col2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row3_col2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row3_col2.FocusedState.Parent = Me.b_row3_col2
        Me.b_row3_col2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row3_col2.ForeColor = System.Drawing.Color.Black
        Me.b_row3_col2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row3_col2.HoverState.Parent = Me.b_row3_col2
        Me.b_row3_col2.Location = New System.Drawing.Point(91, 102)
        Me.b_row3_col2.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row3_col2.Name = "b_row3_col2"
        Me.b_row3_col2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row3_col2.PlaceholderText = ""
        Me.b_row3_col2.SelectedText = ""
        Me.b_row3_col2.ShadowDecoration.Parent = Me.b_row3_col2
        Me.b_row3_col2.Size = New System.Drawing.Size(58, 29)
        Me.b_row3_col2.TabIndex = 0
        Me.b_row3_col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row3_col2.Visible = False
        '
        'b_row1_col4
        '
        Me.b_row1_col4.BorderRadius = 5
        Me.b_row1_col4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row1_col4.DefaultText = ""
        Me.b_row1_col4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row1_col4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row1_col4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row1_col4.DisabledState.Parent = Me.b_row1_col4
        Me.b_row1_col4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row1_col4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row1_col4.FocusedState.Parent = Me.b_row1_col4
        Me.b_row1_col4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row1_col4.ForeColor = System.Drawing.Color.Black
        Me.b_row1_col4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row1_col4.HoverState.Parent = Me.b_row1_col4
        Me.b_row1_col4.Location = New System.Drawing.Point(223, 26)
        Me.b_row1_col4.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row1_col4.Name = "b_row1_col4"
        Me.b_row1_col4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row1_col4.PlaceholderText = ""
        Me.b_row1_col4.SelectedText = ""
        Me.b_row1_col4.ShadowDecoration.Parent = Me.b_row1_col4
        Me.b_row1_col4.Size = New System.Drawing.Size(58, 29)
        Me.b_row1_col4.TabIndex = 0
        Me.b_row1_col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row1_col4.Visible = False
        '
        'b_row4_col1
        '
        Me.b_row4_col1.BorderRadius = 5
        Me.b_row4_col1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row4_col1.DefaultText = ""
        Me.b_row4_col1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row4_col1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row4_col1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row4_col1.DisabledState.Parent = Me.b_row4_col1
        Me.b_row4_col1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row4_col1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row4_col1.FocusedState.Parent = Me.b_row4_col1
        Me.b_row4_col1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row4_col1.ForeColor = System.Drawing.Color.Black
        Me.b_row4_col1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row4_col1.HoverState.Parent = Me.b_row4_col1
        Me.b_row4_col1.Location = New System.Drawing.Point(25, 139)
        Me.b_row4_col1.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row4_col1.Name = "b_row4_col1"
        Me.b_row4_col1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row4_col1.PlaceholderText = ""
        Me.b_row4_col1.SelectedText = ""
        Me.b_row4_col1.ShadowDecoration.Parent = Me.b_row4_col1
        Me.b_row4_col1.Size = New System.Drawing.Size(58, 29)
        Me.b_row4_col1.TabIndex = 0
        Me.b_row4_col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row4_col1.Visible = False
        '
        'b_row2_col2
        '
        Me.b_row2_col2.BorderRadius = 5
        Me.b_row2_col2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row2_col2.DefaultText = ""
        Me.b_row2_col2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row2_col2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row2_col2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row2_col2.DisabledState.Parent = Me.b_row2_col2
        Me.b_row2_col2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row2_col2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row2_col2.FocusedState.Parent = Me.b_row2_col2
        Me.b_row2_col2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row2_col2.ForeColor = System.Drawing.Color.Black
        Me.b_row2_col2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row2_col2.HoverState.Parent = Me.b_row2_col2
        Me.b_row2_col2.Location = New System.Drawing.Point(91, 63)
        Me.b_row2_col2.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row2_col2.Name = "b_row2_col2"
        Me.b_row2_col2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row2_col2.PlaceholderText = ""
        Me.b_row2_col2.SelectedText = ""
        Me.b_row2_col2.ShadowDecoration.Parent = Me.b_row2_col2
        Me.b_row2_col2.Size = New System.Drawing.Size(58, 29)
        Me.b_row2_col2.TabIndex = 0
        Me.b_row2_col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row2_col2.Visible = False
        '
        'b_row3_col1
        '
        Me.b_row3_col1.BorderRadius = 5
        Me.b_row3_col1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row3_col1.DefaultText = ""
        Me.b_row3_col1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row3_col1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row3_col1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row3_col1.DisabledState.Parent = Me.b_row3_col1
        Me.b_row3_col1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row3_col1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row3_col1.FocusedState.Parent = Me.b_row3_col1
        Me.b_row3_col1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row3_col1.ForeColor = System.Drawing.Color.Black
        Me.b_row3_col1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row3_col1.HoverState.Parent = Me.b_row3_col1
        Me.b_row3_col1.Location = New System.Drawing.Point(25, 102)
        Me.b_row3_col1.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row3_col1.Name = "b_row3_col1"
        Me.b_row3_col1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row3_col1.PlaceholderText = ""
        Me.b_row3_col1.SelectedText = ""
        Me.b_row3_col1.ShadowDecoration.Parent = Me.b_row3_col1
        Me.b_row3_col1.Size = New System.Drawing.Size(58, 29)
        Me.b_row3_col1.TabIndex = 0
        Me.b_row3_col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row3_col1.Visible = False
        '
        'b_row1_col3
        '
        Me.b_row1_col3.BorderRadius = 5
        Me.b_row1_col3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row1_col3.DefaultText = ""
        Me.b_row1_col3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row1_col3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row1_col3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row1_col3.DisabledState.Parent = Me.b_row1_col3
        Me.b_row1_col3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row1_col3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row1_col3.FocusedState.Parent = Me.b_row1_col3
        Me.b_row1_col3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row1_col3.ForeColor = System.Drawing.Color.Black
        Me.b_row1_col3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row1_col3.HoverState.Parent = Me.b_row1_col3
        Me.b_row1_col3.Location = New System.Drawing.Point(157, 26)
        Me.b_row1_col3.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row1_col3.Name = "b_row1_col3"
        Me.b_row1_col3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row1_col3.PlaceholderText = ""
        Me.b_row1_col3.SelectedText = ""
        Me.b_row1_col3.ShadowDecoration.Parent = Me.b_row1_col3
        Me.b_row1_col3.Size = New System.Drawing.Size(58, 29)
        Me.b_row1_col3.TabIndex = 0
        Me.b_row1_col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row1_col3.Visible = False
        '
        'b_row2_col1
        '
        Me.b_row2_col1.BorderRadius = 5
        Me.b_row2_col1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row2_col1.DefaultText = ""
        Me.b_row2_col1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row2_col1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row2_col1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row2_col1.DisabledState.Parent = Me.b_row2_col1
        Me.b_row2_col1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row2_col1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row2_col1.FocusedState.Parent = Me.b_row2_col1
        Me.b_row2_col1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row2_col1.ForeColor = System.Drawing.Color.Black
        Me.b_row2_col1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row2_col1.HoverState.Parent = Me.b_row2_col1
        Me.b_row2_col1.Location = New System.Drawing.Point(25, 63)
        Me.b_row2_col1.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row2_col1.Name = "b_row2_col1"
        Me.b_row2_col1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row2_col1.PlaceholderText = ""
        Me.b_row2_col1.SelectedText = ""
        Me.b_row2_col1.ShadowDecoration.Parent = Me.b_row2_col1
        Me.b_row2_col1.Size = New System.Drawing.Size(58, 29)
        Me.b_row2_col1.TabIndex = 0
        Me.b_row2_col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row2_col1.Visible = False
        '
        'b_row1_col2
        '
        Me.b_row1_col2.BorderRadius = 5
        Me.b_row1_col2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row1_col2.DefaultText = ""
        Me.b_row1_col2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row1_col2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row1_col2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row1_col2.DisabledState.Parent = Me.b_row1_col2
        Me.b_row1_col2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row1_col2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row1_col2.FocusedState.Parent = Me.b_row1_col2
        Me.b_row1_col2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row1_col2.ForeColor = System.Drawing.Color.Black
        Me.b_row1_col2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row1_col2.HoverState.Parent = Me.b_row1_col2
        Me.b_row1_col2.Location = New System.Drawing.Point(91, 26)
        Me.b_row1_col2.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row1_col2.Name = "b_row1_col2"
        Me.b_row1_col2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row1_col2.PlaceholderText = ""
        Me.b_row1_col2.SelectedText = ""
        Me.b_row1_col2.ShadowDecoration.Parent = Me.b_row1_col2
        Me.b_row1_col2.Size = New System.Drawing.Size(58, 29)
        Me.b_row1_col2.TabIndex = 0
        Me.b_row1_col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row1_col2.Visible = False
        '
        'b_row1_col1
        '
        Me.b_row1_col1.BorderRadius = 5
        Me.b_row1_col1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.b_row1_col1.DefaultText = ""
        Me.b_row1_col1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.b_row1_col1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.b_row1_col1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row1_col1.DisabledState.Parent = Me.b_row1_col1
        Me.b_row1_col1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.b_row1_col1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row1_col1.FocusedState.Parent = Me.b_row1_col1
        Me.b_row1_col1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_row1_col1.ForeColor = System.Drawing.Color.Black
        Me.b_row1_col1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.b_row1_col1.HoverState.Parent = Me.b_row1_col1
        Me.b_row1_col1.Location = New System.Drawing.Point(25, 26)
        Me.b_row1_col1.Margin = New System.Windows.Forms.Padding(4)
        Me.b_row1_col1.Name = "b_row1_col1"
        Me.b_row1_col1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.b_row1_col1.PlaceholderText = ""
        Me.b_row1_col1.SelectedText = ""
        Me.b_row1_col1.ShadowDecoration.Parent = Me.b_row1_col1
        Me.b_row1_col1.Size = New System.Drawing.Size(58, 29)
        Me.b_row1_col1.TabIndex = 0
        Me.b_row1_col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b_row1_col1.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAdd.BorderRadius = 10
        Me.btnAdd.BorderThickness = 2
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(289, 366)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(141, 45)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Addition"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnClear.BorderRadius = 10
        Me.btnClear.BorderThickness = 2
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(289, 417)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(141, 45)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnBack.BorderRadius = 10
        Me.btnBack.BorderThickness = 2
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(555, 466)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(141, 45)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        '
        'AdditionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(708, 523)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBComboBox)
        Me.Controls.Add(Me.groupAComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdditionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdditionForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groupAComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents groupBComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents a_row1_col1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row4_col4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row4_col3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row3_col4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row3_col3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row2_col4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row4_col2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row2_col3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row3_col2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row1_col4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row4_col1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row2_col2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row3_col1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row1_col3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row2_col1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents a_row1_col2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents b_row4_col4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row4_col3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row3_col4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row3_col3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row2_col4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row4_col2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row2_col3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row3_col2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row1_col4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row4_col1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row2_col2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row3_col1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row1_col3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row2_col1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row1_col2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents b_row1_col1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
