<%@ Page Language="C#"  MasterPageFile = "~/SiteTemplate.master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>
   

 <asp:Content ID = "Content1" ContentPlaceHolderID = "ContentPlaceHolder1" runat = "Server">

    <div>
        <div>
            <asp:Label ID="userNameLabel" runat="server" Text="UserName"></asp:Label>
                    <asp:TextBox ID="UserName" runat="server" ></asp:TextBox>
            
        </div>
            <br />
        <div>
            <asp:Label ID="passwordLabel" runat="server" Text="Password" ></asp:Label>
        <asp:TextBox ID="Password" runat="server" ></asp:TextBox>
            
        </div>
            <br />
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        
    </div>


        
 
   </asp:Content>
