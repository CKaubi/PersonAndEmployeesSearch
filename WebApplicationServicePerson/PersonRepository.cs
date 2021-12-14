using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationServicePerson
{
    public class PersonsRepository
    {
        private static PersonsRepository _personsRepository;
        private List<Person> _persons;
        private DataSet _dataSet;
        private char _simbol;
       
        public char Simbol
        {
            get
            {
                return _simbol;
            }
            set
            {
                _simbol = value;
            }
        }
        public DataSet DataSet
        {
            get
            {
                return _dataSet;
            }
          
        }
        public static PersonsRepository Repository
        {
            get
            {
                if (_personsRepository == null)
                {
                    _personsRepository = new PersonsRepository();
                }
                return _personsRepository;
            }

        }
        public List<Person> Persons
        {
            get
            {
                if (_persons == null)
                {
                    _persons = new List<Person>();
                }
                return _persons;
            }

        }

        public List<string> GetFirstNames()
        {
            List<string> Names = new List<string>();

            foreach (Person person in _persons)
            {
                Names.Add(person.FirstName);
            }

            return Names;
        }

        public Person GetPerson(int id)
        {
            foreach (Person person in _persons)
            {
                if (person.BusinessEntityID == id)
                {
                    return person;
                }
            }
            return null;
        }
        
        public void AddPerson(int request)
        {
           var client = new ServiceReferenceDataBaseProvaider.DataBaseProvaiderClient("BasicHttpBinding_IDataBaseProvaider");
             client.Open();
            _dataSet = client.FindNameByChar(_simbol, request);
        
            DataTable dt = DataSet.Tables[0];
            
            foreach (DataRow row in dt.Rows)
            {
                Person person = new Person(row);
                _persons.Add(person);
            }
            client.Close();
        }
        public void AddEmployee(int request)
        {
            var client = new Employee.DataProvaiderClient("BasicHttpBinding_IDataProvaider");
            client.Open();
            _dataSet = client.FindEmployByChar(_simbol, request);

            DataTable dt = DataSet.Tables[0];
            
            if (_persons == null)
            {
                _persons = new List<Person>();
            }

            foreach (DataRow row in  dt.Rows)
            {
                Person person = new Person(row);
                _persons.Add(person);
            }
            client.Close();
        }

    }
}
