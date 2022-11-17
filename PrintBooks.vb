Public Class PrintBooks

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAddBooksPrint.Click

        'if statement prevents error on btn click for empty listbox
        If ListBoxBooksPrint.SelectedIndex >= 0 Then

            TotalShipping += ShippingCost
            SubTotal += BookPrice(ListBoxBooksPrint.SelectedItem.ToString(), PrintSelect)
            StrBook = AddToCheckout(ListBoxBooksPrint.SelectedItem().ToString)
            FrmMain.ListCart.Items.Add(StrBook)

            Tax = TaxCalc(SubTotal)
            Total = Tax + SubTotal + TotalShipping

            'Displays charges to respective lbls's
            FrmMain.LblSubtotal_Amount.Text = SubTotal.ToString("c")
            FrmMain.lblShipping_Amount.Text = TotalShipping.ToString("c")
            FrmMain.lblTax_Amount.Text = Tax.ToString("c")
            FrmMain.lblTotal_Amount.Text = Total.ToString("c")
        End If
    End Sub


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'Hides form
        Me.Hide()
        FrmMain.Visible = True
    End Sub
End Class