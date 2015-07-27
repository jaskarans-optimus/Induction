<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteStudents.aspx.cs" Inherits="Assignment17.DeleteStudents" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        Status:<asp:Label runat="server" ID="Status" Text=""></asp:Label>
    </div>
    <div>
        <asp:DropDownList runat="server" ID="Streams" OnSelectedIndexChanged="Streams_SelectedIndexChanged" AutoPostBack="true" ></asp:DropDownList>
    </div>
    <div>
        <asp:ListBox ID="LeftList" runat="server" SelectionMode="Multiple" ToolTip="Left Student List"></asp:ListBox>
        &nbsp;
        <asp:Button ID="Left" runat="server" Text="<-" OnClick="Left_Click" />
        &nbsp;
        <asp:Button ID="Right" runat="server" Text="->" OnClick="Right_Click" />
        &nbsp;
        <asp:ListBox ID="RightList" runat="server" SelectionMode="Multiple" ToolTip="Right Student List"></asp:ListBox>

    </div>
    <div>
        <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" OnClientClick="return confirm('Do you want to Delete Selected Students?');" />
    </div>
    </div>
</asp:Content>
