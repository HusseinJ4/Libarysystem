using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsBooks
/// </summary>
public class ClsBooks
{
    //BookNo private member
    private Int32 mBooksNo;
    //BookNo public property
    public Int32 BooksNo
    {
        get
        {
            //this line of code sends data out of the property   
            return mBooksNo;
        }
        set
        {
            //this line of code sends data into the property
            mBooksNo = value;
        }
    }

    //Bookname private member variable
    private string mBookName;
    //bookname public property

    public string BookName
    {
        get
        {
            return mBookName;
        }
        set
        {
            mBookName = value;
        }
    }
    //Author private member variable
    private string mAuthor;
    //Author public property

    public string Author
    {

        get
        {
            return mAuthor;
        }
        set
        {
            mAuthor = value;
        }
    }

    //Publisher private member Variable
    private string mPublisher;
    //Publisher public property

    public string Publisher
    {
        get
        {
            return mPublisher;
        }
        set
        {
            mPublisher = value;
        }
    }
    //private memeber variable
    private string mAwards;
    //Awards public property
    public string Awards
    {
        get
        {
            return mAwards;
        }
        set
        {
            mAwards = value;
        }

    }

    //ISBN private member variable
    private string mISBN;
    //ISBN public public property
    public string ISBN
    {
        get
        {
            return mISBN;     
        }
        set
        {
            mISBN = value;
        }
    }
    //Country of Origin
    private string mCountryofOrigin;
    //country of origin
    public string CountryofOrigin
    {
        get
        {
            return mCountryofOrigin;
        }
        set
        {
            mCountryofOrigin = value;
        }

    }

    //dateAdded private member variable
    private DateTime mDateAdded;
    //dateAdded public property

    public DateTime DateAdded
    {
        get
        {
            return mDateAdded;
        }
        set
        {
            mDateAdded = value;
        }

    }

    //active private member variable
    private Boolean mActive;
    //Active public property
    public Boolean Active
    {
        get
        {
            return mActive;
        }
        set
        {
            mActive = value;
        }
    }
   
    public string BookValid(string BooksNo,
                            string BookName,
                            string Author,
                            string ISBN,
                            string Publisher,
                            string DateAdded,
                            string CountryofOrigin,
                            string text,
                            string Awards
                            )
    {
        //Var to store the error message 
        string ErrorMsg="";
        // check if a letter was placed instead of a number
        try
        {
            Int32 temp =Convert.ToInt32( BooksNo);
        }
        catch
        {
            ErrorMsg = "The Book No was not the number";
        }
        //check if the book name was left blank
        if (BookName.Length < 1)
        {
            ErrorMsg = ErrorMsg + "Book Name left blank";
        }
        //check if author was left blank
        if (Author.Length <1)
        {
            ErrorMsg = ErrorMsg + "Author left blank";
        }
        // check if author character was more than 50
        if (Author.Length >50)
        {
            ErrorMsg = ErrorMsg + "The author name cannot be more than 50 characters";
        }
        //check CountryofOrigin was left blank
        if (CountryofOrigin.Length < 1)
        {
            ErrorMsg = ErrorMsg + "CountryofOrigin was left blank";
        }
        
        // check the puplisher length
        if (Publisher.Length <1)
        {
            ErrorMsg = ErrorMsg + "The publisher name cannot be left blank";
        }
        
        //check the ISBN has been left blank
        if (ISBN.Length >8)
        {
            ErrorMsg = ErrorMsg + "ISBN cannot be more than 8";
        }
        /*
        // check the isbn length
        if (ISBN.Length < 1)
        {
            ErrorMsg = ErrorMsg + "The ISBN cannot be left blank";
        }
        
         //has the date been added 
        try
        {   
            //var to store the date
            DateTime Temp; 
            //Assign the date to the temporary var
            Temp = Convert.ToDateTime(DateAdded);
        }
        catch // if error
        {
            ErrorMsg = ErrorMsg + " Date added is not in date format";
        }*/
        //if no errors
        if (ErrorMsg == "")
        {
            //return a blank string
            return "";
        }
        else//otherwise
        {
            //return the errors string value
            return "These were the following errors : " + ErrorMsg;
        }
    }

    //function for the find public method
    public Boolean Find(Int32 BooksNo)
    {
        //initialise the dbConnection
        clsDataConnection dbConnection = new clsDataConnection();
        //add the book no paramter
        dbConnection.AddParameter("@BooksNo", BooksNo);
        //execure the query
        dbConnection.Execute("Sporc_tblbooks_FilterbyBooksNo");
        //if the record was found
        if (dbConnection.Count == 1)
        {
            //get the books No
            mBooksNo = Convert.ToInt32(dbConnection.DataTable.Rows[0]["BooksNo"]);
            //get the book name
            mBookName = Convert.ToString(dbConnection.DataTable.Rows[0]["BookName"]);
            //get the author
            mAuthor = Convert.ToString(dbConnection.DataTable.Rows[0]["Author"]);
            //get the publisher
            mPublisher = Convert.ToString(dbConnection.DataTable.Rows[0]["Publisher"]);
            //get the award
            mAwards = Convert.ToString(dbConnection.DataTable.Rows[0]["Award"]);
            //get the ISBN
            mISBN = Convert.ToString(dbConnection.DataTable.Rows[0]["ISBN"]);
            //get the country of origin
            mCountryofOrigin = Convert.ToString(dbConnection.DataTable.Rows[0]["Country of Origin"]);
            //get the date added
            mDateAdded = Convert.ToDateTime(dbConnection.DataTable.Rows[0]["Date Added"]);
            //get the active state
            try
            {
                mActive = Convert.ToBoolean(dbConnection.DataTable.Rows[0]["Active"]);
            }
            catch
            {
                mActive = true;
            }
            //return success
            return true;
        }
        else
        {
            //return failure
            return false;
        }
    }
    
}