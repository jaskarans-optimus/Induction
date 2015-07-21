<%@ Page Language="C#" MasterPageFile = "~/SiteTemplate.master" AutoEventWireup="true" CodeBehind="techNews.aspx.cs" Inherits="WebApplication2.techNews" %>

<asp:Content ID = "Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat = "Server">
    <div>
        <h1>This is Tech News</h1>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" />
    </div>
   </asp:Content>

