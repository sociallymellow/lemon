﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fScreenshot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fScreenshot))
        Me.bScreenshot = New System.Windows.Forms.Button()
        Me.bSave = New System.Windows.Forms.Button()
        Me.tbSave = New System.Windows.Forms.TextBox()
        Me.picScreenshot = New System.Windows.Forms.PictureBox()
        Me.save = New System.Windows.Forms.SaveFileDialog()
        CType(Me.picScreenshot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bScreenshot
        '
        Me.bScreenshot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bScreenshot.BackgroundImage = Global.Lemon.My.Resources.Resources.camera
        Me.bScreenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bScreenshot.ForeColor = System.Drawing.SystemColors.Control
        Me.bScreenshot.Location = New System.Drawing.Point(13, 290)
        Me.bScreenshot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bScreenshot.Name = "bScreenshot"
        Me.bScreenshot.Size = New System.Drawing.Size(32, 32)
        Me.bScreenshot.TabIndex = 12
        Me.bScreenshot.UseVisualStyleBackColor = True
        '
        'bSave
        '
        Me.bSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSave.BackgroundImage = Global.Lemon.My.Resources.Resources.save
        Me.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSave.ForeColor = System.Drawing.SystemColors.Control
        Me.bSave.Location = New System.Drawing.Point(460, 290)
        Me.bSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(32, 32)
        Me.bSave.TabIndex = 13
        Me.bSave.UseVisualStyleBackColor = True
        '
        'tbSave
        '
        Me.tbSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbSave.Location = New System.Drawing.Point(253, 296)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(200, 20)
        Me.tbSave.TabIndex = 14
        Me.tbSave.Text = "screenshot"
        Me.tbSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picScreenshot
        '
        Me.picScreenshot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picScreenshot.BackColor = System.Drawing.SystemColors.Window
        Me.picScreenshot.Location = New System.Drawing.Point(12, 12)
        Me.picScreenshot.Name = "picScreenshot"
        Me.picScreenshot.Size = New System.Drawing.Size(480, 270)
        Me.picScreenshot.TabIndex = 15
        Me.picScreenshot.TabStop = False
        '
        'fScreenshot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 328)
        Me.Controls.Add(Me.picScreenshot)
        Me.Controls.Add(Me.tbSave)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bScreenshot)
        Me.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "fScreenshot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "screenshot"
        Me.TopMost = True
        CType(Me.picScreenshot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bScreenshot As System.Windows.Forms.Button
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents tbSave As System.Windows.Forms.TextBox
    Friend WithEvents picScreenshot As System.Windows.Forms.PictureBox
    Friend WithEvents save As System.Windows.Forms.SaveFileDialog
End Class
