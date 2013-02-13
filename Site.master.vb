
Partial Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        With HttpContext.Current.User


            '  If (Not .IsInRole("Student")) Then NavigationMenu.Items.Remove(NavigationMenu.FindItem("Student"))


        End With

    End Sub

    Protected Sub NavigationMenu_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles NavigationMenu.MenuItemClick

    End Sub
End Class

