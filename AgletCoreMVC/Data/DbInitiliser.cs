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
            InitialiseAddresses(context);
            IntialisePaymentCards(context);

            //IntialiseContacts(context);
            //InitliaseStaff(context);
            //InitialiseUsers(context);
            //InitialiseLaces(context);
            //InitialiseOrders(context);


        }

        private static void InitliaseStaff(ApplicationDbContext context)
        {
            throw new NotImplementedException();
        }

        private static void IntialiseContacts(ApplicationDbContext context)
        {
            throw new NotImplementedException();
        }

        private static void IntialisePaymentCards(ApplicationDbContext context)
        {
            throw new NotImplementedException();
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
                new Address {StreetAddress = "13  Lamphey Road", Town = "THE MYTHE", Country = Countries.GB, PostCode = "GL20 3JY"},
                new Address {StreetAddress = "19  Lamp Road", Town = "MYTHE", Country = Countries.GB, PostCode = "GL2 4HG"},
                new Address {StreetAddress = "92  Traill Street", Town = "ROSEMOUNT", Country = Countries.GB, PostCode = "HP9 1AP"},
                new Address {StreetAddress = "56  Scrimshire Lane", Town = "ASTON", Country = Countries.GB, PostCode = "AR3 5JG"},
                new Address {StreetAddress = "75  Witney Way", Town = "KIRKTOWN OF DESKFORD", Country = Countries.GB, PostCode = "GL12 7RF"},
                new Address {StreetAddress = "26  Thames Street", Town = "BONCHESTER BRIDGE", Country = Countries.GB, PostCode = "AH11 2AK"}
            };

            foreach (Address a in addresses)
            {
                context.Address.Add(a);
            }

            context.SaveChanges();
        }

        private static void InitialiseStaff(ApplicationDbContext context)
        {
            if (context.Staff.Any())
            {
                return;
            }

            var staff = new Staff[]
            {
                new Staff {Department = Staff.Departments.Finance, JobTitle = Staff.JobTitles.Accountant, Salary = 28935},
                new Staff {Department = Staff.Departments.HQ, JobTitle = Staff.JobTitles.Manager, Salary = 63420},
                new Staff {Department = Staff.Departments.HR, JobTitle = Staff.JobTitles.Supervisor, Salary = 35320},
                new Staff {Department = Staff.Departments.Sales, JobTitle = Staff.JobTitles.SalesStaff, Salary = 25125},
                new Staff {Department = Staff.Departments.Support, JobTitle = Staff.JobTitles.CustomerAssistant, Salary = 23500},


            };

            foreach (Staff a in staff)
            {
                context.Staff.Add(a);
            }

            context.SaveChanges();
        }

        //Seed data by Conor
        private static void InitialiseOrders(ApplicationDbContext context)
        {
            if (context.Order.Any())
            {
                return;
            }
            var orders = new Order[]
            {
                new Order {Date = DateTime.Now, Status = OrderStatus.received, SubTotal = "£2.50"},
                new Order {Date = DateTime.Now, Status = OrderStatus.delivered, SubTotal = "£5.00"},
                new Order {Date = DateTime.Now, Status = OrderStatus.intransit, SubTotal = "£7.50"}
            };

            foreach (Order a in orders)
            {
                context.Order.Add(a);
            }

            context.SaveChanges();
        }

        //Seed data by Conor
        private static void InitialiseLaces(ApplicationDbContext context)
        {
            if (context.Lace.Any())
            {
                return;
            }
            var laces = new Lace[]
            {
                new Lace {Colour = Colours.Black, Print = "Blue Lace", Brand = Brands.Nike, Length = 10, ImageURL = "Image.com", Description = "One of the best"},
                new Lace {Colour = Colours.Green, Brand = Brands.UnderArmour, Length = 20, ImageURL = "Image2.com"},
                new Lace {Colour = Colours.Pink, Brand = Brands.Adidas, Length = 10, ImageURL = "Image3.co.uk", Description = "A great lace"}
            };

            foreach (Lace a in laces)
            {
                context.Lace.Add(a);
            }

            context.SaveChanges();
        }


        /* private static void InitialiseItem(ApplicationDbContext context)
         {
             if (context.Item.Any())
             {
                 return;
             }

             var items = new Item[]
             {



             };

             foreach (Item a in items)
             {
                 context.Item.Add(a);
             }

             context.SaveChanges();
         }*/
    }
}
