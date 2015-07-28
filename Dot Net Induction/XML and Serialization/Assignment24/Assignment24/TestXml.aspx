<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestXml.aspx.cs" Inherits="Assignment24.TestXml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblStatus" Text="" runat="server" ></asp:Label>
    </div>
      <div>
          <br />
          <br />
          <asp:Button ID="btnAddNode" runat="server" Text="Add Node" OnClick="AddNode_Click"/>
      </div>
        <br />
        <br />
        <div>
            <asp:Button ID="btnInsertNode" runat="server" Text="Insert Node" OnClick="btnInsertNode_Click" />
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="btnRemoveNode" runat="server" Text="Remove Node" OnClick="btnRemoveNode_Click" />
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="btnChildNodes" runat="server" Text="Child Nodes" OnClick="btnChildNodes_Click" />
            <asp:TextBox ID="txtChildNodes" runat="server" Text="" ></asp:TextBox>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="btnTotalNodes" runat="server" Text="Total Nodes" OnClick="btnTotalNodes_Click"  />
            <asp:Label ID="lblTotalNodes" runat="server" Text="" ></asp:Label>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="btnReplaceChild" runat="server" Text="Replace child" OnClick="btnReplaceChild_Click" />
        </div>
    </form>
</body>
</html>
