using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Person
    {
        private string _firstName;
        public string _lastName;
        //public int Age { 
        //    get; set;
        //}
        private int _age;

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            Age = age;
        }

        public Person()
        {
        }
        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public bool BlowUpWorld(string password)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }
    }

    // code to add
    //public class Person
    //{
    //    private string _firstName;
    //    private string _lastName;
    //    private int _age;
    //    public Person(string fName, string lName)
    //    {
    //        _firstName = fName;
    //        _lastName = lName;
    //    }

    //    public int Age { get; set; }
    //    public int Age { get; private set; }
    //    public int Age { get; }
    //    public int Age {
    //        get{ return _age; }
    //        set { _age = value; }
    //    }
    //public int Age
    //{
    //    get { return _age; }
    //    set { if (value >= 0) _age = value; }
    //}


    //    public int Age { 
    //        get{ return _age; }
    //        set { _age = value; }
    //        set { if (value >= 0) _age = value; }
    //    }
    //    public string FullName
    //    {
    //        get { return $"{_firstName} {_lastName}"; }  
    //    }
    //    public string GetFullName()
    //    {
    //        return $"{_firstName} {_lastName}";
    //    }
    //}

    // final code - starter code for Inheritance slides
    //public class Person
    //{
    //    private string _firstName;
    //    private string _lastName;
    //    private int _age;
    //    public Person(string fName, string lName)
    //    {
    //        _firstName = fName;
    //        _lastName = lName;
    //    }

    //    public int Age
    //    {
    //        get { return _age; }
    //        set { if (value >= 0) _age = value; }
    //    }

    //    public string GetFullName()
    //    {
    //        return $"{_firstName} {_lastName}";
    //    }
    //}

    // final code for Inheritance slides
    //public class Person
    //{
    //    private string _firstName;
    //    private string _lastName;
    //    private int _age;
    //    public Person() { }
    //    public Person(string fName, string lName)
    //    {
    //        _firstName = fName;
    //        _lastName = lName;
    //    }

    //    public int Age
    //    {
    //        get { return _age; }
    //        set { if (value >= 0) _age = value; }
    //    }

    //    public string GetFullName()
    //    {
    //        return $"{_firstName} {_lastName}";
    //    }

    //    public override string ToString()
    //    {
    //        return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
    //    }
    //}
}
