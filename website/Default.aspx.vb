Imports IC
Partial Class _Default
    Inherits System.Web.UI.Page
   


  
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim objIC As ClassOfIC = New ClassOfIC()
        Dim Stringvalue As String = ClassOfIC.testvalue()
        Dim ValueFromEmailSending As String = EmailSending.checkingEmailSending() & "<br/>"
        Response.Write(ValueFromEmailSending.ToString())
        Response.Write(Stringvalue.ToString())

    End Sub


    Protected Sub btnLoginPage_Click(sender As Object, e As EventArgs) Handles btnLoginPage.Click
        'Response.Redirect("D:\TestProject\MyProject\MyNex\website\DesktopModules\ModuleLogin\login.aspx")
        Response.Redirect("~/desktopModules/ModuleLogin/login.aspx")
    End Sub
End Class
