<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadXml.aspx.cs" Inherits="Assignment26.UploadXml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    <div>
        <asp:Label ID="lblUpload" Text="Upload Xml File:  " runat="server" ></asp:Label>
        <asp:FileUpload ID="fuXml" runat="server" />
        <br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
    </div>
    </form>
</body>
</html>
