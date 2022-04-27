<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.AboutPictureBox = New System.Windows.Forms.PictureBox()
        Me.AboutLabel = New System.Windows.Forms.Label()
        CType(Me.AboutPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AboutPictureBox
        '
        Me.AboutPictureBox.Image = CType(resources.GetObject("AboutPictureBox.Image"), System.Drawing.Image)
        Me.AboutPictureBox.Location = New System.Drawing.Point(12, 68)
        Me.AboutPictureBox.Name = "AboutPictureBox"
        Me.AboutPictureBox.Size = New System.Drawing.Size(268, 185)
        Me.AboutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AboutPictureBox.TabIndex = 0
        Me.AboutPictureBox.TabStop = False
        '
        'AboutLabel
        '
        Me.AboutLabel.AutoSize = True
        Me.AboutLabel.Location = New System.Drawing.Point(12, 26)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(161, 39)
        Me.AboutLabel.TabIndex = 1
        Me.AboutLabel.Text = "Stan's Grocery By Carson Bogart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VB 4/27/22" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Spring 22"
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 265)
        Me.Controls.Add(Me.AboutLabel)
        Me.Controls.Add(Me.AboutPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AboutForm"
        Me.Text = "AboutForm"
        CType(Me.AboutPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AboutPictureBox As PictureBox
    Friend WithEvents AboutLabel As Label
End Class
