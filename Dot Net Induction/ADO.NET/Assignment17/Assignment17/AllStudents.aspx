<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AllStudents.aspx.cs" Inherits="Assignment17.AllStudents" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Status" Text="" runat="server"></asp:Label>
    </div>
    <div style="margin:0 auto 0 auto; width:750px;">
      <asp:ListBox ID="StreamList" AutoPostBack="true"  runat="server" Rows="6" OnSelectedIndexChanged="StreamList_SelectedIndexChanged"></asp:ListBox>
      </div >
    <div style="margin:0 auto 0 auto;">
        <asp:GridView ID="StudentGrid" runat="server" AllowPaging="True" PageSize="5" OnPageIndexChanging="gridView_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="true" OnSorting="StudentGrid_Sorting">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
    <br />
    <br />

</asp:Content>