using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS
{
    public class Dictionary
    {
        //private string ID;
        public string id
        {
            get;
            set;
        }
        private string StringValue;
        public string stringValue
        {
            get
            {
                return StringValue;
            }
            set
            {
                StringValue = value;
            }
        }
        private int DisplayOrder;
        public int displayOrder
        {
            get
            {
                return DisplayOrder;
            }
            set
            {
                DisplayOrder = value;
            }
        }

        private string ParentID;
        public string parentID
        {
            get
            {
                return ParentID;
            }
            set
            {
                ParentID = value;
            }
        }
        private string Type;
        public string type
        {
            get
            {
                return Type;
            }
            set
            {
                Type = value;
            }
        }
    }
}
