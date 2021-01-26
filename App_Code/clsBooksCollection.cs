using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsBooksCollection
/// </summary>
public class clsBooksCollection
{

    clsDataConnection dbconnection = new clsDataConnection();//create a connection to the data base
    //member var for current Book
    ClsBooks mThisBooks = new ClsBooks();
    public void Delete()
    {
        //intialise the dbconnection
        dbconnection = new clsDataConnection();
        //add the parameter data used by the stored procedure
        dbconnection.AddParameter("@BooksNo", mThisBooks.BooksNo);
        //execute the stored procedure in the database
        dbconnection.Execute("Sporc_tblbooks_Delete");
        /*///this public function provides the functionality for the delete method

        try //try to delete the record
        {
            //create an instance of the data connection class called myDataBase
            clsDataConnection MyDataBase = new clsDataConnection();
            //add the BooksNo parameter passed to this function to the list of parameters to use in the database
            MyDataBase.AddParameter("@BooksNo", mThisBooks.BooksNo);
            //execute the stored procedure in the database
            MyDataBase.Execute("sproc_tblBooks_Delete");
            //set the return value for the function
            return true;
        }
        catch //do this only if the code above failed for some reason
        {
            //report back that there was an error
            return false;
        }*/
    }

    public List<ClsBooks> BooksList
    {
        get
        {
            List<ClsBooks> mBooksList = new List<ClsBooks>();
            //Var to store the count of records
            Int32 RecordCount;
            //Var to store the Index for the loop
            Int32 Index = 0;
            //get the the count Records
            RecordCount = dbconnection.Count;
            //keep the loop until all the records are processed
            while (Index < RecordCount)
            {
                //create an a blank Books page
                ClsBooks NewBooks = new ClsBooks();
                //copy the data from the table to the RAM
                NewBooks.BooksNo = Convert.ToInt32(dbconnection.DataTable.Rows[Index]["BooksNo"]);
                NewBooks.BookName = Convert.ToString(dbconnection.DataTable.Rows[Index]["BookName"]);
                NewBooks.Author = Convert.ToString(dbconnection.DataTable.Rows[Index]["Author"]);
                NewBooks.Publisher = Convert.ToString(dbconnection.DataTable.Rows[Index]["Publisher"]);
                NewBooks.ISBN = Convert.ToString(dbconnection.DataTable.Rows[Index]["ISBN"]);
                NewBooks.CountryofOrigin = Convert.ToString(dbconnection.DataTable.Rows[Index]["Country of Origin"]);
                NewBooks.DateAdded = Convert.ToDateTime(dbconnection.DataTable.Rows[Index]["Date Added"]);
                NewBooks.Active = Convert.ToBoolean(dbconnection.DataTable.Rows[Index]["Active"]);
                NewBooks.Awards = Convert.ToString(dbconnection.DataTable.Rows[Index]["Award"]);
                //add the blank page to the array list
                mBooksList.Add(NewBooks);
                //increase the index
                Index++;
            }
            return mBooksList;
        }
    }

    public Int32 Count
    //public read only property for the count of records found
    {
        get
        {
            /*Create a connection to the database   
            clsDataConnection dBconnection = new clsDataConnection();
            //send the post code filter to the query
            dBconnection.AddParameter("@ISBN", "");
            //execute the query
            dBconnection.Execute("Sporc_tblBooks_filterbyISBNCODE");*/
            return dbconnection.Count;
        }
    }

    public Int32 Add()
    //this function will add a new book to the database
    //it accepts a single parameter an of type clsBooks
    //once the record is added the function returns the primary key value to the new record
    //          //
    //INSERT INTO tblbooks
    // ( BookNo, Bookname, Publisher,Author, ISBN, dateadded, Active)
    //SELECT
    // @BookNo, @Bookname, @Publisher,@Author, @ISBN, @DateAdded, @Active;
    {
        //connect to the database
        clsDataConnection NewdbBooks = new clsDataConnection();
        //add the parameters
        NewdbBooks.AddParameter("@BookName", mThisBooks.BookName);
        NewdbBooks.AddParameter("@Publisher", mThisBooks.Publisher);
        NewdbBooks.AddParameter("@Author", mThisBooks.Author);
        NewdbBooks.AddParameter("@CountryofOrigin", mThisBooks.CountryofOrigin);
        NewdbBooks.AddParameter("@ISBN", mThisBooks.ISBN);
        NewdbBooks.AddParameter("@DateAdded", mThisBooks.DateAdded);
        NewdbBooks.AddParameter("@Active", mThisBooks.Active);
        NewdbBooks.AddParameter("@Award", mThisBooks.Awards);
        //excecure the stored procesdure returning the primary key value of the new record
        return NewdbBooks.Execute("sporc_tblBooks_Insert");
    }

    public Int32 Update()
    //this function will add a new book to the database
    //it accepts a single parameter an of type clsBooks
    //once the record is added the function returns the primary key value to the new record
    //          //
    //INSERT INTO tblbooks
    // ( BooksNo, Bookname, Publisher,Author, ISBN, dateadded, Active, CountryofOrigin, Awards)
    //SELECT
    // @BooksNo, @Bookname, @Publisher,@Author, @ISBN,@Country of Origin, @DateAdded, @Active , @CountryofOrigin, @Awards;
    {
        //connect to the database
        clsDataConnection ExistingdbBooks = new clsDataConnection();
        //add the parameters
        ExistingdbBooks.AddParameter("@BooksNo", mThisBooks.BooksNo);
        ExistingdbBooks.AddParameter("@BookName", mThisBooks.BookName);
        ExistingdbBooks.AddParameter("@Publisher", mThisBooks.Publisher);
        ExistingdbBooks.AddParameter("@Author", mThisBooks.Author);
        ExistingdbBooks.AddParameter("@ISBN", mThisBooks.ISBN);
        ExistingdbBooks.AddParameter("@CountryofOrigin", mThisBooks.CountryofOrigin);
        ExistingdbBooks.AddParameter("@DateAdded", mThisBooks.DateAdded);
        ExistingdbBooks.AddParameter("@Active", mThisBooks.Active);
        ExistingdbBooks.AddParameter("@Award", mThisBooks.Awards);
        //excecure the stored procesdure returning the primary key value of the new record
        return ExistingdbBooks.Execute("sporc_tblBooks_Update");
    }

    public void ReportByCountryOfOrigin(string CountryOfOrigin)
    {
        //create a connection to the database
        dbconnection = new clsDataConnection();
        //send a Country of Origin filter to the query
        dbconnection.AddParameter("@CountryOfOrigin", CountryOfOrigin);
        //execute the query
        dbconnection.Execute("Sporc_tblBooks_filterbyCountryofOrigin");


    }

    //Public ThisBooks Property
    public ClsBooks ThisBooks
    {
        get
        {
            return mThisBooks;
        }
        set
        {
            mThisBooks = value;
        }

    }

}
