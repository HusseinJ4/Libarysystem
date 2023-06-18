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
/// Summary description for clsPublisherCollection
/// </summary>
public class clsPublisherCollection
{
    //create a connection to the database with class level scope
    clsDataConnection Publishers = new clsDataConnection();

    //constructor
    public clsPublisherCollection()
    {
        //excute the select all query
        Publishers.Execute("sporc_tblPublisher");

    }

    //this read only function gives us the count property

    public Int32 Count
    {
        get
        {
            //return the count of the data from the database
            return Publishers.Count;
        }

    }

    //this readonly funtion exposes the query results collection
    public List<clsPublisher> AllPublishers
    {
        get
        {
            //create a instance of a list called mAllPublishers
            List<clsPublisher> mAllPublishers = new List<clsPublisher>();
            //var to store the index for the loop
            Int32 Index = 0;
            //while the index is less that the number of records to process
            while (Index < Publishers.Count)
            {

                //set up the new entry to be added to the list
                clsPublisher NewPublisher = new clsPublisher();
                //get the publisher number from the database
                NewPublisher.PublisherNo = Convert.ToInt32(Publishers.DataTable.Rows[Index]["PublisherNo"]);
                //get the publisher name from the database
                NewPublisher.publisher = Convert.ToString(Publishers.DataTable.Rows[Index]["Publisher"]);
                //Add the new entry to the list
                mAllPublishers.Add(NewPublisher);
                //increment the index to the next record
                Index++;
            }
            //return the query results from the database
            return mAllPublishers;

        }
    }
}
