Imports Telerik.WinControls

Public Class Listitems
    Private lst As New Collection
    Public Property Items As Collection
        Get
            Return lst

        End Get
        Set(value As Collection)
            lst = value
            init()
        End Set
    End Property

    Public Sub init()
        Dim c = lst.Count
        body.Controls.Clear()
        For Each l As lstitem In lst
            Dim n As New lstitem
            n = l
            body.Controls.Add(l)
        Next
    End Sub

    Private Sub body_PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles body.PanelContainer.Paint

    End Sub
End Class
