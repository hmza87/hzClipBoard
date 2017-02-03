Public Class lstitem
    Public Property Title As String
        Get
            Return iTitle.Text
        End Get
        Set(value As String)
            iTitle.Text = value
        End Set
    End Property
    Public Property Detail As String
        Get
            Return iDetail.Text
        End Get
        Set(value As String)
            iDetail.Text = value
        End Set
    End Property
    Sub init()
        Me.Dock = DockStyle.Top
    End Sub
    Private Sub iTitle_Click(sender As Object, e As EventArgs) Handles iTitle.Click

    End Sub

    Private Sub lstitem_Load(sender As Object, e As EventArgs) Handles Me.Load
        init()
    End Sub
End Class
