<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadFile.aspx.cs" Inherits="Assignment23.UploadFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Label ID="lblStatus" runat="server"></asp:Label>
    <form id="form1" runat="server">
    <div>

    <asp:TextBox ID="txtPath" runat="server" Text=""></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    </div>
    </form>
</body>
</html>
