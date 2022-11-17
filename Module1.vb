Public Module Module1
    'lines 3-6 have instances to control the various forms
    Public FrmMain As New FrmMain
    Public FrmPrint As New PrintBooks
    Public FrmAbout As New AboutBox
    Public FrmAudioBooks As New AudioBooks

    'Holds the selected Item for Audiobooks and PrintBooks
    Public StrBook As String

    'lines 12-16 are varibles used for the cost calculations 
    Public Tax As Double
    Public Total As Double
    Public Const ShippingCost As Integer = 2
    Public SubTotal As Double
    Public TotalShipping As Integer = 0

    'PrintBooks & AudioBooks holds the value for audio and print books in BookPrice function
    'CheckString holds SelectedIndex.ToString for removing a book
    Public PrintBooks As Double
    Public AudioBooks As Double
    Public CheckString As String

    'PrintSelect & AudioSelect are used to determine the return value for BookPrice function 
    Public PrintSelect As Integer = 0
    Public AudioSelect As Integer = 1

    'takes SelectedIndex and returns it form other froms to use.
    ' whenever I Tried Strbook = listbox.SelectedItem.ToString or anything else
    ' that assigns StrBook a value it wouldnt carry over to the other forms
    Function AddToCheckout(ByVal BookTitle As String) As String
        Return BookTitle
    End Function


    'find out which book user selected and which price to assign the book
    Function BookPrice(bookcost As String, ByVal bookselection As Integer) As Double

        If CStr(bookcost).Contains("I Did it Your Way (Print)") Or CStr(bookcost).Contains("Learn Calculus in One Day (Audio)") Then
            PrintBooks = 11.95
            AudioBooks = 29.95
        ElseIf CStr(bookcost).Contains("The History of Scotland (Print)") Or CStr(bookcost).Contains("Relaxation Techniques (Audio)") Then
            PrintBooks = 14.5
            AudioBooks = 14.5
        ElseIf CStr(bookcost).Contains("Learn Calculus in One Day (Print)") Or CStr(bookcost).Contains("The History Of Scottland (Audio)") Then
            PrintBooks = 29.95
            AudioBooks = 12.95
        ElseIf CStr(bookcost).Contains("the Stress (Print)") Or CStr(bookcost).Contains("The Science of Body Language (Audio)") Then
            PrintBooks = 18.5
            AudioBooks = 11.5
        End If

        If bookselection = 0 Then
            Return PrintBooks

        ElseIf bookselection = 1 Then

            Return AudioBooks
        End If
    End Function

    'The TaxCalc function calculates tax and returns the value 
    Function TaxCalc(Subtotal As Double) As Double
        Tax = (0.06 * Subtotal)
        Return Tax
    End Function

End Module
