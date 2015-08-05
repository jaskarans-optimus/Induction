<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Percentage.aspx.cs" Inherits="SampleWebApp.Percentage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" Text="Enter the Percentage:" ID="lblPercentage"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="txtPercentage" > </asp:TextBox>
        <br />
        <asp:Button Text="Submit" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
