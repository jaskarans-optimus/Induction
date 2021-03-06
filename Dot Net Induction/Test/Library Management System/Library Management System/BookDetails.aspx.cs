﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesLayer;
namespace Library_Management_System
{
    public partial class BookDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvBind();
            }
            if (Session["userName"] != null)
            {
                if (((bool)Session["AdminRights"]) == false)
                {
                    gvBooks.AutoGenerateEditButton = false;
                    gvBooks.AutoGenerateDeleteButton = false;
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
        protected void gvBind()
        {
            gvBooks.DataSource =BookOperation.GetAllBooks();
            gvBooks.DataBind();
        }

        protected void gvBooks_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvBooks.Rows[e.RowIndex];
           TextBox txtDelete=(TextBox)row.Cells[0].Controls[0];
          BookOperation.DeleteBook(txtDelete.Text);
            gvBind();
        }

        protected void gvBooks_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvBooks.EditIndex = e.NewEditIndex;
            gvBind();
        }

        protected void gvBooks_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvBooks.Rows[e.RowIndex];
            //TextBox txtName = (TextBox)row.Cells[0].Controls[0];
            Label lblName = (Label)row.Cells[0].FindControl("lblName");
            TextBox txtAuthor = (TextBox)row.Cells[1].FindControl("txtAuthor");
            TextBox txtQuantity = (TextBox)row.Cells[2].FindControl("txtQuantity");
                Book book = new Book();
                book.Name = lblName.Text;
                book.Author = txtAuthor.Text;
                int quants;
                Int32.TryParse(txtQuantity.Text,out quants);
                book.Quantity = quants;
                BookOperation.UpdateBook(book);
                gvBooks.EditIndex = -1;
                gvBind();

        }

        protected void gvBooks_RowCreated(object sender, GridViewRowEventArgs e)
        {
          
        }

        protected void gvBooks_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = gvBooks.FooterRow;
            TextBox txtName = (TextBox)row.FindControl("txtftrName");
            TextBox txtAuthor = (TextBox)row.Cells[1].FindControl("txtftrAuthor");
            TextBox txtQuantity = (TextBox)row.Cells[2].FindControl("txtftrQuantity");
            Book book = new Book();
            book.Name = txtName.Text;
            book.Author = txtAuthor.Text;
            int quants;
            Int32.TryParse(txtQuantity.Text, out quants);
            book.Quantity = quants;
            BookOperation.Add(book);
            gvBind();
        }
    }
}