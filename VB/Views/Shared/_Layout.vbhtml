<!DOCTYPE html>

<html>
<head>
    <title>@ViewBag.Title</title>

    @Html.DevExpress().GetStyleSheets(
    new StyleSheet With { .ExtensionSuite = ExtensionSuite.NavigationAndLayout },
    new StyleSheet With { .ExtensionSuite = ExtensionSuite.Editors },
    new StyleSheet With { .ExtensionSuite = ExtensionSuite.GridView }
)
    <script src="~/Scripts/jquery-2.1.4.min.js"></script>
    @Html.DevExpress().GetScripts(
    new Script With { .ExtensionSuite = ExtensionSuite.NavigationAndLayout },
     new Script With { .ExtensionSuite = ExtensionSuite.GridView },
     new Script With { .ExtensionSuite = ExtensionSuite.Editors }
)
</head>

<body>
    @RenderBody()
</body>
</html>
