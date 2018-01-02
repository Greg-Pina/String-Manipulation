Public Class frmStrings

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        ' example manipulation techniques.  
        ' Can only be ran one technique at a time.  Uncomment each technique to run.  
        ' Make sure rest of techniques are commented out. 

        Dim strString1 As String
        Dim strString2 As String
        Dim intResult As Integer

        '
        'Length Property  (Put Elvis Presley in txtString1.Text)
        '
        intResult = Me.txtString1.Text.Length
        Me.lblResult.Text = intResult
        '
        '============================================================
        '
        'Trim Method  (Put '   Elvis Presley' in txtString1.Text)
        '
        strString1 = Me.txtString1.Text
        Me.lblResult.Text = strString1.Trim
        '
        '============================================================
        '
        'TrimStart Method  (Put $1000 in txtString1.Text)
        '
        'strString1 = Me.txtString1.Text
        'Me.lblResult.Text = strString1.TrimStart("$")
        '
        ''============================================================
        ''
        ''TrimEnd Method  (Put 10% in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'Me.lblResult.Text = strString1.TrimEnd("%")
        ''
        ''============================================================
        ''
        ''Remove Method  (Put Elvis Presley in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'Me.lblResult.Text = strString1.Remove(0, 6)
        ''
        ''============================================================
        ''
        ''Replace Method  (Put Bob Hope in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'Me.lblResult.Text = strString1.Replace("Bob", "Robert")
        ''
        ''============================================================
        ''
        ''Mid Statement  (Put Elvis Presley in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'Mid(strString1, 1) = "Lisa"
        'Me.lblResult.Text = strString1
        ''
        ''============================================================
        ''
        ''PadLeft Method  (Put $1,000 in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'Me.lblResult.Text = strString1.PadLeft(15, "*")
        ''
        ''============================================================
        ''
        ''PadRight Method  (Put Elvis in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'Me.lblResult.Text = strString1.PadRight(15, ".")
        ''
        ''============================================================
        ''
        ''Insert Method  (Put Elvis Presley in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'Me.lblResult.Text = strString1.Insert(6, "(The King) ")
        ''
        ''============================================================
        ''
        ''StartsWith Method  (Put (606)282-1123 in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'If strString1.StartsWith("(606)") Then
        '    Me.lblResult.Text = "Kentucky Area Code"
        'Else
        '    Me.lblResult.Text = "Not Kentucky Area Code"
        'End If
        ''
        ''============================================================
        ''
        ''EndsWith Method  (Put Florence, Ky in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'If strString1.EndsWith("Ky") Then
        '    Me.lblResult.Text = "Kentucky, a Great State"
        'Else
        '    Me.lblResult.Text = "Not Kentucky"
        'End If
        ''
        ''============================================================
        ''
        ''Contains Method  (Put John.Doe@yahoo.com in txtString1.Text)
        '
        'strString1 = Me.txtString1.Text
        'If strString1.Contains("@") Then
        '    Me.lblResult.Text = "Good Email Address"
        'Else
        '    Me.lblResult.Text = "Bad Email Address"
        'End If
        ''
        ''============================================================
        ''
        ''IndexOf Method  (Put John.Doe@yahoo.com in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'If strString1.IndexOf("@") = -1 Then
        '    Me.lblResult.Text = "Bad Email Address"
        'Else
        '    Me.lblResult.Text = "Good Email Address"
        'End If
        ''
        ''============================================================
        ''
        ''IndexOf Method  (Put John.Doe@yahoo.com in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'Me.lblResult.Text = strString1.IndexOf("@")
        ''
        ''============================================================
        ''
        ''Substring Method  (Put Elvis Presley in txtString1.Text)
        ''
        'strString1 = Me.txtString1.Text
        'Me.lblResult.Text = strString1.Substring(0, 5)
        ''
        ''============================================================
        ''
        ''String Compare  (Put Dallas in txtString1.Text)
        ''                (Put dallas in txtString2.text
        ''
        'strString1 = Me.txtString1.Text
        'strString2 = Me.txtString2.Text
        'Me.lblResult.Text = String.Compare(strString1, strString2)
        ''
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
