﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace bookXchangeWindows
{
    abstract class Listing : ISerializable
    {
        string mListingID;
        string mBookID;
        string mUserID;
        DateTime mListedDate = new DateTime();
        bool mIsRequest;
        int mPrice;

        public Listing(string pUserID, string pBookID, bool pIsRequest, int pPrice)
        {
            mUserID = pUserID;
            mBookID = pBookID;
            mListedDate = DateTime.Now;
            mIsRequest = pIsRequest;
            mPrice = pPrice;
        }


        //serialization methods


        //This serializes the object
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", mListingID, typeof(string));
            info.AddValue("bookID", mBookID, typeof(string));
            info.AddValue("userID", mUserID, typeof(string));
            info.AddValue("listedDate", mListedDate, typeof(string));
            info.AddValue("isRequest", mIsRequest);
            info.AddValue("price", mPrice, typeof(int));
        }

        //deserializes the stream in to a new object
        public Listing(SerializationInfo info, StreamingContext context)
        {
            mListingID = (string)info.GetValue("ID", typeof(string));
            mBookID = (string)info.GetValue("bookID", typeof(string));
            mUserID = (string)info.GetValue("mUserID", typeof(string));
            mListedDate = (DateTime)info.GetValue("listedDate", typeof(DateTime));
            mIsRequest = (bool)info.GetValue("isRequest", typeof(bool));
            mPrice = (int)info.GetValue("price", typeof(int));

        }
    }
}
