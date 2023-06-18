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
/// Summary description for clsAwardType
/// </summary>
public class clsAwardType
{
    //private member for primary key
    private Int32 mAwardNo;
    //public property for Award No
    public Int32 AwardNo
    {
        get
        {
            return mAwardNo;
        }
        set
        {

            mAwardNo = value;
        }
    }

    //private member variable for Award name
    private string mAward;
    //public property for Award 
    public string Award
    {

        get
        {
            return mAward;
        }
        set
        {
            mAward = value;
        }


    }

}
