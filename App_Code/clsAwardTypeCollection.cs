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
/// Summary description for clsAwardTypeCollection
/// </summary>
public class clsAwardTypeCollection
{
    //create a connection to the database with class level scope
    clsDataConnection Awards= new clsDataConnection();
    public clsAwardTypeCollection()
    {
        //excute the select all query
        Awards.Execute("sporc_tblAwardtype");
    }

    //this read only function gives us the count property

    public Int32 Count
    {
        get
        {
            //return the count of the data from the database
            return Awards.Count;
        }

    }

    //this readonly funtion exposes the query results collection
    public List<clsAwardType> AllAwards
    {
        get
        {
            //create a instance of a list called mAllAwards
            List<clsAwardType> mAllAwards = new List<clsAwardType>();
            //var to store the index for the loop
            Int32 Index = 0;
            //while the index is less that the number of records to process
            while (Index < Awards.Count)
            {

                //set up the new entry to be added to the list
                clsAwardType NewAwardtype = new clsAwardType();
                //get the Award number from the database
                NewAwardtype.AwardNo= Convert.ToInt32(Awards.DataTable.Rows[Index]["AwardNo"]);
                //get the Award name from the database
                NewAwardtype.Award = Convert.ToString(Awards.DataTable.Rows[Index]["Award"]);
                //Add the new entry to the list
                mAllAwards.Add(NewAwardtype);
                //increment the index to the next record
                Index++;
            }
            //return the query results from the database
            return mAllAwards;

        }
    }
}
