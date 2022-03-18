Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        String Text = "Hello";
        System.IO.File.WriteAllText(@'E:\MVCExampleLogs');

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
