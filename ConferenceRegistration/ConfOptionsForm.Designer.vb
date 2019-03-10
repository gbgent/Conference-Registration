<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfOptionsForm
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
        Me.gp_Conference = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Dinner = New System.Windows.Forms.CheckBox()
        Me.cb_Conference = New System.Windows.Forms.CheckBox()
        Me.gp_WorkShops = New System.Windows.Forms.GroupBox()
        Me.lbx_WorkShops = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.gp_Conference.SuspendLayout()
        Me.gp_WorkShops.SuspendLayout()
        Me.SuspendLayout()
        '
        'gp_Conference
        '
        Me.gp_Conference.Controls.Add(Me.Label2)
        Me.gp_Conference.Controls.Add(Me.Label1)
        Me.gp_Conference.Controls.Add(Me.cb_Dinner)
        Me.gp_Conference.Controls.Add(Me.cb_Conference)
        Me.gp_Conference.Location = New System.Drawing.Point(46, 32)
        Me.gp_Conference.Name = "gp_Conference"
        Me.gp_Conference.Size = New System.Drawing.Size(350, 181)
        Me.gp_Conference.TabIndex = 0
        Me.gp_Conference.TabStop = False
        Me.gp_Conference.Text = "Conference"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(291, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "$30"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(291, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "$895"
        '
        'cb_Dinner
        '
        Me.cb_Dinner.AutoSize = True
        Me.cb_Dinner.Enabled = False
        Me.cb_Dinner.Location = New System.Drawing.Point(28, 116)
        Me.cb_Dinner.Name = "cb_Dinner"
        Me.cb_Dinner.Size = New System.Drawing.Size(236, 24)
        Me.cb_Dinner.TabIndex = 1
        Me.cb_Dinner.Text = "Opening NIght Dinner & Keynote"
        Me.cb_Dinner.UseVisualStyleBackColor = True
        '
        'cb_Conference
        '
        Me.cb_Conference.AutoSize = True
        Me.cb_Conference.Location = New System.Drawing.Point(28, 52)
        Me.cb_Conference.Name = "cb_Conference"
        Me.cb_Conference.Size = New System.Drawing.Size(187, 24)
        Me.cb_Conference.TabIndex = 0
        Me.cb_Conference.Text = "Conference Registration"
        Me.cb_Conference.UseVisualStyleBackColor = True
        '
        'gp_WorkShops
        '
        Me.gp_WorkShops.Controls.Add(Me.lbx_WorkShops)
        Me.gp_WorkShops.Controls.Add(Me.Label3)
        Me.gp_WorkShops.Location = New System.Drawing.Point(420, 32)
        Me.gp_WorkShops.Name = "gp_WorkShops"
        Me.gp_WorkShops.Size = New System.Drawing.Size(350, 181)
        Me.gp_WorkShops.TabIndex = 4
        Me.gp_WorkShops.TabStop = False
        Me.gp_WorkShops.Text = "Presentation Workshops"
        '
        'lbx_WorkShops
        '
        Me.lbx_WorkShops.Enabled = False
        Me.lbx_WorkShops.FormattingEnabled = True
        Me.lbx_WorkShops.ItemHeight = 20
        Me.lbx_WorkShops.Items.AddRange(New Object() {"Introduction to E-commerce               $295", "The Future of the Web                          $295", "Advanced Visual Basic                          $395 ", "Network Security                                   $395"})
        Me.lbx_WorkShops.Location = New System.Drawing.Point(10, 56)
        Me.lbx_WorkShops.Name = "lbx_WorkShops"
        Me.lbx_WorkShops.Size = New System.Drawing.Size(316, 84)
        Me.lbx_WorkShops.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Select One"
        '
        'btn_Reset
        '
        Me.btn_Reset.Enabled = False
        Me.btn_Reset.Location = New System.Drawing.Point(420, 278)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(125, 42)
        Me.btn_Reset.TabIndex = 5
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(580, 278)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(125, 42)
        Me.btn_Close.TabIndex = 6
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'ConfOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(808, 343)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.gp_WorkShops)
        Me.Controls.Add(Me.gp_Conference)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ConfOptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conference Options"
        Me.gp_Conference.ResumeLayout(False)
        Me.gp_Conference.PerformLayout()
        Me.gp_WorkShops.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gp_Conference As GroupBox
    Friend WithEvents cb_Dinner As CheckBox
    Friend WithEvents cb_Conference As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gp_WorkShops As GroupBox
    Friend WithEvents lbx_WorkShops As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Close As Button
End Class
