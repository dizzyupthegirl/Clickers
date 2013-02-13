
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            ShowList()
        End If

    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As System.EventArgs) Handles btnAdd.Click
        Dim q As New dsTableAdapters.QueriesTableAdapter
        q.spAddDepartment(txtDepartmentName.Text)
        ShowList()
    End Sub

    Protected Sub btnToggleActive_Click(sender As Object, e As System.EventArgs) Handles btnToggleActive.Click
        Dim q As New dsTableAdapters.QueriesTableAdapter
        q.spToggleDepartmentActive(lstDepartments.SelectedItem.Value)
        ShowList()
    End Sub

    Protected Sub btnDeleteDepartment_Click(sender As Object, e As System.EventArgs) Handles btnDeleteDepartment.Click
        Dim q As New dsTableAdapters.QueriesTableAdapter
        q.spDeleteDepartment(lstDepartments.SelectedItem.Value)
        ShowList()
    End Sub

    Private Sub ShowList()
        Dim tbl As New dsTableAdapters.spGetDepartmentListTableAdapter
        Dim rs As ds.spGetDepartmentListRow
        Dim li As ListItem

        lstDepartments.Items.Clear()

        For Each rs In tbl.GetData
            li = New ListItem(rs.DepartmentName & IIf(Not rs.Active, " (inactive)", ""), rs.DepartmentKey)
            lstDepartments.Items.Add(li)
        Next

        tbl.Dispose()
        tbl = Nothing
        rs = Nothing
    End Sub

End Class
