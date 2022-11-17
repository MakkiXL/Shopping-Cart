<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.GBProductsSelected = New System.Windows.Forms.GroupBox()
        Me.ListCart = New System.Windows.Forms.ListBox()
        Me.lblTotal_Amount = New System.Windows.Forms.Label()
        Me.lblTax_Amount = New System.Windows.Forms.Label()
        Me.lblShipping_Amount = New System.Windows.Forms.Label()
        Me.LblSubtotal_Amount = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolmenuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintBooksToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioBooksToolS = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GBProductsSelected.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBProductsSelected
        '
        Me.GBProductsSelected.Controls.Add(Me.ListCart)
        Me.GBProductsSelected.Controls.Add(Me.lblTotal_Amount)
        Me.GBProductsSelected.Controls.Add(Me.lblTax_Amount)
        Me.GBProductsSelected.Controls.Add(Me.lblShipping_Amount)
        Me.GBProductsSelected.Controls.Add(Me.LblSubtotal_Amount)
        Me.GBProductsSelected.Controls.Add(Me.lblSubTotal)
        Me.GBProductsSelected.Controls.Add(Me.lblTax)
        Me.GBProductsSelected.Controls.Add(Me.lblShipping)
        Me.GBProductsSelected.Controls.Add(Me.lblTotal)
        Me.GBProductsSelected.Controls.Add(Me.BtnRemove)
        Me.GBProductsSelected.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GBProductsSelected.Location = New System.Drawing.Point(24, 74)
        Me.GBProductsSelected.Name = "GBProductsSelected"
        Me.GBProductsSelected.Size = New System.Drawing.Size(745, 351)
        Me.GBProductsSelected.TabIndex = 0
        Me.GBProductsSelected.TabStop = False
        Me.GBProductsSelected.Text = "Products Selected"
        '
        'ListCart
        '
        Me.ListCart.FormattingEnabled = True
        Me.ListCart.ItemHeight = 16
        Me.ListCart.Location = New System.Drawing.Point(18, 39)
        Me.ListCart.Name = "ListCart"
        Me.ListCart.Size = New System.Drawing.Size(449, 164)
        Me.ListCart.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.ListCart, "Displays books in cart")
        '
        'lblTotal_Amount
        '
        Me.lblTotal_Amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal_Amount.Location = New System.Drawing.Point(608, 216)
        Me.lblTotal_Amount.Name = "lblTotal_Amount"
        Me.lblTotal_Amount.Size = New System.Drawing.Size(90, 27)
        Me.lblTotal_Amount.TabIndex = 13
        Me.lblTotal_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax_Amount
        '
        Me.lblTax_Amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax_Amount.Location = New System.Drawing.Point(608, 158)
        Me.lblTax_Amount.Name = "lblTax_Amount"
        Me.lblTax_Amount.Size = New System.Drawing.Size(90, 27)
        Me.lblTax_Amount.TabIndex = 12
        Me.lblTax_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblShipping_Amount
        '
        Me.lblShipping_Amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipping_Amount.Location = New System.Drawing.Point(608, 101)
        Me.lblShipping_Amount.Name = "lblShipping_Amount"
        Me.lblShipping_Amount.Size = New System.Drawing.Size(90, 27)
        Me.lblShipping_Amount.TabIndex = 11
        Me.lblShipping_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSubtotal_Amount
        '
        Me.LblSubtotal_Amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSubtotal_Amount.Location = New System.Drawing.Point(608, 42)
        Me.LblSubtotal_Amount.Name = "LblSubtotal_Amount"
        Me.LblSubtotal_Amount.Size = New System.Drawing.Size(90, 27)
        Me.LblSubtotal_Amount.TabIndex = 10
        Me.LblSubtotal_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(494, 43)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(64, 17)
        Me.lblSubTotal.TabIndex = 1
        Me.lblSubTotal.Text = "Subtotal:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(494, 168)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(35, 17)
        Me.lblTax.TabIndex = 2
        Me.lblTax.Text = "Tax:"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(494, 106)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(67, 17)
        Me.lblShipping.TabIndex = 3
        Me.lblShipping.Text = "Shipping:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(494, 221)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 17)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRemove.Location = New System.Drawing.Point(178, 270)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(138, 48)
        Me.BtnRemove.TabIndex = 5
        Me.BtnRemove.Text = "&Remove"
        Me.ToolTip1.SetToolTip(Me.BtnRemove, "Removes selected book")
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiFile, Me.ProductsToolStrip, Me.HelpToolStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MiFile
        '
        Me.MiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolmenuReset, Me.ExitToolStripMenuItem})
        Me.MiFile.Name = "MiFile"
        Me.MiFile.Size = New System.Drawing.Size(46, 26)
        Me.MiFile.Text = "&File"
        '
        'ToolmenuReset
        '
        Me.ToolmenuReset.AutoSize = False
        Me.ToolmenuReset.Name = "ToolmenuReset"
        Me.ToolmenuReset.Size = New System.Drawing.Size(224, 26)
        Me.ToolmenuReset.Text = "&Reset     Ctrl+R"
        Me.ToolmenuReset.ToolTipText = "Resets application"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.AutoSize = False
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit        Ctrl+X"
        Me.ExitToolStripMenuItem.ToolTipText = "Closes Application"
        '
        'ProductsToolStrip
        '
        Me.ProductsToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBooksToolStrip, Me.AudioBooksToolS})
        Me.ProductsToolStrip.Name = "ProductsToolStrip"
        Me.ProductsToolStrip.Size = New System.Drawing.Size(80, 26)
        Me.ProductsToolStrip.Text = "&Products"
        '
        'PrintBooksToolStrip
        '
        Me.PrintBooksToolStrip.Name = "PrintBooksToolStrip"
        Me.PrintBooksToolStrip.Size = New System.Drawing.Size(224, 26)
        Me.PrintBooksToolStrip.Text = "Print books"
        Me.PrintBooksToolStrip.ToolTipText = "Opens the print books window"
        '
        'AudioBooksToolS
        '
        Me.AudioBooksToolS.Name = "AudioBooksToolS"
        Me.AudioBooksToolS.Size = New System.Drawing.Size(224, 26)
        Me.AudioBooksToolS.Text = "Audio books"
        Me.AudioBooksToolS.ToolTipText = "Opens the audio books window"
        '
        'HelpToolStrip
        '
        Me.HelpToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripAbout})
        Me.HelpToolStrip.Name = "HelpToolStrip"
        Me.HelpToolStrip.Size = New System.Drawing.Size(55, 26)
        Me.HelpToolStrip.Text = "&Help"
        '
        'HelpToolStripAbout
        '
        Me.HelpToolStripAbout.Name = "HelpToolStripAbout"
        Me.HelpToolStripAbout.Size = New System.Drawing.Size(224, 26)
        Me.HelpToolStripAbout.Text = "About"
        Me.HelpToolStripAbout.ToolTipText = "displays application info"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GBProductsSelected)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopping Cart by Malachi Barbato"
        Me.GBProductsSelected.ResumeLayout(False)
        Me.GBProductsSelected.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBProductsSelected As GroupBox
    Friend WithEvents BtnRemove As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MiFile As ToolStripMenuItem
    Friend WithEvents ToolmenuReset As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStrip As ToolStripMenuItem
    Friend WithEvents HelpToolStrip As ToolStripMenuItem
    Friend WithEvents PrintBooksToolStrip As ToolStripMenuItem
    Friend WithEvents AudioBooksToolS As ToolStripMenuItem
    Friend WithEvents HelpToolStripAbout As ToolStripMenuItem
    Friend WithEvents LblSubtotal_Amount As Label
    Friend WithEvents lblTotal_Amount As Label
    Friend WithEvents lblTax_Amount As Label
    Friend WithEvents lblShipping_Amount As Label
    Friend WithEvents ListCart As ListBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
