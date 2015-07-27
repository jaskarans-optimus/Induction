<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadingCSV.aspx.cs" Inherits="Assignment21.ReadingCSV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblUploadStatus" runat="server" Text=""></asp:Label>
        <br />

        <asp:Label ID="lblDatabaseStatus" runat="server" Text=""></asp:Label>
    <div>
        <asp:FileUpload ID="UploadStudentCSV" runat="server" />
        <br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="SaveStudentToDB" />
    </div>
    </form>
</body>
</html>
