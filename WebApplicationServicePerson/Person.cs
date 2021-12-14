using System;
using System.Data;

namespace WebApplicationServicePerson

{
    public class Person
    {
        private int _businessEntityID;
        private string _nameStyle;
        private string _title;
        private string _personType;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _suffix;
        private int _emailPromotion;
        private string _additionalContactInfo;
        private string _demographics;
        private string _rowguid;
        private DateTime _modifiedDate;

        public int BusinessEntityID
        {
            get
            {
                return _businessEntityID;
            }
        }

        public string PersonType
        {
            get
            {
                return _personType;
            }
        }

        public string NameStyle

        {
            get
            {
                return _nameStyle;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }

        public string MiddleName
        {
            get
            {
                return _middleName;
            }
        }


        public string LastName
        {
            get
            {
                return _lastName;
            }
        }


        public string Suffix
        {
            get
            {
                return _suffix;
            }
        }


        public int EmailPromotion
        {
            get
            {
                return _emailPromotion;
            }
        }

        public string AdditionalContactInfo
        {
            get
            {
                return _additionalContactInfo;
            }
        }

        public string Demographics
        {
            get
            {
                return _demographics;
            }
        }

        public string Rowguid
        {
            get
            {
                return _rowguid;
            }
        }

        public DateTime ModifiedDate
        {
            get
            {
                return _modifiedDate;
            }

        }

        public Person(DataRow character)
        {
            _businessEntityID = Convert.ToInt32(character["BusinessEntityID"]);
            _personType = character["PersonType"].ToString();
            _nameStyle = character["NameStyle"].ToString();
            _title = character["Title"].ToString();
            _firstName = character["FirstName"].ToString();
            _middleName = character["MiddleName"].ToString();
            _lastName = character["LastName"].ToString();
            _suffix = character["Suffix"].ToString();
            _emailPromotion = (int)character["EmailPromotion"];
            _additionalContactInfo = character["AdditionalContactInfo"].ToString();
            _demographics = character["Demographics"].ToString();
            _rowguid = character["rowguid"].ToString();
            _modifiedDate = Convert.ToDateTime(character["ModifiedDate"]);
        }
    }
}
