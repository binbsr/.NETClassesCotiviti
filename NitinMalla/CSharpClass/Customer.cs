namespace  Customers
{
    using System;
         public class Customer
    {
        private byte customerId;
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private string phoneNo;
        private DateTime dob;
        //private gender
        private string userName;
        private string password;

        public Customer()
        {

        }

/*        public Customer(firstName,lastName)
        {

        }

    }
*/
     enum gender { Male,Female,Other }
    }   
}