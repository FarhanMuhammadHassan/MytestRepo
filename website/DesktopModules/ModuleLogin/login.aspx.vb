Imports IC
Partial Class DesktopModules_ModuleLogin_login
    Inherits System.Web.UI.Page

   
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ReprlyfromEmailSendingRequestedfromloginPage As String = EmailSending.checkingEmailSending() _
                                                                   .ToString() & " From (Login Page)"
        Response.Write(ReprlyfromEmailSendingRequestedfromloginPage)

    End Sub

    Protected Sub btnDefaultPage_Click(sender As Object, e As EventArgs) Handles btnDefaultPage.Click
        Response.Redirect("~/default.aspx")


    End Sub

End Class
