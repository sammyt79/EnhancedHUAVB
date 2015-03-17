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
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.cboAppliance = New System.Windows.Forms.ComboBox()
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtCostGal = New System.Windows.Forms.TextBox()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.lblCostGal = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(183, 57)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(50, 20)
        Me.txtCost.TabIndex = 0
        '
        'cboAppliance
        '
        Me.cboAppliance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAppliance.FormattingEnabled = True
        Me.cboAppliance.Items.AddRange(New Object() {"Stereo", "Dish Washer", "Lava Lamp", "Microwave", "Gamma Blaster", "TV"})
        Me.cboAppliance.Location = New System.Drawing.Point(183, 22)
        Me.cboAppliance.Name = "cboAppliance"
        Me.cboAppliance.Size = New System.Drawing.Size(121, 21)
        Me.cboAppliance.TabIndex = 1
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Location = New System.Drawing.Point(24, 25)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(85, 13)
        Me.lblAppliance.TabIndex = 2
        Me.lblAppliance.Text = "Home Appliance"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(24, 60)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(136, 13)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Cost / kW-hour ( in dollars )"
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Location = New System.Drawing.Point(24, 95)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(109, 13)
        Me.lblPower.TabIndex = 4
        Me.lblPower.Text = "Power Needed in kW"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(24, 130)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(93, 13)
        Me.lblHours.TabIndex = 5
        Me.lblHours.Text = "Hours Used / Day"
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(183, 92)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(50, 20)
        Me.txtPower.TabIndex = 6
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(183, 127)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(50, 20)
        Me.txtHours.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(287, 64)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.Location = New System.Drawing.Point(287, 109)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 25)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(287, 154)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtCostGal
        '
        Me.txtCostGal.Location = New System.Drawing.Point(183, 197)
        Me.txtCostGal.Name = "txtCostGal"
        Me.txtCostGal.ReadOnly = True
        Me.txtCostGal.Size = New System.Drawing.Size(50, 20)
        Me.txtCostGal.TabIndex = 20
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(183, 162)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.ReadOnly = True
        Me.txtGallons.Size = New System.Drawing.Size(50, 20)
        Me.txtGallons.TabIndex = 19
        '
        'lblCostGal
        '
        Me.lblCostGal.AutoSize = True
        Me.lblCostGal.Location = New System.Drawing.Point(24, 200)
        Me.lblCostGal.Name = "lblCostGal"
        Me.lblCostGal.Size = New System.Drawing.Size(121, 13)
        Me.lblCostGal.TabIndex = 18
        Me.lblCostGal.Text = "Cost / Gallon ( in cents )"
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Location = New System.Drawing.Point(24, 165)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(94, 13)
        Me.lblGallons.TabIndex = 17
        Me.lblGallons.Text = "Number of Gallons"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 240)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(443, 197)
        Me.DataGridView1.TabIndex = 21
        '
        'Column1
        '
        Me.Column1.HeaderText = "Home Appliance"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Hours / Day"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cost / Hour"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Annual Cost"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(337, 197)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 22
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(257, 200)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(74, 13)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "Running Total"
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(468, 464)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCostGal)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.lblCostGal)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtPower)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblPower)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblAppliance)
        Me.Controls.Add(Me.cboAppliance)
        Me.Controls.Add(Me.txtCost)
        Me.Name = "MainForm"
        Me.Text = "Home Utility Auditing Program"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents cboAppliance As System.Windows.Forms.ComboBox
    Friend WithEvents lblAppliance As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblPower As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents txtPower As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtCostGal As System.Windows.Forms.TextBox
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents lblCostGal As System.Windows.Forms.Label
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
