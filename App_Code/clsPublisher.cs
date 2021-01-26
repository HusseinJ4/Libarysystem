using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsPublisher
/// </summary>
    public class clsPublisher
    {
        //private member for primary key
        private Int32 mPublisherNo;
        //public property for PublisherNo
        public Int32 PublisherNo
        {
           get
           {
            return mPublisherNo;
           }
           set
           {

            mPublisherNo = value;
           }
        }

        //private member variable for publisher name
        private string mPublisher;
        //public property for publisher
        public string publisher
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

    }