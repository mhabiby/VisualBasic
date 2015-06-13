<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMobilePhoneStore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMobilePhoneStore))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpTypeOfBuyer = New System.Windows.Forms.GroupBox()
        Me.radInStore = New System.Windows.Forms.RadioButton()
        Me.radInternet = New System.Windows.Forms.RadioButton()
        Me.lblCots = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnCalculateCost = New System.Windows.Forms.Button()
        Me.txtStreetAdress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.cboPhoneChoice = New System.Windows.Forms.ComboBox()
        Me.cboChargerStyle = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtZipeCode = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.grpTypeOfBuyer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(467, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Charger Style:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(604, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Zip Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Choice:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Street Adress:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(435, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 64)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mobile " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phone Store"
        '
        'grpTypeOfBuyer
        '
        Me.grpTypeOfBuyer.Controls.Add(Me.radInStore)
        Me.grpTypeOfBuyer.Controls.Add(Me.radInternet)
        Me.grpTypeOfBuyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTypeOfBuyer.Location = New System.Drawing.Point(114, 354)
        Me.grpTypeOfBuyer.Name = "grpTypeOfBuyer"
        Me.grpTypeOfBuyer.Size = New System.Drawing.Size(200, 100)
        Me.grpTypeOfBuyer.TabIndex = 6
        Me.grpTypeOfBuyer.TabStop = False
        Me.grpTypeOfBuyer.Text = "Type of Buyer"
        '
        'radInStore
        '
        Me.radInStore.AutoSize = True
        Me.radInStore.Location = New System.Drawing.Point(18, 36)
        Me.radInStore.Name = "radInStore"
        Me.radInStore.Size = New System.Drawing.Size(89, 22)
        Me.radInStore.TabIndex = 10
        Me.radInStore.TabStop = True
        Me.radInStore.Text = "In-Store"
        Me.radInStore.UseVisualStyleBackColor = True
        '
        'radInternet
        '
        Me.radInternet.AutoSize = True
        Me.radInternet.Location = New System.Drawing.Point(18, 63)
        Me.radInternet.Name = "radInternet"
        Me.radInternet.Size = New System.Drawing.Size(85, 22)
        Me.radInternet.TabIndex = 9
        Me.radInternet.TabStop = True
        Me.radInternet.Text = "Internet"
        Me.radInternet.UseVisualStyleBackColor = True
        '
        'lblCots
        '
        Me.lblCots.AutoSize = True
        Me.lblCots.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCots.Location = New System.Drawing.Point(394, 501)
        Me.lblCots.Name = "lblCots"
        Me.lblCots.Size = New System.Drawing.Size(87, 18)
        Me.lblCots.TabIndex = 0
        Me.lblCots.Text = "Total Cost"
        Me.lblCots.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Email Address:"
        '
        'btnClearForm
        '
        Me.btnClearForm.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClearForm.Location = New System.Drawing.Point(192, 544)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(160, 31)
        Me.btnClearForm.TabIndex = 7
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'btnCalculateCost
        '
        Me.btnCalculateCost.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCalculateCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCost.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCalculateCost.Location = New System.Drawing.Point(192, 501)
        Me.btnCalculateCost.Name = "btnCalculateCost"
        Me.btnCalculateCost.Size = New System.Drawing.Size(160, 37)
        Me.btnCalculateCost.TabIndex = 8
        Me.btnCalculateCost.Text = "Calculate Cost"
        Me.btnCalculateCost.UseVisualStyleBackColor = False
        '
        'txtStreetAdress
        '
        Me.txtStreetAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetAdress.Location = New System.Drawing.Point(249, 244)
        Me.txtStreetAdress.Name = "txtStreetAdress"
        Me.txtStreetAdress.Size = New System.Drawing.Size(217, 24)
        Me.txtStreetAdress.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(249, 184)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(217, 24)
        Me.txtLastName.TabIndex = 1
        '
        'cboPhoneChoice
        '
        Me.cboPhoneChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPhoneChoice.FormattingEnabled = True
        Me.cboPhoneChoice.Items.AddRange(New Object() {"Blasstur 451", "Elecque 9801", "Gainlet 3", "Gainlet 3", "Querta 332"})
        Me.cboPhoneChoice.Location = New System.Drawing.Point(249, 299)
        Me.cboPhoneChoice.Name = "cboPhoneChoice"
        Me.cboPhoneChoice.Size = New System.Drawing.Size(159, 26)
        Me.cboPhoneChoice.TabIndex = 4
        Me.cboPhoneChoice.Text = "Select a phone"
        '
        'cboChargerStyle
        '
        Me.cboChargerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChargerStyle.FormattingEnabled = True
        Me.cboChargerStyle.Items.AddRange(New Object() {"Auto", "Mobile", "Desktop"})
        Me.cboChargerStyle.Location = New System.Drawing.Point(607, 289)
        Me.cboChargerStyle.Name = "cboChargerStyle"
        Me.cboChargerStyle.Size = New System.Drawing.Size(160, 26)
        Me.cboChargerStyle.TabIndex = 5
        Me.cboChargerStyle.Text = "Select a charger"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(75, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'txtZipeCode
        '
        Me.txtZipeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipeCode.Location = New System.Drawing.Point(715, 244)
        Me.txtZipeCode.Mask = "09999"
        Me.txtZipeCode.Name = "txtZipeCode"
        Me.txtZipeCode.Size = New System.Drawing.Size(52, 24)
        Me.txtZipeCode.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(524, 386)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(243, 24)
        Me.txtEmail.TabIndex = 6
        '
        'frmMobilePhoneStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(875, 660)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtZipeCode)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboChargerStyle)
        Me.Controls.Add(Me.cboPhoneChoice)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtStreetAdress)
        Me.Controls.Add(Me.btnCalculateCost)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.lblCots)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grpTypeOfBuyer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMobilePhoneStore"
        Me.Text = "Mobile Phone Store"
        Me.grpTypeOfBuyer.ResumeLayout(False)
        Me.grpTypeOfBuyer.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpTypeOfBuyer As System.Windows.Forms.GroupBox
    Friend WithEvents radInStore As System.Windows.Forms.RadioButton
    Friend WithEvents radInternet As System.Windows.Forms.RadioButton
    Friend WithEvents lblCots As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents btnCalculateCost As System.Windows.Forms.Button
    Friend WithEvents txtStreetAdress As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents cboPhoneChoice As System.Windows.Forms.ComboBox
    Friend WithEvents cboChargerStyle As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtZipeCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox

End Class
