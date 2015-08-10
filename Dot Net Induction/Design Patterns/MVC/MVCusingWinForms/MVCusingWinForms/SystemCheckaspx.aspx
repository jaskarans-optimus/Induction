<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SystemCheckaspx.aspx.cs" Inherits="MVCusingWinForms.SystemCheckaspx" %>
<%@ Register Src="~/Views/SystemView.ascx" TagPrefix="uc3" TagName="System" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        body {
            font-family:Verdana;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="border:1px solid; width:500px; height:500px; margin:auto auto;">
        <uc3:System runat="server" id="systemd" />
    </div>
    </form>
</body>
</html>
