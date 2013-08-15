<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIPCameraCapture
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MainPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FrameCountTextBox = New System.Windows.Forms.TextBox()
        Me.URLTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FrameResetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.History = New System.Windows.Forms.GroupBox()
        Me.HistoryPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HistoryPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HistoryPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.HistoryPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.HistoryPictureBox5 = New System.Windows.Forms.PictureBox()
        Me.HistoryPictureBox6 = New System.Windows.Forms.PictureBox()
        Me.HistoryPictureBox7 = New System.Windows.Forms.PictureBox()
        Me.SettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GenericCameraSettingsPanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FosCamSettingsPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FoscamPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FosCamUserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FosCamIPTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CameraTypeFosCamRadioButton = New System.Windows.Forms.RadioButton()
        Me.CameraTypeGenericRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FastAsPossibleCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GetSettingsButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.IROffButton = New System.Windows.Forms.Button()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.IROnButton = New System.Windows.Forms.Button()
        Me.RebootButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFosCamID = New System.Windows.Forms.TextBox()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.txtAppVer = New System.Windows.Forms.TextBox()
        Me.txtSysVer = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.History.SuspendLayout()
        CType(Me.HistoryPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingsGroupBox.SuspendLayout()
        Me.GenericCameraSettingsPanel.SuspendLayout()
        Me.FosCamSettingsPanel.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(549, 420)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Image"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MainPictureBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(543, 366)
        Me.Panel2.TabIndex = 2
        '
        'MainPictureBox
        '
        Me.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.MainPictureBox.Name = "MainPictureBox"
        Me.MainPictureBox.Size = New System.Drawing.Size(543, 366)
        Me.MainPictureBox.TabIndex = 0
        Me.MainPictureBox.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FrameCountTextBox, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(543, 35)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 18)
        Me.Label4.TabIndex = 1
        '
        'FrameCountTextBox
        '
        Me.FrameCountTextBox.Location = New System.Drawing.Point(274, 3)
        Me.FrameCountTextBox.Name = "FrameCountTextBox"
        Me.FrameCountTextBox.ReadOnly = True
        Me.FrameCountTextBox.Size = New System.Drawing.Size(266, 20)
        Me.FrameCountTextBox.TabIndex = 7
        '
        'URLTextBox
        '
        Me.URLTextBox.Location = New System.Drawing.Point(71, 16)
        Me.URLTextBox.Name = "URLTextBox"
        Me.URLTextBox.Size = New System.Drawing.Size(345, 20)
        Me.URLTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Image URL"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(6, 19)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(131, 23)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Enabled = False
        Me.StopButton.Location = New System.Drawing.Point(143, 19)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(127, 23)
        Me.StopButton.TabIndex = 1
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'FrameResetTimer
        '
        Me.FrameResetTimer.Enabled = True
        Me.FrameResetTimer.Interval = 1000
        '
        'History
        '
        Me.History.Controls.Add(Me.HistoryPictureBox1)
        Me.History.Controls.Add(Me.HistoryPictureBox2)
        Me.History.Controls.Add(Me.HistoryPictureBox3)
        Me.History.Controls.Add(Me.HistoryPictureBox4)
        Me.History.Controls.Add(Me.HistoryPictureBox5)
        Me.History.Controls.Add(Me.HistoryPictureBox6)
        Me.History.Controls.Add(Me.HistoryPictureBox7)
        Me.History.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.History.Location = New System.Drawing.Point(0, 434)
        Me.History.Name = "History"
        Me.History.Size = New System.Drawing.Size(1115, 172)
        Me.History.TabIndex = 7
        Me.History.TabStop = False
        Me.History.Text = "History"
        '
        'HistoryPictureBox1
        '
        Me.HistoryPictureBox1.Location = New System.Drawing.Point(954, 19)
        Me.HistoryPictureBox1.Name = "HistoryPictureBox1"
        Me.HistoryPictureBox1.Size = New System.Drawing.Size(151, 142)
        Me.HistoryPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HistoryPictureBox1.TabIndex = 0
        Me.HistoryPictureBox1.TabStop = False
        '
        'HistoryPictureBox2
        '
        Me.HistoryPictureBox2.Location = New System.Drawing.Point(797, 19)
        Me.HistoryPictureBox2.Name = "HistoryPictureBox2"
        Me.HistoryPictureBox2.Size = New System.Drawing.Size(151, 142)
        Me.HistoryPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HistoryPictureBox2.TabIndex = 0
        Me.HistoryPictureBox2.TabStop = False
        '
        'HistoryPictureBox3
        '
        Me.HistoryPictureBox3.Location = New System.Drawing.Point(640, 19)
        Me.HistoryPictureBox3.Name = "HistoryPictureBox3"
        Me.HistoryPictureBox3.Size = New System.Drawing.Size(151, 142)
        Me.HistoryPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HistoryPictureBox3.TabIndex = 0
        Me.HistoryPictureBox3.TabStop = False
        '
        'HistoryPictureBox4
        '
        Me.HistoryPictureBox4.Location = New System.Drawing.Point(483, 19)
        Me.HistoryPictureBox4.Name = "HistoryPictureBox4"
        Me.HistoryPictureBox4.Size = New System.Drawing.Size(151, 142)
        Me.HistoryPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HistoryPictureBox4.TabIndex = 0
        Me.HistoryPictureBox4.TabStop = False
        '
        'HistoryPictureBox5
        '
        Me.HistoryPictureBox5.Location = New System.Drawing.Point(326, 19)
        Me.HistoryPictureBox5.Name = "HistoryPictureBox5"
        Me.HistoryPictureBox5.Size = New System.Drawing.Size(151, 142)
        Me.HistoryPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HistoryPictureBox5.TabIndex = 0
        Me.HistoryPictureBox5.TabStop = False
        '
        'HistoryPictureBox6
        '
        Me.HistoryPictureBox6.Location = New System.Drawing.Point(169, 19)
        Me.HistoryPictureBox6.Name = "HistoryPictureBox6"
        Me.HistoryPictureBox6.Size = New System.Drawing.Size(151, 142)
        Me.HistoryPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HistoryPictureBox6.TabIndex = 0
        Me.HistoryPictureBox6.TabStop = False
        '
        'HistoryPictureBox7
        '
        Me.HistoryPictureBox7.Location = New System.Drawing.Point(12, 19)
        Me.HistoryPictureBox7.Name = "HistoryPictureBox7"
        Me.HistoryPictureBox7.Size = New System.Drawing.Size(151, 142)
        Me.HistoryPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HistoryPictureBox7.TabIndex = 0
        Me.HistoryPictureBox7.TabStop = False
        '
        'SettingsGroupBox
        '
        Me.SettingsGroupBox.Controls.Add(Me.GenericCameraSettingsPanel)
        Me.SettingsGroupBox.Controls.Add(Me.FosCamSettingsPanel)
        Me.SettingsGroupBox.Controls.Add(Me.FlowLayoutPanel1)
        Me.SettingsGroupBox.Controls.Add(Me.Label1)
        Me.SettingsGroupBox.Location = New System.Drawing.Point(561, 12)
        Me.SettingsGroupBox.Name = "SettingsGroupBox"
        Me.SettingsGroupBox.Size = New System.Drawing.Size(544, 172)
        Me.SettingsGroupBox.TabIndex = 0
        Me.SettingsGroupBox.TabStop = False
        Me.SettingsGroupBox.Text = "Settings"
        '
        'GenericCameraSettingsPanel
        '
        Me.GenericCameraSettingsPanel.Controls.Add(Me.Label5)
        Me.GenericCameraSettingsPanel.Controls.Add(Me.URLTextBox)
        Me.GenericCameraSettingsPanel.Controls.Add(Me.Label2)
        Me.GenericCameraSettingsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenericCameraSettingsPanel.Location = New System.Drawing.Point(3, 121)
        Me.GenericCameraSettingsPanel.Name = "GenericCameraSettingsPanel"
        Me.GenericCameraSettingsPanel.Size = New System.Drawing.Size(538, 45)
        Me.GenericCameraSettingsPanel.TabIndex = 4
        Me.GenericCameraSettingsPanel.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(538, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Camera Settings"
        '
        'FosCamSettingsPanel
        '
        Me.FosCamSettingsPanel.Controls.Add(Me.Label3)
        Me.FosCamSettingsPanel.Controls.Add(Me.FoscamPasswordTextBox)
        Me.FosCamSettingsPanel.Controls.Add(Me.Label8)
        Me.FosCamSettingsPanel.Controls.Add(Me.FosCamUserNameTextBox)
        Me.FosCamSettingsPanel.Controls.Add(Me.Label7)
        Me.FosCamSettingsPanel.Controls.Add(Me.FosCamIPTextBox)
        Me.FosCamSettingsPanel.Controls.Add(Me.Label6)
        Me.FosCamSettingsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FosCamSettingsPanel.Location = New System.Drawing.Point(3, 52)
        Me.FosCamSettingsPanel.Name = "FosCamSettingsPanel"
        Me.FosCamSettingsPanel.Size = New System.Drawing.Size(538, 69)
        Me.FosCamSettingsPanel.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(538, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Camera Settings"
        '
        'FoscamPasswordTextBox
        '
        Me.FoscamPasswordTextBox.Location = New System.Drawing.Point(287, 42)
        Me.FoscamPasswordTextBox.Name = "FoscamPasswordTextBox"
        Me.FoscamPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.FoscamPasswordTextBox.Size = New System.Drawing.Size(140, 20)
        Me.FoscamPasswordTextBox.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(220, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Password"
        '
        'FosCamUserNameTextBox
        '
        Me.FosCamUserNameTextBox.Location = New System.Drawing.Point(72, 42)
        Me.FosCamUserNameTextBox.Name = "FosCamUserNameTextBox"
        Me.FosCamUserNameTextBox.Size = New System.Drawing.Size(140, 20)
        Me.FosCamUserNameTextBox.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Username"
        '
        'FosCamIPTextBox
        '
        Me.FosCamIPTextBox.Location = New System.Drawing.Point(72, 16)
        Me.FosCamIPTextBox.Name = "FosCamIPTextBox"
        Me.FosCamIPTextBox.Size = New System.Drawing.Size(355, 20)
        Me.FosCamIPTextBox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "IP Address"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.CameraTypeFosCamRadioButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CameraTypeGenericRadioButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 29)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(538, 23)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'CameraTypeFosCamRadioButton
        '
        Me.CameraTypeFosCamRadioButton.AutoSize = True
        Me.CameraTypeFosCamRadioButton.Checked = True
        Me.CameraTypeFosCamRadioButton.Location = New System.Drawing.Point(3, 3)
        Me.CameraTypeFosCamRadioButton.Name = "CameraTypeFosCamRadioButton"
        Me.CameraTypeFosCamRadioButton.Size = New System.Drawing.Size(63, 17)
        Me.CameraTypeFosCamRadioButton.TabIndex = 0
        Me.CameraTypeFosCamRadioButton.TabStop = True
        Me.CameraTypeFosCamRadioButton.Text = "FosCam"
        Me.CameraTypeFosCamRadioButton.UseVisualStyleBackColor = True
        '
        'CameraTypeGenericRadioButton
        '
        Me.CameraTypeGenericRadioButton.AutoSize = True
        Me.CameraTypeGenericRadioButton.Location = New System.Drawing.Point(72, 3)
        Me.CameraTypeGenericRadioButton.Name = "CameraTypeGenericRadioButton"
        Me.CameraTypeGenericRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.CameraTypeGenericRadioButton.TabIndex = 1
        Me.CameraTypeGenericRadioButton.Text = "Generic"
        Me.CameraTypeGenericRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Camera Type"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.StartButton)
        Me.GroupBox3.Controls.Add(Me.StopButton)
        Me.GroupBox3.Location = New System.Drawing.Point(561, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 53)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control"
        '
        'FastAsPossibleCheckBox
        '
        Me.FastAsPossibleCheckBox.AutoSize = True
        Me.FastAsPossibleCheckBox.Location = New System.Drawing.Point(141, 19)
        Me.FastAsPossibleCheckBox.Name = "FastAsPossibleCheckBox"
        Me.FastAsPossibleCheckBox.Size = New System.Drawing.Size(101, 17)
        Me.FastAsPossibleCheckBox.TabIndex = 3
        Me.FastAsPossibleCheckBox.Text = "Fast as possible"
        Me.FastAsPossibleCheckBox.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(107, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "20"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(74, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "10"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(41, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "5"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "4"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FastAsPossibleCheckBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(843, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 53)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Framerate"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox4.Controls.Add(Me.GetSettingsButton)
        Me.GroupBox4.Controls.Add(Me.DownButton)
        Me.GroupBox4.Controls.Add(Me.IROffButton)
        Me.GroupBox4.Controls.Add(Me.RightButton)
        Me.GroupBox4.Controls.Add(Me.LeftButton)
        Me.GroupBox4.Controls.Add(Me.UpButton)
        Me.GroupBox4.Controls.Add(Me.IROnButton)
        Me.GroupBox4.Controls.Add(Me.RebootButton)
        Me.GroupBox4.Location = New System.Drawing.Point(561, 249)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(544, 183)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "FosCam Tools"
        '
        'GetSettingsButton
        '
        Me.GetSettingsButton.Location = New System.Drawing.Point(478, 107)
        Me.GetSettingsButton.Name = "GetSettingsButton"
        Me.GetSettingsButton.Size = New System.Drawing.Size(52, 23)
        Me.GetSettingsButton.TabIndex = 0
        Me.GetSettingsButton.Text = "Down"
        Me.GetSettingsButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.Location = New System.Drawing.Point(58, 107)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(52, 23)
        Me.DownButton.TabIndex = 0
        Me.DownButton.Text = "Down"
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'IROffButton
        '
        Me.IROffButton.Location = New System.Drawing.Point(91, 19)
        Me.IROffButton.Name = "IROffButton"
        Me.IROffButton.Size = New System.Drawing.Size(74, 23)
        Me.IROffButton.TabIndex = 0
        Me.IROffButton.Text = "IR Off"
        Me.IROffButton.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.Location = New System.Drawing.Point(89, 78)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(45, 23)
        Me.RightButton.TabIndex = 0
        Me.RightButton.Text = "Right"
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'LeftButton
        '
        Me.LeftButton.Location = New System.Drawing.Point(38, 78)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(45, 23)
        Me.LeftButton.TabIndex = 0
        Me.LeftButton.Text = "Left"
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'UpButton
        '
        Me.UpButton.Location = New System.Drawing.Point(58, 49)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(52, 23)
        Me.UpButton.TabIndex = 0
        Me.UpButton.Text = "Up"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'IROnButton
        '
        Me.IROnButton.Location = New System.Drawing.Point(11, 19)
        Me.IROnButton.Name = "IROnButton"
        Me.IROnButton.Size = New System.Drawing.Size(74, 23)
        Me.IROnButton.TabIndex = 0
        Me.IROnButton.Text = "IR On"
        Me.IROnButton.UseVisualStyleBackColor = True
        '
        'RebootButton
        '
        Me.RebootButton.Location = New System.Drawing.Point(478, 154)
        Me.RebootButton.Name = "RebootButton"
        Me.RebootButton.Size = New System.Drawing.Size(60, 23)
        Me.RebootButton.TabIndex = 0
        Me.RebootButton.Text = "Reboot"
        Me.RebootButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFosCamID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAlias, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAppVer, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSysVer, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(226, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "FosCam ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Sys_Ver"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "App_Ver"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Alias"
        '
        'txtFosCamID
        '
        Me.txtFosCamID.Location = New System.Drawing.Point(102, 3)
        Me.txtFosCamID.Name = "txtFosCamID"
        Me.txtFosCamID.Size = New System.Drawing.Size(95, 20)
        Me.txtFosCamID.TabIndex = 4
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(102, 29)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(95, 20)
        Me.txtAlias.TabIndex = 4
        '
        'txtAppVer
        '
        Me.txtAppVer.Location = New System.Drawing.Point(102, 55)
        Me.txtAppVer.Name = "txtAppVer"
        Me.txtAppVer.Size = New System.Drawing.Size(95, 20)
        Me.txtAppVer.TabIndex = 4
        '
        'txtSysVer
        '
        Me.txtSysVer.Location = New System.Drawing.Point(102, 81)
        Me.txtSysVer.Name = "txtSysVer"
        Me.txtSysVer.Size = New System.Drawing.Size(95, 20)
        Me.txtSysVer.TabIndex = 4
        '
        'frmIPCameraCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 606)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.SettingsGroupBox)
        Me.Controls.Add(Me.History)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmIPCameraCapture"
        Me.Text = "Image Folder Watcher"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.History.ResumeLayout(False)
        CType(Me.HistoryPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingsGroupBox.ResumeLayout(False)
        Me.SettingsGroupBox.PerformLayout()
        Me.GenericCameraSettingsPanel.ResumeLayout(False)
        Me.GenericCameraSettingsPanel.PerformLayout()
        Me.FosCamSettingsPanel.ResumeLayout(False)
        Me.FosCamSettingsPanel.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MainPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents URLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents FrameResetTimer As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FrameCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents History As System.Windows.Forms.GroupBox
    Friend WithEvents HistoryPictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HistoryPictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents HistoryPictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents HistoryPictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents HistoryPictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents HistoryPictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents HistoryPictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents SettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GenericCameraSettingsPanel As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FosCamSettingsPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CameraTypeFosCamRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CameraTypeGenericRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FoscamPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FosCamUserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FosCamIPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FastAsPossibleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DownButton As System.Windows.Forms.Button
    Friend WithEvents IROffButton As System.Windows.Forms.Button
    Friend WithEvents LeftButton As System.Windows.Forms.Button
    Friend WithEvents UpButton As System.Windows.Forms.Button
    Friend WithEvents IROnButton As System.Windows.Forms.Button
    Friend WithEvents RebootButton As System.Windows.Forms.Button
    Friend WithEvents RightButton As System.Windows.Forms.Button
    Friend WithEvents GetSettingsButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFosCamID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents txtAppVer As System.Windows.Forms.TextBox
    Friend WithEvents txtSysVer As System.Windows.Forms.TextBox

End Class
