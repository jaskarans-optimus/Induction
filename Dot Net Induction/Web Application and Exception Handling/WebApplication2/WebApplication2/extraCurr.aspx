<%@ Page Language="C#" MasterPageFile = "~/SiteTemplate.master" AutoEventWireup="true" CodeBehind="extraCurr.aspx.cs" Inherits="WebApplication2.extraCurr" %>

<asp:Content ID = "Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat = "Server">

        <div>
            <h1>Extra Circular Acitivites</h1>
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
            <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" />

        </div>

</asp:Content>