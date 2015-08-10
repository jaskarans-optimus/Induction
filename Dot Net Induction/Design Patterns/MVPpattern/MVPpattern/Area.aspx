<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Area.aspx.cs" Inherits="MVPpattern.Area" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblRadius" Text="Enter Radius:" runat="server"></asp:Label>
        <asp:TextBox ID="txtRadius" runat="server" ></asp:TextBox>
    </div>
        <div>
            Result:
            <asp:Label id="lblResult" runat="server" ForeColo="red"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnResult" runat="server" Text="Get Result" OnClick="ButtonResult_Click" />
        </div>
    </form>
</body>
</html>
