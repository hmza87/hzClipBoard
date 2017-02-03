Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 0 To 5
            Dim n As New lstitem
            n.Title = "Item " & i
            n.Detail = "0" & i * 4 & " Detail"
            lst.Items.Add(n)
        Next
        lst.init()
    End Sub


    Private Function showAlert(title As String, cntent As String)
        With RadDesktopAlert1
            .CaptionText = title
            .ContentText = cntent
            .ThemeName = VisualStudio2012DarkTheme1.ThemeName
            .Show()
        End With



    End Function

    Private Sub lst_Click(sender As Object, e As EventArgs) Handles lst.Click

    End Sub

    Private Sub lst_Load(sender As Object, e As EventArgs) Handles lst.Load

    End Sub
End Class
