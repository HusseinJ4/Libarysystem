/** * * * *

Author: Hussein Jama
Email: P17178096@mydmu.365.ac.uk
Date: 10/05/2023
@author H Jama
@copyright HJA
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsAwardbodyCollection
/// </summary>
public class clsAwardbodyCollection
{
    clsDataConnection dbconnection = new clsDataConnection();//create a connection to the data base
    //member var for current book
    clsAwardBody mThisAward = new clsAwardBody();

    public List<clsAwardBody> AwardsList
    {
        get
        {
            List<clsAwardBody> mAwardsList = new List<clsAwardBody>();
            //Var to store the count of records
            Int32 RecordCount;
            //Var to store the Index for the loop
            Int32 Index = 0;
            //get the the count Records
            RecordCount = dbconnection.Count;
            //keep the loop until all the records are processed
            while (Index < RecordCount)
            {
                //create a blank award body page
                clsAwardBody NewAwards = new clsAwardBody();
                //copy the data from the table to the ram
                NewAwards.AwardbodyNo = Convert.ToInt32(dbconnection.DataTable.Rows[Index]["AwardbodyNo"]);
                NewAwards.AwardbodyName = Convert.ToString(dbconnection.DataTable.Rows[Index]["AwardbodyName"]);
                NewAwards.DateFounded = Convert.ToDateTime(dbconnection.DataTable.Rows[Index]["DateFounded"]);
                NewAwards.Alocation = Convert.ToString(dbconnection.DataTable.Rows[Index]["ALocation"]);
                //add the blank page to the array list
                mAwardsList.Add(NewAwards);
                //increase the index
                Index++;
            }
            return mAwardsList;
        }
    }
    public void ReportbyAwardbodyLocation(string Alocation)
    {
        //create a connection to the database
        dbconnection = new clsDataConnection();
        //send a AwardbodyLocationfilter to the query
        dbconnection.AddParameter("@Alocation", Alocation);
        //excute the query
        dbconnection.Execute("sporc_tblAwardtype_Filterbylocation");
    }

    public Int32 Count
    {
        get
        {
            return dbconnection.Count;
        }
    }

    public Int32 AddAward()
    {
        //connect to the database
        clsDataConnection newdbAward = new clsDataConnection();
        //add the parameters
        newdbAward.AddParameter("@AwardBodyName", mThisAward.AwardbodyName);
        newdbAward.AddParameter("@DateFounded", mThisAward.DateFounded);
        newdbAward.AddParameter("@ALocation", mThisAward.Alocation);
        //execute the stored procedure in the database
        return newdbAward.Execute("sporc_tbltblAwardtype_Insert");
    }

    public Int32 Update()
    {
        //connect to the database
        clsDataConnection ExistingdbAwards = new clsDataConnection();
        //add the parameters
        ExistingdbAwards.AddParameter("@AwardBodyNo", mThisAward.AwardbodyNo);
        ExistingdbAwards.AddParameter("@AwardBodyName", mThisAward.AwardbodyName);
        ExistingdbAwards.AddParameter("@DateFounded", mThisAward.DateFounded);
        ExistingdbAwards.AddParameter("@ALocation", mThisAward.Alocation);
        //excecure the stored procesdure returning the primary key value of the new record
        return ExistingdbAwards.Execute("sporc_tblAwardBody_Update");


    }

    public clsAwardBody ThisAwards
    {
        get
        {
            return mThisAward;
        }
        set
        {
            mThisAward = value;
        }
    }
}
