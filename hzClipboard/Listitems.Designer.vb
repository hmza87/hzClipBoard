<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listitems
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.body = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.Lstitem2 = New hzClipboard.lstitem()
        Me.Lstitem1 = New hzClipboard.lstitem()
        CType(Me.body, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.body.PanelContainer.SuspendLayout()
        Me.body.SuspendLayout()
        Me.SuspendLayout()
        '
        'body
        '
        Me.body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.body.Location = New System.Drawing.Point(0, 0)
        Me.body.Name = "body"
        '
        'body.PanelContainer
        '
        Me.body.PanelContainer.Controls.Add(Me.Lstitem2)
        Me.body.PanelContainer.Controls.Add(Me.Lstitem1)
        Me.body.PanelContainer.Size = New System.Drawing.Size(292, 326)
        Me.body.Size = New System.Drawing.Size(294, 328)
        Me.body.TabIndex = 0
        Me.body.Text = "RadScrollablePanel1"
        '
        'Lstitem2
        '
        Me.Lstitem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Lstitem2.Detail = "5 minuts ago from Chrome"
        Me.Lstitem2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lstitem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Lstitem2.Location = New System.Drawing.Point(0, 54)
        Me.Lstitem2.Name = "Lstitem2"
        Me.Lstitem2.Size = New System.Drawing.Size(292, 54)
        Me.Lstitem2.TabIndex = 1
        Me.Lstitem2.Title = "ZQ ZEQZEQKDQLSMKD QDKQKQQMDLQK SDLMKQ DKLQ KSDMLQSKD LMQKSD qd"
        '
        'Lstitem1
        '
        Me.Lstitem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Lstitem1.Detail = "5 minuts ago from Chrome"
        Me.Lstitem1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lstitem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Lstitem1.Location = New System.Drawing.Point(0, 0)
        Me.Lstitem1.Name = "Lstitem1"
        Me.Lstitem1.Size = New System.Drawing.Size(292, 54)
        Me.Lstitem1.TabIndex = 0
        Me.Lstitem1.Title = "ZQ ZEQZEQKDQLSMKD QDKQKQQMDLQK SDLMKQ DKLQ KSDMLQSKD LMQKSD qd"
        '
        'Listitems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.body)
        Me.Name = "Listitems"
        Me.Size = New System.Drawing.Size(294, 328)
        Me.body.PanelContainer.ResumeLayout(False)
        CType(Me.body, System.ComponentModel.ISupportInitialize).EndInit()
        Me.body.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents body As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents Lstitem1 As hzClipboard.lstitem
    Friend WithEvents Lstitem2 As hzClipboard.lstitem

End Class
