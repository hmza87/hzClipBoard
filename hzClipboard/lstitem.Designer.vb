<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstitem
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
        Me.body = New Telerik.WinControls.UI.RadPanel()
        Me.iTitle = New Telerik.WinControls.UI.RadLabel()
        Me.iDetail = New Telerik.WinControls.UI.RadLabel()
        Me.iClose = New System.Windows.Forms.Label()
        CType(Me.body, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.body.SuspendLayout()
        CType(Me.iTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.iDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'body
        '
        Me.body.Controls.Add(Me.iTitle)
        Me.body.Controls.Add(Me.iDetail)
        Me.body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.body.Location = New System.Drawing.Point(0, 0)
        Me.body.Name = "body"
        Me.body.Size = New System.Drawing.Size(394, 54)
        Me.body.TabIndex = 0
        '
        'iTitle
        '
        Me.iTitle.AutoSize = False
        Me.iTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.iTitle.Location = New System.Drawing.Point(0, 0)
        Me.iTitle.Name = "iTitle"
        Me.iTitle.Size = New System.Drawing.Size(394, 35)
        Me.iTitle.TabIndex = 0
        Me.iTitle.Text = "ZQ ZEQZEQKDQLSMKD QDKQKQQMDLQK SDLMKQ DKLQ KSDMLQSKD LMQKSD qd"
        '
        'iDetail
        '
        Me.iDetail.AutoSize = False
        Me.iDetail.Controls.Add(Me.iClose)
        Me.iDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.iDetail.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iDetail.ForeColor = System.Drawing.Color.Gainsboro
        Me.iDetail.Location = New System.Drawing.Point(0, 35)
        Me.iDetail.Name = "iDetail"
        Me.iDetail.Size = New System.Drawing.Size(394, 19)
        Me.iDetail.TabIndex = 1
        Me.iDetail.Text = "RadLabel2"
        '
        'iClose
        '
        Me.iClose.BackColor = System.Drawing.Color.Transparent
        Me.iClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.iClose.Location = New System.Drawing.Point(374, 0)
        Me.iClose.Name = "iClose"
        Me.iClose.Size = New System.Drawing.Size(20, 19)
        Me.iClose.TabIndex = 0
        Me.iClose.Text = "X"
        Me.iClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Controls.Add(Me.body)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Name = "lstitem"
        Me.Size = New System.Drawing.Size(394, 54)
        CType(Me.body, System.ComponentModel.ISupportInitialize).EndInit()
        Me.body.ResumeLayout(False)
        CType(Me.iTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.iDetail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents body As Telerik.WinControls.UI.RadPanel
    Friend WithEvents iTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents iDetail As Telerik.WinControls.UI.RadLabel
    Friend WithEvents iClose As System.Windows.Forms.Label

End Class
