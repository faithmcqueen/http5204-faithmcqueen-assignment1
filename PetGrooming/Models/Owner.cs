﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Owner
    {
        /*
            An owner is someone who owns one or more pets
            Some things that describe an owner:
                - First Name
                - Last Name
                - Address
                - Phone Number (work)
                - Phone Number (home)  */

        [Key]
        public int OwnerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }

 
        // An owner must reference a list of pets
           

    }
}