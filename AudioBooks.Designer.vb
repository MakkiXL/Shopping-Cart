<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioBooks
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
        Me.GroupBoxAudio = New System.Windows.Forms.GroupBox()
        Me.ListAudioBooks = New System.Windows.Forms.ListBox()
        Me.BtnAddBookAudio = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxAudio.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxAudio
        '
        Me.GroupBoxAudio.Controls.Add(Me.ListAudioBooks)
        Me.GroupBoxAudio.Location = New System.Drawing.Point(26, 35)
        Me.GroupBoxAudio.Name = "GroupBoxAudio"
        Me.GroupBoxAudio.Size = New System.Drawing.Size(452, 224)
        Me.GroupBoxAudio.TabIndex = 0
        Me.GroupBoxAudio.TabStop = False
        Me.GroupBoxAudio.Text = "Select an Audio Book"
        '
        'ListAudioBooks
        '
        Me.ListAudioBooks.FormattingEnabled = True
        Me.ListAudioBooks.ItemHeight = 16
        Me.ListAudioBooks.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scottland (Audio)", "The Science of Body Language (Audio)"})
        Me.ListAudioBooks.Location = New System.Drawing.Point(35, 45)
        Me.ListAudioBooks.Name = "ListAudioBooks"
        Me.ListAudioBooks.Size = New System.Drawing.Size(382, 116)
        Me.ListAudioBooks.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ListAudioBooks, "List of audio books to choose from")
        '
        'BtnAddBookAudio
        '
        Me.BtnAddBookAudio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnAddBookAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddBookAudio.Location = New System.Drawing.Point(78, 296)
        Me.BtnAddBookAudio.Name = "BtnAddBookAudio"
        Me.BtnAddBookAudio.Size = New System.Drawing.Size(146, 70)
        Me.BtnAddBookAudio.TabIndex = 1
        Me.BtnAddBookAudio.Text = "&Add Book to Cart"
        Me.ToolTip1.SetToolTip(Me.BtnAddBookAudio, "Adds selected book to cart")
        Me.BtnAddBookAudio.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(249, 296)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(146, 70)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Closes Audio Books window ")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'AudioBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 398)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnAddBookAudio)
        Me.Controls.Add(Me.GroupBoxAudio)
        Me.Name = "AudioBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BooksAudio"
        Me.GroupBoxAudio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxAudio As GroupBox
    Friend WithEvents ListAudioBooks As ListBox
    Friend WithEvents BtnAddBookAudio As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolTip1 As ToolTip
End Class
