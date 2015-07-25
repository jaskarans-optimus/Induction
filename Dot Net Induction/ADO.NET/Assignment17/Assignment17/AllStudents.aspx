<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AllStudents.aspx.cs" Inherits="Assignment17.AllStudents" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Status" Text="" runat="server"></asp:Label>
    </div>
    <div style="margin:0 auto 0 auto; width:750px;">
      <asp:ListBox ID="StreamList" AutoPostBack="true"  runat="server" Rows="6" OnSelectedIndexChanged="StreamList_SelectedIndexChanged"></asp:ListBox>
      </div >
    <div style="margin:0 auto 0 auto;">
        <asp:GridView ID="StudentGrid" runat="server" AutoGenerateColumns="true" AllowPaging="True" PageSize="5" OnPageIndexChanging="gridView_PageIndexChanging"></asp:GridView>
    </div>
</asp:Content>