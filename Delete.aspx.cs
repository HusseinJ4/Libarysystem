using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    Int32 BooksNo;
    protected void Page_load(object sender, EventArgs e)
    {
        //Get the number of the book to be deleted from the session object
        BooksNo = Convert.ToInt32(Session["BooksNo"]);

    }
    protected void BtnYes_Click(object sender, EventArgs e)
    {
        ///this function handles of class clsBooksCollection called myBooksListing

        //Create an anstance of class clsbookscollection called mybookcollection 
        clsBooksCollection Mybooklisting = new clsBooksCollection();
        //try and find the record to delete
        Mybooklisting.ThisBooks.Find(BooksNo);
        //call the delete method
        Mybooklisting.Delete();
        // request the delete method
        Response.Redirect("Default.aspx");

    }
        /*
        ///this function handles of class clsBooksCollection called myBooksListing
        ///Create an anstance of class clsbookscollection called mybookcollection
        clsBooksCollection myBooklisting = new clsBooksCollection();
        //declare a variable to store the book number to delete
        Int32 BooksNo;
        //declare a boolean varaiable to record success of delete operation
        Boolean Success;
        //copy the data from the interface to the ram converting the data to Int32
        BooksNo = Convert.ToInt32(txtBooksNo.Text);
        //Invoke the delete
        Success = myBooklisting.Delete(BooksNo);
        //if the operation was successful display a message to the user
        if (Success == true)
        {
            lblBooksNo.Text = " you have deleted the recorded number" + BooksNo;
        }
        else //display an error message
        {
            lblBooksNo.Text = "there was a problem deleting the record";
        }*/

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        //this line of code redirects to the default page
        Response.Redirect("Default.aspx");
    }
}