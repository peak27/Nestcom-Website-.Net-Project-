<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Nestcom</title>
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/bootstrap.css" rel="stylesheet" />
    <link href="~/CSS/homepage.css" rel="stylesheet" />
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
    <link href="~/CSS/homepage.css" rel="stylesheet" />
    <link href="~/CSS/About.css" rel="stylesheet" />
    <link href="~/CSS/main.css" rel="stylesheet" />
    <link href="~/CSS/normalize.css" rel="stylesheet" />
    @*@Styles.Render("~/Content/css")
        @Scripts.Render("~/bundles/modernizr")*@
</head>


<body>
    <div class="nheader">
        <div class="headimage">
            <img src="~/Images/NesLogo.png" alt="Nestcom"class="img-responsive mlogo" width="200px" height="100px" />
            <h1 style="font-size:65px; font-family:fantasy; "> <b>Nepalese Student Community</b></h1>
        </div>
     </div>
        <div class="navbar big ">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <span style="color:midnightblue"> @Html.ActionLink("Nestcom", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})</span>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li>@Html.ActionLink("Home", "Index", "Home")</li>
                        <li>@Html.ActionLink("About", "About", "Home")</li>
                        <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                        <li>@Html.ActionLink("Nepal", "Nepal", "Home")</li>
                    </ul>
                </div>
            </div>
        </div>

        
   

        <div class="container body-content">
            

            @RenderBody()
            <hr />
            <footer style="text-align:center;">
                <p>&copy; @DateTime.Now.Year - Team Nepal Mankato</p>
            </footer>
        </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
