<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintBooks
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBoxPrintBooks = New System.Windows.Forms.GroupBox()
        Me.ListBoxBooksPrint = New System.Windows.Forms.ListBox()
        Me.BtnAddBooksPrint = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxPrintBooks.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxPrintBooks
        '
        Me.GroupBoxPrintBooks.Controls.Add(Me.ListBoxBooksPrint)
        Me.GroupBoxPrintBooks.Location = New System.Drawing.Point(26, 35)
        Me.GroupBoxPrintBooks.Name = "GroupBoxPrintBooks"
        Me.GroupBoxPrintBooks.Size = New System.Drawing.Size(452, 224)
        Me.GroupBoxPrintBooks.TabIndex = 0
        Me.GroupBoxPrintBooks.TabStop = False
        Me.GroupBoxPrintBooks.Text = "Select A Print Book"
        '
        'ListBoxBooksPrint
        '
        Me.ListBoxBooksPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxBooksPrint.FormattingEnabled = True
        Me.ListBoxBooksPrint.ItemHeight = 18
        Me.ListBoxBooksPrint.Items.AddRange(New Object() {"I Did it Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus in One Day (Print)", "Feel the Stress (Print)"})
        Me.ListBoxBooksPrint.Location = New System.Drawing.Point(35, 45)
        Me.ListBoxBooksPrint.Name = "ListBoxBooksPrint"
        Me.ListBoxBooksPrint.Size = New System.Drawing.Size(382, 130)
        Me.ListBoxBooksPrint.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ListBoxBooksPrint, "List of audio books to choose from")
        '
        'BtnAddBooksPrint
        '
        Me.BtnAddBooksPrint.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnAddBooksPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddBooksPrint.Location = New System.Drawing.Point(78, 296)
        Me.BtnAddBooksPrint.Name = "BtnAddBooksPrint"
        Me.BtnAddBooksPrint.Size = New System.Drawing.Size(146, 70)
        Me.BtnAddBooksPrint.TabIndex = 1
        Me.BtnAddBooksPrint.Text = "&Add Book to Cart"
        Me.ToolTip1.SetToolTip(Me.BtnAddBooksPrint, "Adds selected book to cart")
        Me.BtnAddBooksPrint.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(249, 296)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(146, 70)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Closes Print Books window ")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PrintBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(505, 398)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnAddBooksPrint)
        Me.Controls.Add(Me.GroupBoxPrintBooks)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PrintBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Books(Print)"
        Me.GroupBoxPrintBooks.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxPrintBooks As GroupBox
    Friend WithEvents ListBoxBooksPrint As ListBox
    Friend WithEvents BtnAddBooksPrint As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
