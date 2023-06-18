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
/// Summary description for clsAwardBody
/// </summary>
public class clsAwardBody
{   //AwardBodyNo private member
    private Int32 mAwardbodyNo;
    //AwardBodyNo public member
    public Int32 AwardbodyNo
    {
        get
        {
            //this line of code sends data out of the property
            return mAwardbodyNo;

        }
        set
        {
            //this line of code sends data into the property
            mAwardbodyNo = value;
        }
    }

    //AwardBody name private member variable
    private string mAwardbodyName;
    //public 

    public string AwardbodyName
    {
        get
        {
            return mAwardbodyName; 
        }
        set
        {
            mAwardbodyName = value;
        }

    }

    //date founded  private member
    private DateTime mDateFounded;
    //public
    public DateTime DateFounded
    {
        get
        {
            return mDateFounded;
        }
        set
        {
            mDateFounded = value;
        }
    }
    //location private
    private string mAlocation;
    //public
    public string Alocation
    {
        get
        {
            return mAlocation;
        }
        set
        {
            mAlocation = value;
        }
    }

    public string AwardValid(string AwardBodyNo,
                            string AwardbodyName,
                            string DateFounded,
                            string ALocation
                            )
    {
        //var to store the error message
        string ErrorMsg = "";
        // check if a letter was placed instead of a number
        try
        {
            Int32 temp = Convert.ToInt32(AwardBodyNo);
        }
        catch
        {
            ErrorMsg = "the book no was not the number";
        }
        //check if the AwardbodyName was left blank
        if(AwardbodyName.Length <1)
        {
            ErrorMsg = ErrorMsg + "AwardBody Name was left blank";
        }
        //checked if location was left blank
        if(ALocation.Length <1)
        {
            ErrorMsg = ErrorMsg + "Loation was left blank";
        }
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

    public Boolean FindAward(Int32 AwardbodyNo)
    {
        //initialise the dbConnection
        clsDataConnection dbConnection = new clsDataConnection();
        //add the AwardbodyNo paramter
        dbConnection.AddParameter("@AwardBodyNo", AwardbodyNo);
        //execute the query
        dbConnection.Execute("Sporc_tblbooks_FilterAwardBodyNo");
        //if the record was found
        if(dbConnection.Count ==1)
        {
            //get the awardbodyNo
            mAwardbodyNo = Convert.ToInt32(dbConnection.DataTable.Rows[0]["AwardbodyNo"]);
            //get the awardBodyName
            mAwardbodyName = Convert.ToString(dbConnection.DataTable.Rows[0]["AwardbodyName"]);
            //get the date founded
            mDateFounded = Convert.ToDateTime(dbConnection.DataTable.Rows[0]["DateFounded"]);
            //get the location
            mAlocation = Convert.ToString(dbConnection.DataTable.Rows[0]["Alocation"]);
        }
        return true;
    }
}
