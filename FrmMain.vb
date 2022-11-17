Public Class FrmMain
    Private Sub PrintBooksToolStrip_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStrip.Click
        'Hides Main form and shows PrintBooks form
        Me.Hide()
        FrmPrint.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes Application when exit is clicked
        Me.Close()
    End Sub

    Private Sub HelpToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles HelpToolStripAbout.Click
        'Shows AboutBox when clicked 
        FrmAbout.Visible = True
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        'If statement prevents error when user click remove and the listbox is empty 
        If ListCart.SelectedIndex() >= 0 Then
            CheckString = ListCart.SelectedItem.ToString()

            'lines 27-34 checks to see if an audio or print book was selected, if "(Print)" was found
            'then TotalShipping is subtracted by 2 and BookPrice finds the books title
            'and associated price and then subracts that price from Subtotal.
            'Same thing happens for "(Audio)" but not calculation for shipping 
            If CStr(CheckString).Contains("(Print)") Then
                TotalShipping = TotalShipping - ShippingCost
                SubTotal = SubTotal - BookPrice(ListCart.SelectedItem.ToString(), PrintSelect)

            ElseIf CStr(CheckString).Contains("(Audio)") Then
                SubTotal = SubTotal - BookPrice(ListCart.SelectedItem.ToString(), AudioSelect)

            End If

            Tax = TaxCalc(SubTotal)

            Total = Tax + SubTotal + TotalShipping

            ListCart.Items.RemoveAt(ListCart.SelectedIndex)

            'displays charges to respective lbl's
            LblSubtotal_Amount.Text = SubTotal.ToString("c")
            lblShipping_Amount.Text = TotalShipping.ToString("c")
            lblTax_Amount.Text = Tax.ToString("c")
            lblTotal_Amount.Text = Total.ToString("c")

        End If
    End Sub

    Private Sub AudioBooksToolS_Click(sender As Object, e As EventArgs) Handles AudioBooksToolS.Click
        'Displays AudioBook form
        Me.Hide()
        FrmAudioBooks.Visible = True
    End Sub

    Private Sub ToolmenuReset_Click(sender As Object, e As EventArgs) Handles ToolmenuReset.Click
        'Resets all field to empty
        ListCart.Items.Clear()
        LblSubtotal_Amount.Text = ""
        lblShipping_Amount.Text = ""
        lblTax_Amount.Text = ""
        lblTotal_Amount.Text = ""
        Me.Visible = True
    End Sub
End Class
