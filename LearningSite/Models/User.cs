using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningSite.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public User() { }

        public User(int aID, string aName)
        {
            this.ID = aID;
            this.Name = aName;
        }
    }
}