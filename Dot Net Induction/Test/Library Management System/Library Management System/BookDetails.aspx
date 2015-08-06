<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="Library_Management_System.BookDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gvBooks" runat="server" 
        AutoGenerateColumns="false"
        DataKeyNames="Name"
        OnRowDeleting="gvBooks_RowDeleting" 
        OnRowEditing="gvBooks_RowEditing"
        OnRowUpdating="gvBooks_RowUpdating" 
        OnRowCommand="gvBooks_RowCommand"
        ShowFooter="true" > 
          <Columns>
            
              <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtftrName" runat="server"/>
                </FooterTemplate>
            </asp:TemplateField>
              
              <asp:TemplateField HeaderText="Author">
                  <ItemTemplate>
                      <asp:Label ID="lblAuthor" runat="server" Text='<%# Eval("Author") %>'></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:TextBox ID="txtAuthor" runat="server" Text='<%# Eval("Author") %>' ></asp:TextBox>
                  </EditItemTemplate>
                   <FooterTemplate>
                    <asp:TextBox ID="txtftrAuthor" runat="server"/>
                </FooterTemplate>
              </asp:TemplateField>

              <asp:TemplateField HeaderText="Quantity">
                  <ItemTemplate>
                      <asp:Label ID="lblQuantity" runat="server" Text='<%# Eval("Quantity") %>' ></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                      <asp:TextBox ID="txtQuantity" runat="server" Text='<%# Eval("Quantity") %>' ></asp:TextBox>
                  </EditItemTemplate>
                   <FooterTemplate>
                    <asp:TextBox ID="txtftrQuantity" runat="server"/>
                </FooterTemplate>

              </asp:TemplateField>
              <asp:TemplateField HeaderText="Edit" ShowHeader="false">
               <ItemTemplate>
                   <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" Text="Edit" ></asp:LinkButton>
               </ItemTemplate>    
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Delete" ShowHeader="false">
               <ItemTemplate>
                   <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" Text="Delete" ></asp:LinkButton>
                   </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Update" ShowHeader="false">
               <ItemTemplate>
                   <asp:LinkButton ID="btnUpdate" runat="server" CommandName="Update" Text="Update" ></asp:LinkButton>
               </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField>
                   <FooterTemplate>
                    <asp:LinkButton ID="txtftrAdd" CommandName="Add" Text="Add" runat="server"/>
                </FooterTemplate>
              </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </div>

    </form>
</body>
</html>
