<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHelpMenu = New System.Windows.Forms.Button()
        Me.btnAboutMenu = New System.Windows.Forms.Button()
        Me.btnEmployeeMenu = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnHelpMenu)
        Me.Panel1.Controls.Add(Me.btnAboutMenu)
        Me.Panel1.Controls.Add(Me.btnEmployeeMenu)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 612)
        Me.Panel1.TabIndex = 0
        '
        'btnHelpMenu
        '
        Me.btnHelpMenu.BackColor = System.Drawing.Color.White
        Me.btnHelpMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHelpMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelpMenu.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnHelpMenu.Location = New System.Drawing.Point(0, 224)
        Me.btnHelpMenu.Name = "btnHelpMenu"
        Me.btnHelpMenu.Size = New System.Drawing.Size(203, 40)
        Me.btnHelpMenu.TabIndex = 3
        Me.btnHelpMenu.Text = "Help line"
        Me.btnHelpMenu.UseVisualStyleBackColor = False
        '
        'btnAboutMenu
        '
        Me.btnAboutMenu.BackColor = System.Drawing.Color.White
        Me.btnAboutMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAboutMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutMenu.ForeColor = System.Drawing.Color.Goldenrod
        Me.btnAboutMenu.Location = New System.Drawing.Point(0, 184)
        Me.btnAboutMenu.Name = "btnAboutMenu"
        Me.btnAboutMenu.Size = New System.Drawing.Size(203, 40)
        Me.btnAboutMenu.TabIndex = 2
        Me.btnAboutMenu.Text = "About us"
        Me.btnAboutMenu.UseVisualStyleBackColor = False
        '
        'btnEmployeeMenu
        '
        Me.btnEmployeeMenu.BackColor = System.Drawing.Color.White
        Me.btnEmployeeMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmployeeMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeMenu.ForeColor = System.Drawing.Color.IndianRed
        Me.btnEmployeeMenu.Location = New System.Drawing.Point(0, 144)
        Me.btnEmployeeMenu.Name = "btnEmployeeMenu"
        Me.btnEmployeeMenu.Size = New System.Drawing.Size(203, 40)
        Me.btnEmployeeMenu.TabIndex = 1
        Me.btnEmployeeMenu.Text = "Employee"
        Me.btnEmployeeMenu.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = Global.DruckCrudVB.My.Resources.Resources.images
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 144)
        Me.Panel2.TabIndex = 1
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 612)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainWindow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAboutMenu As Button
    Friend WithEvents btnEmployeeMenu As Button
    Friend WithEvents btnHelpMenu As Button
End Class
