using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderWorkerManagement.Domain.Entities
{
    public abstract class  EntityData
    {

       public string LastName {get; set;}
       public string FirstName {get; set;}
       public string Address {get; set;}
       public string Phone {get; set;}
       public string Email {get;set;}

       public EntityData (string lastName, string firstName, string address, string email)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Address = address;
            this.Email = email;
        }

        protected EntityData()
        {
        }

        public abstract string showId();
    }
}