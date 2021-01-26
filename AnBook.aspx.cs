using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnBook : System.Web.UI.Page
{  //var to store the book no
    Int32 BooksNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the variable
        BooksNo = Convert.ToInt32(Request.QueryString["BooksNo"]);
        //if the books no is not -1 then display the data from the record

        if (IsPostBack != true)
        {
            //update the contents of the drop down list
            DisplayPublishers();
            //update the contents of the drop down list
            DisplayAwards();
            if (BooksNo != -1)
            {
                //display the data for this book
                //DisplayBooks(BooksNo);
                DisplayBooks(BooksNo);
            }
            else
            {
                txtBooksNo.Text = BooksNo.ToString();
            }
        }
    }

    //this function displays the data for an Books on the webform
    void DisplayBooks(Int32 BooksNo)
    {
        //create an instance of the Books class
        ClsBooks MyBooklisting = new ClsBooks();
        //find the record we want to display
        MyBooklisting.Find(BooksNo);
        //display the book no
        txtBooksNo.Text = Convert.ToString(MyBooklisting.BooksNo);
        //MyBooklisting.BookNo= Convert.ToInt32(this.txtBookNo);
        //display the book name
        txtBookName.Text = MyBooklisting.BookName;
        //display the Author
        txtAuthor.Text = MyBooklisting.Author;
        //display country of origin
        txtCountryOforigin.Text = MyBooklisting.CountryofOrigin;
        //display the publisher
        cmbPublisher.SelectedValue = cmbPublisher.SelectedValue;
        //display the ISBN
        txtISBN.Text = MyBooklisting.ISBN;
        //display the date added
        txtDateAdded.Text = MyBooklisting.DateAdded.ToString("dd/MM/yyyy");
        //set the drop down list to display the Publisher
        cmbPublisher.SelectedValue = Convert.ToString(MyBooklisting.Publisher);
        //set the drop down list to display the Publisher
        cmbPublisher.SelectedValue = Convert.ToString(MyBooklisting.Publisher);
        //set the the drop down list to display the award
        cmdAward.SelectedValue = Convert.ToString(MyBooklisting.Awards);
        //set the the drop down list to display the award
        cmdAward.SelectedValue = Convert.ToString(MyBooklisting.Awards);
        //display the active state
        chkActive.Checked = MyBooklisting.Active;

    }

    //this funtion is used to populate the publisher drop down lsit
    Int32 DisplayPublishers()
    {
        //create an instance of the puplisher class
        clsPublisherCollection Publishers = new clsPublisherCollection();
        //var to stoer the county number primary key
        string PublisherNo;
        //var to store the name of the publisher
        string Publisher;
        //var to store the index for the loop
        Int32 Index = 0;
        //while the index is less that the number of records to procces
        while (Index < Publishers.Count)
        {
            //get the Publisher number from the database
            PublisherNo = Convert.ToString(Publishers.AllPublishers[Index].PublisherNo);
            //get the publisher name from the database
            Publisher = Publishers.AllPublishers[Index].publisher;
            //set up the new row to be added to the list
            ListItem NewPublisher = new ListItem(Publisher, PublisherNo);
            //add the new row to the List
            cmbPublisher.Items.Add(NewPublisher);
            //inrement the index to the next record
            Index++;
        }
        //return the number of records found
        return Publishers.Count;
    }

    Int32 DisplayAwards()
    {
        //create an instance of the puplisher class
        clsAwardTypeCollection Awards = new clsAwardTypeCollection();
        //var to stoer the county number primary key
        string AwardNo;
        //var to store the name of the publisher
        string Award;
        //var to store the index for the loop
        Int32 Index = 0;
        //while the index is less that the number of records to procces
        while (Index < Awards.Count)
        {
            //get the Award number from the database
            AwardNo = Convert.ToString(Awards.AllAwards[Index].AwardNo);
            //get the publisher name from the database
            Award = Awards.AllAwards[Index].Award;
            //set up the new row to be added to the list
            ListItem NewAward = new ListItem(Award, AwardNo);
            //add the new row to the List
            cmdAward.Items.Add(NewAward);
            //inrement the index to the next record
            Index++;
        }
        //return the number of records found
        return Awards.Count;

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create an instance of the books page class
        ClsBooks thisBooks = new ClsBooks();
        //var to store any error messages
        string ErrorMessage;
        //test the data on the web from
        ErrorMessage = thisBooks.BookValid(txtBooksNo.Text , txtBookName.Text , txtAuthor.Text , "", cmbPublisher.Text,cmdAward.Text ,txtISBN.Text, txtDateAdded.Text, txtCountryOforigin.Text);
        LblError.Text = ErrorMessage;

        if (ErrorMessage == "")
        {
            //create a new instance of  book class
            clsBooksCollection booksCollection = new clsBooksCollection();
            //do something with the data - insert or update
            //
            //if the book number is -1
            if (txtBooksNo.Text == "-1")
            {
                //copy the data form the interface to the object
                booksCollection.ThisBooks.BooksNo = Convert.ToInt32(txtBooksNo.Text);
                booksCollection.ThisBooks.BookName = txtBookName.Text;
                booksCollection.ThisBooks.Author = txtAuthor.Text;
                booksCollection.ThisBooks.CountryofOrigin = txtCountryOforigin.Text;
                booksCollection.ThisBooks.Publisher = cmbPublisher.SelectedValue;
                booksCollection.ThisBooks.Awards = cmdAward.SelectedValue;
                booksCollection.ThisBooks.ISBN = txtISBN.Text;
                booksCollection.ThisBooks.Active = chkActive.Checked;
                //thisBooks.PublisherNo = Convert.ToInt32(cmbPublisher.SelectedValue);
                booksCollection.ThisBooks.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //Add the new record
                booksCollection.Add();
            }
            else
            {

                //this is an existing record
                //copy the data form the interface to the object
                booksCollection.ThisBooks.BooksNo = Convert.ToInt32(txtBooksNo.Text);
                booksCollection.ThisBooks.BookName = txtBookName.Text;
                booksCollection.ThisBooks.Author = txtAuthor.Text;
                booksCollection.ThisBooks.CountryofOrigin = txtCountryOforigin.Text;
                booksCollection.ThisBooks.Publisher = cmbPublisher.SelectedValue;
                booksCollection.ThisBooks.Awards = cmdAward.SelectedValue;
                booksCollection.ThisBooks.ISBN = txtISBN.Text;
                booksCollection.ThisBooks.Active = chkActive.Checked;
                booksCollection.ThisBooks.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //Add the new record
                booksCollection.Update();
                
            }
            //do something with the data - insert or update 
            //redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //display the error message 
            LblError.Text = ErrorMessage;
        }

        //var to store the error message
        string ErrMsg = "";
        //check the min length of book no
        if (txtBooksNo.MaxLength == 1)
        {
            //set the error message
            ErrMsg = ErrMsg + "Book No is blank";
        }
        //check the max length of the book name
        if (txtBookName.MaxLength > 6)
        {
            //set the error message
            ErrMsg = ErrMsg + "Book no must be less than 6 characters.";
        }
        //check if book name is black
        if (txtBookName.MaxLength < 0)
        {
            //set the error message
            ErrMsg = ErrMsg + "Book name is blank";
        }
        //check the min length of the author
        if (txtAuthor.MaxLength >5)
        {
            //set the error message
            ErrMsg = ErrMsg + "Author must be more than 5 characters ";
        }
        //check the max length of author
        if (txtAuthor.MaxLength == 10)
        {
            //set error message
            ErrMsg = ErrMsg + "Author cannot be more than 10 characters";
        }
        /*
        //check publisher is not blank
        if (cmbPublisher.SelectedValue.Length < 1)
        {
            //set the error massage
            ErrMsg = ErrMsg + "Publisher cannot be left blank";
        }*/
        //check max length ISBN
        if (txtISBN.MaxLength > 5)
        {
            //set error message
            ErrMsg = ErrMsg + "ISBN cannot be more than 5 chracters";
        }
        /* 
        //check if ISBN is blank
        if (txtISBN.MaxLength < 1)
        {
            //set the error message
            //ErrMsg = ErrMsg + "ISBN cannot be left blank";
        }
        
        //check if Country of Orign is blank
        if (txtCountryOforigin.MaxLength > 5)
        {
            //set the error message
            ErrMsg = ErrMsg + "Country of origin cannot contain more than 5 Letters";
        }

        
           //check date added
            if (txtDateAdded.MaxLength < 0)
        {
           //set the error message
            ErrMsg = ErrMsg + "Date Added is blank";
        }
        try//try the operation
        {
            //var to store the date
            DateTime Temp;
            //assign the date to the temporary var
            Temp = Convert.ToDateTime(txtDateAdded);
        }
        catch // if it failed then report an error
        {
            //set the error message
            ErrMsg = ErrMsg + "Date Added is not in the correct format";
        }*/
        //if no errors
        if (ErrMsg == "") 
        {
            //return blank string   
            ErrMsg = ErrMsg + "No errors";
        }
        else//otherwise
        {
            //return the errors string value
            LblError.Text = ErrMsg;
        }

    }


    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}