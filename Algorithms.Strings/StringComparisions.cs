using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class StringComparisions
    {
        public void TryStringComparisions()
        {
            int i1 = 5; int i2 = 5; int i3 = 1; int i4 = 2;

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Value Types : Comparing two Integers with same value");
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine(" i1 == i2 : {0}", i1 == i2);
            Console.WriteLine(" i1.Equals(i2) :{0}", i1.Equals(i2));
            Console.WriteLine(" Object.Equals(i1,i2) :{0}", object.Equals(i1, i2));
            Console.WriteLine(" Object.ReferenceEquals(i1,i2):{0}", object.ReferenceEquals(i1, i2));
            Console.WriteLine(" i1 Hashcode == i2 HashCode : {0} ", i1.GetHashCode() == i2.GetHashCode());


            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Value Types : Comparing two Integers with different value");
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine(" i3 == i4 :{0} ", i3 == i4);
            Console.WriteLine(" i3.Equals(i4) :{0}", i3.Equals(i4));
            Console.WriteLine(" Object.Equals(i3,i4) :{0}", object.Equals(i3, i4));
            Console.WriteLine(" Object.ReferenceEquals(i3,i4):{0}", object.ReferenceEquals(i3, i4));
            Console.WriteLine(" i3 Hashcode == i4 HashCode : {0} ", i3.GetHashCode() == i4.GetHashCode());




            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);

            Person p3 = new Person("Homer", "Simpson", 50);
            Person p4 = new Person("Gopal", "Krishna", 80);



            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Reference Types : Comparing two Objects with same state");
            Console.WriteLine("-------------------------------------------------------------------------");



            Console.WriteLine(" p1 == p2 : {0}", p1 == p2);
            Console.WriteLine(" p1.Equals(p2) :{0}", p1.Equals(p2));
            Console.WriteLine(" Object.Equals(p1,p2) :{0}", object.Equals(p1, p2));
            Console.WriteLine(" Object.ReferenceEquals(p1,p2):{0}", object.ReferenceEquals(p1, p2));
            Console.WriteLine(" p1 Hashcode == p2 HashCode : {0} ", p1.GetHashCode() == p2.GetHashCode());


            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Reference Types : Comparing two Objects with different state");
            Console.WriteLine("-------------------------------------------------------------------------");


            Console.WriteLine(" p3 == p4 :{0} ", p3 == p4);
            Console.WriteLine(" p3.Equals(p4) :{0}", p3.Equals(p4));
            Console.WriteLine(" Object.Equals(p3,p4) :{0}", object.Equals(p3, p4));
            Console.WriteLine(" Object.ReferenceEquals(p3,p4):{0}", object.ReferenceEquals(p3, p4));
            Console.WriteLine(" p3 Hashcode == p4 HashCode : {0} ", p3.GetHashCode() == p4.GetHashCode());


            String s1 = "Gopala is great";
            String s2 = "Gopala is great";

            String s3 = "Gopala is great";
            String s4 = "Krishna is great";

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Strings : Comparing two strings with same state");
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine(" S1 == S2 : {0}", s1 == s2);
            Console.WriteLine(" S1.Equals(S2) :{0}", s1.Equals(s2));
            Console.WriteLine(" Object.Equals(S1,S2) :{0}", object.Equals(s1, s2));
            Console.WriteLine(" Object.ReferenceEquals(S1,S2):{0}", object.ReferenceEquals(s1, s2));
            Console.WriteLine(" S1 Hashcode == S2 HashCode : {0} ", s1.GetHashCode() == s2.GetHashCode());


            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Strings : Comparing two strings with different state");
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine(" S3 == S4 :{0} ", s3 == s4);
            Console.WriteLine(" S3.Equals(S4) :{0}", s3.Equals(s4));
            Console.WriteLine(" Object.Equals(S3,S4) :{0}", object.Equals(s3, s4));
            Console.WriteLine(" Object.ReferenceEquals(S3,S4):{0}", object.ReferenceEquals(s3, s4));
            Console.WriteLine(" S3 Hashcode == S4 HashCode : {0} ", s3.GetHashCode() == s4.GetHashCode());



        }
    }

    #region Person type
    class Person
    {
        private string fName;
        private string lName;
        private byte personAge;

        public Person() { }

        public Person(string firstName, string lastName, byte age)
        {
            fName = firstName;
            lName = lastName;
            personAge = age;
        }

        #region System.Object overrides
        public override string ToString()
        {
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", fName, lName, personAge);
            return myState;
        }
        #endregion
        #endregion

    }


}
