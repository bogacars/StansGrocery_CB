<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGrocery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StansGrocery))
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.CategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.AisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboFilterLabel = New System.Windows.Forms.Label()
        Me.FilterGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(12, 47)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(172, 20)
        Me.SearchTextBox.TabIndex = 0
        Me.MainToolTip.SetToolTip(Me.SearchTextBox, "Enter desired product")
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(12, 31)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(41, 13)
        Me.SearchLabel.TabIndex = 1
        Me.SearchLabel.Text = "Search"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(199, 47)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(55, 22)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Search"
        Me.MainToolTip.SetToolTip(Me.SearchButton, "Press to search ")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.CategoryRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.AisleRadioButton)
        Me.FilterGroupBox.Location = New System.Drawing.Point(15, 85)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(114, 102)
        Me.FilterGroupBox.TabIndex = 3
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filters"
        '
        'CategoryRadioButton
        '
        Me.CategoryRadioButton.AutoSize = True
        Me.CategoryRadioButton.Location = New System.Drawing.Point(6, 69)
        Me.CategoryRadioButton.Name = "CategoryRadioButton"
        Me.CategoryRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.CategoryRadioButton.TabIndex = 1
        Me.CategoryRadioButton.TabStop = True
        Me.CategoryRadioButton.Text = "Filter By Category"
        Me.MainToolTip.SetToolTip(Me.CategoryRadioButton, "Select to filter by category")
        Me.CategoryRadioButton.UseVisualStyleBackColor = True
        '
        'AisleRadioButton
        '
        Me.AisleRadioButton.AutoSize = True
        Me.AisleRadioButton.Location = New System.Drawing.Point(6, 30)
        Me.AisleRadioButton.Name = "AisleRadioButton"
        Me.AisleRadioButton.Size = New System.Drawing.Size(87, 17)
        Me.AisleRadioButton.TabIndex = 0
        Me.AisleRadioButton.TabStop = True
        Me.AisleRadioButton.Text = "Filter By Aisle"
        Me.MainToolTip.SetToolTip(Me.AisleRadioButton, "Select to filter by aisle")
        Me.AisleRadioButton.UseVisualStyleBackColor = True
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(135, 85)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(245, 290)
        Me.DisplayListBox.TabIndex = 4
        Me.MainToolTip.SetToolTip(Me.DisplayListBox, "Shows searched products")
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(389, 24)
        Me.TopMenuStrip.TabIndex = 5
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(110, 48)
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem1.Text = "Search"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'FilterComboBox
        '
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(7, 218)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FilterComboBox.TabIndex = 6
        '
        'ComboFilterLabel
        '
        Me.ComboFilterLabel.AutoSize = True
        Me.ComboFilterLabel.Location = New System.Drawing.Point(9, 202)
        Me.ComboFilterLabel.Name = "ComboFilterLabel"
        Me.ComboFilterLabel.Size = New System.Drawing.Size(47, 13)
        Me.ComboFilterLabel.TabIndex = 7
        Me.ComboFilterLabel.Text = "Filter By:"
        '
        'StansGrocery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 392)
        Me.Controls.Add(Me.ComboFilterLabel)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchLabel)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "StansGrocery"
        Me.Text = "Stans Grocery"
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents CategoryRadioButton As RadioButton
    Friend WithEvents AisleRadioButton As RadioButton
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents SearchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents ComboFilterLabel As Label
End Class
