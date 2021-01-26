using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //if thisis the first apperance of this form
        if (IsPostBack == false)
        {

            //Display all the books
            DisplayBooks("");


        } 
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 BooksNo;
        //if a record has been selected from the list
        if (ListBooks.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            BooksNo = Convert.ToInt32(ListBooks.SelectedValue);
            //store the data in the session object
            Session["BooksNo"] = BooksNo;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select the book you want to delete";
        }
    }

    protected void BtnDisplayAll_Click(object sender, EventArgs e)
    {
        //display the books
        DisplayBooks("");
    }
    Int32 DisplayBooks(string CountryofOriginFilter)
    {
        Int32 BooksNo;//Var to store the primary key
        string BookName;//Var to store the book name
        String Author; // var to sore the author
        String CountryofOrigin;//Var to sto store the Publisher
        ;//create an instance of the books collection class
        clsBooksCollection Booklisting = new clsBooksCollection();
        Booklisting.ReportByCountryOfOrigin(CountryofOriginFilter);
        Int32 RecordCount;//var to store the count of records
        Int32 Index = 0;//var to store the index of the loop
        RecordCount = Booklisting.Count;//get the count of records
        ListBooks.Items.Clear();//clear the list Box
        while (Index < RecordCount) //while there are records to process
        {
            BooksNo = Booklisting.BooksList[Index].BooksNo;//get the primary key
            BookName = Booklisting.BooksList[Index].BookName;//get the book name
            Author = Booklisting.BooksList[Index].Author;// get the author
            CountryofOrigin = Booklisting.BooksList[Index].CountryofOrigin;// get the country of Origin
            ListItem NewEntry = new ListItem(BookName + " " + Author + " " + CountryofOrigin + "" , BooksNo.ToString());//create a new entry for the list box
            ListBooks.Items.Add(NewEntry);//add the books to the list
            Index++;//move the index to the next record
        }
        return RecordCount;//return the count record found 
    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        //display all the books
        DisplayBooks(TxtCountryofOrigin.Text);
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //redirect to the add new page
        Response.Redirect("AnBook.aspx?BooksNo=-1");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 BooksNo;
        //check the list has been clicked first
        if (ListBooks.SelectedIndex != -1)
        {
            //Get the primary key value from the list box
            BooksNo = Convert.ToInt32(ListBooks.SelectedValue);
            //redirect to the editing page
            Response.Redirect("AnBook.aspx?BooksNo="+ BooksNo);
        }
        else
        {
            //display an error
            lblError.Text = "You must select an Item/Book off the list box first to edit it";


        }
    }

    protected void btnAwardpage_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultAward.aspx");
    }
}