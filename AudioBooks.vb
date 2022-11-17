Public Class AudioBooks
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAddBookAudio.Click
        'prevents error on Btn  click for empty listbox
        If ListAudioBooks.SelectedIndex >= 0 Then

            SubTotal += BookPrice(ListAudioBooks.SelectedItem.ToString(), AudioSelect)
            StrBook = AddToCheckout(ListAudioBooks.SelectedItem().ToString)
            FrmMain.ListCart.Items.Add(StrBook)
            Tax = TaxCalc(SubTotal)
            Total = Tax + SubTotal

            'Displays respective lbl's
            FrmMain.LblSubtotal_Amount.Text = SubTotal.ToString("c")
            FrmMain.lblShipping_Amount.Text = TotalShipping.ToString("c")
            FrmMain.lblTax_Amount.Text = Tax.ToString("c")
            FrmMain.lblTotal_Amount.Text = Total.ToString("c")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'Hides form 
        Me.Hide()
        FrmMain.Visible = True
    End Sub
End Class