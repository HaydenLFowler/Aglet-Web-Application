using AgletCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgletCoreMVC.Data
{
    public static class DbInitialiser
    {
        public static void Initialise (ApplicationDbContext context)
        {
            //InitialiseAddresses(context);
            //InitialiseUsers(context);
            
        }

        //User seed data done by Hayden
        private static void InitialiseUsers(ApplicationDbContext context)
        {
            if(context.User.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User{FirstName = "Leon", Surname = "Garza", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Tracey ", Surname = "Klein", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Andrew", Surname = "Day", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Bruce", Surname = "Fowler", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Frank", Surname = "Gardner", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Louise", Surname = "Wolfe", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Robyn", Surname = "Guzman", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Arnold", Surname = "Foster", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Joe", Surname = "Salazar", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Conor", Surname = "Hudson", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Hayden", Surname = "Perkins", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Hew", Surname = "Reed", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Kelly", Surname = "Paul", IsCustomer = true, IsStaff = false},
                new User{FirstName = "William", Surname = "Nash", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Jess", Surname = "Wright", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Riley", Surname = "Mitchell", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Sienna", Surname = "Malone", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Zack", Surname = "Kent", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Owen", Surname = "Calrk", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Spencer", Surname = "Heron", IsCustomer = true, IsStaff = false},
                new User{FirstName = "Evelyn", Surname = "Stanley", IsCustomer = true, IsStaff = false},
                new User{FirstName = "John", Surname = "Watkins", IsCustomer = true, IsStaff = true},
                new User{FirstName = "Eddy", Surname = "Hardy", IsCustomer = true, IsStaff = true},
                new User{FirstName = "Nick", Surname = "Reynolds", IsCustomer = false, IsStaff = true},
                new User{FirstName = "Lisa", Surname = "Mathis", IsCustomer = false, IsStaff = true},
                new User{FirstName = "Alice", Surname = "Williams", IsCustomer = false, IsStaff = true},



            };

            foreach (User a in users)
            {
                context.User.Add(a);
            }

            context.SaveChanges();
        }

        //Address seed data done by Hayden
        private static void InitialiseAddresses(ApplicationDbContext context)
        {
            if(context.Address.Any())
            {
                return;
            }

            var addresses = new Address[]
            {
                new Address {StreetAddress = "66  Northgate Street", Town = "BIDDENDEN", Country = Countries.GB, PostCode = "TN27 6PH"},
                new Address {StreetAddress = "11  Pendwyallt Road", Town = "SKAILL", Country = Countries.GB, PostCode = "KW16 7QG"},
                new Address {StreetAddress = "24  Petworth Rd", Town = "BREAM", Country = Countries.IT, PostCode = "GL15 9NA"},
                new Address {StreetAddress = "137  Stroude Road", Town = "CREWTON", Country = Countries.US, PostCode = "DE2 3UD"},
                new Address {StreetAddress = "32  Grenoble Road", Town = "MOUNT", Country = Countries.US, PostCode = "PL30 6WG"},
                new Address {StreetAddress = "90  Carriers Road", Town = "GUITH", Country = Countries.IT, PostCode = "NG2 1BP"},
                new Address {StreetAddress = "95  Hendford Hill", Town = "THORESBY", Country = Countries.CN, PostCode = "KW17 1PZ"},
                new Address {StreetAddress = "99  Manor Close", Town = "DINORWIC", Country = Countries.DE, PostCode = "LL55 7LN"},
                new Address {StreetAddress = "62  Fox Lane", Town = "BODHAM STREET", Country = Countries.FR, PostCode = "NR25 6PW"},
                new Address {StreetAddress = "106  Rowland Rd", Town = "HORNDEAN", Country = Countries.FR, PostCode = "TD15 2WP"},
                new Address {StreetAddress = "28  St James Boulevard", Town = "OSMOTHERLEY", Country = Countries.FR, PostCode = "DL6 6FZ"},
                new Address {StreetAddress = "45  Guildford Rd", Town = "PULHAM MARKET", Country = Countries.FR, PostCode = "SN8 0FH"},
                new Address {StreetAddress = "73  St Maurices Road", Town = "EAST KENNETT", Country = Countries.CN, PostCode = "IP21 4ZG"},
                new Address {StreetAddress = "117  Hertingfordbury Rd", Town = "NEWMILNS", Country = Countries.CN, PostCode = "KA16 7ZE"},
                new Address {StreetAddress = "35  Maidstone Road", Town = "WELTON LE WOLD", Country = Countries.CN, PostCode = "LN11 9XD"},
                new Address {StreetAddress = "27  Argyll Street", Town = "STALLING BUSK", Country = Countries.GB, PostCode = "DL8 2WE"},
                new Address {StreetAddress = "37  Colorado Way", Town = "RHOS-ON-SEA", Country = Countries.DE, PostCode = "LL28 0DR"},
                new Address {StreetAddress = "47  Haslemere Road", Town = "ECKFORD", Country = Countries.DE, PostCode = "TD5 8BE"},
                new Address {StreetAddress = "93  Winchester Rd", Town = "METFIELD", Country = Countries.IT, PostCode = "IP20 2UW"},
                new Address {StreetAddress = "70  Coast Rd", Town = "KIRKLEVINGTON", Country = Countries.US, PostCode = "TS15 0LN"},
                new Address {StreetAddress = "133  Lamphey Road", Town = "THE MYTHE", Country = Countries.GB, PostCode = "GL20 3JY"}
            };

            foreach (Address a in addresses)
            {
                context.Address.Add(a);
            }

            context.SaveChanges();
        }
    }
}
