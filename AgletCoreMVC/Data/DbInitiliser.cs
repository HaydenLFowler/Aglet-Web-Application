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
            InitialisePaymentCards(context);
            InitialiseContacts(context);
            InitialiseStaff(context);
            InitialiseUsers(context);
            InitialiseLaces(context);
            InitialiseOrders(context);
            InitialiseItems(context);
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
                new User
                {
                    FirstName = "Leon",
                    Surname = "Garza",
                    IsCustomer = true,
                    IsStaff = false,
                    AddressID = 1,
                    ContactID = 1
                },
                new User
                { FirstName = "Tracey ", Surname = "Klein", IsCustomer = true, IsStaff = false, AddressID = 1,
                    ContactID = 1},
                new User
                { FirstName = "Andrew", Surname = "Day", IsCustomer = true, IsStaff = false, AddressID = 2,
                    ContactID = 2},
                new User{FirstName = "Bruce", Surname = "Fowler", IsCustomer = true, IsStaff = false, AddressID = 3,
                    ContactID = 3},
                new User{FirstName = "Frank", Surname = "Gardner", IsCustomer = true, IsStaff = false, AddressID = 4,
                    ContactID = 4},
                new User{FirstName = "Louise", Surname = "Wolfe", IsCustomer = true, IsStaff = false, AddressID = 5,
                    ContactID = 5},
                new User{FirstName = "Robyn", Surname = "Guzman", IsCustomer = true, IsStaff = false, AddressID = 6,
                    ContactID = 6},
                new User{FirstName = "Arnold", Surname = "Foster", IsCustomer = true, IsStaff = false, AddressID = 7,
                    ContactID = 7},
                new User{FirstName = "Joe", Surname = "Salazar", IsCustomer = true, IsStaff = false, AddressID = 8,
                    ContactID = 8},
                new User{FirstName = "Conor", Surname = "Hudson", IsCustomer = true, IsStaff = false, AddressID = 9,
                    ContactID = 9},
                new User{FirstName = "Hayden", Surname = "Perkins", IsCustomer = true, IsStaff = false, AddressID = 10,
                    ContactID = 10},
                new User{FirstName = "Hew", Surname = "Reed", IsCustomer = true, IsStaff = false, AddressID = 11,
                    ContactID = 11},
                new User{FirstName = "Kelly", Surname = "Paul", IsCustomer = true, IsStaff = false, AddressID = 12,
                    ContactID = 12},
                new User{FirstName = "William", Surname = "Nash", IsCustomer = true, IsStaff = false, AddressID = 13,
                    ContactID = 13},
                new User{FirstName = "Jess", Surname = "Wright", IsCustomer = true, IsStaff = false, AddressID = 14,
                    ContactID = 14},
                new User{FirstName = "Riley", Surname = "Mitchell", IsCustomer = true, IsStaff = false, AddressID = 15,
                    ContactID = 15},
                new User{FirstName = "Sienna", Surname = "Malone", IsCustomer = true, IsStaff = false, AddressID = 16,
                    ContactID = 16},
                new User{FirstName = "Zack", Surname = "Kent", IsCustomer = true, IsStaff = false, AddressID = 17,
                    ContactID = 17},
                new User{FirstName = "Owen", Surname = "Calrk", IsCustomer = true, IsStaff = false, AddressID = 18,
                    ContactID = 18},
                new User{FirstName = "Spencer", Surname = "Heron", IsCustomer = true, IsStaff = false, AddressID = 19,
                    ContactID = 19},
                new User{FirstName = "Evelyn", Surname = "Stanley", IsCustomer = true, IsStaff = false, AddressID = 20,
                    ContactID = 20},
                new User{FirstName = "John", Surname = "Watkins", IsCustomer = true, IsStaff = true, AddressID = 21,
                    ContactID = 21, StaffID = 1},
                new User{FirstName = "Eddy", Surname = "Hardy", IsCustomer = true, IsStaff = true, AddressID = 22,
                    ContactID = 22, StaffID = 2},
                new User{FirstName = "Nick", Surname = "Reynolds", IsCustomer = false, IsStaff = true, AddressID = 23,
                    ContactID = 23, StaffID = 3},
                new User{FirstName = "Lisa", Surname = "Mathis", IsCustomer = false, IsStaff = true, AddressID = 24,
                    ContactID = 24, StaffID = 4},
                new User{FirstName = "Alice", Surname = "Williams", IsCustomer = false, IsStaff = true, AddressID = 25,
                    ContactID = 25, StaffID = 5},
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
                new Staff {Department = Staff.Departments.Finance, JobTitle = Staff.JobTitles.Accountant, Salary = 28935.00m},
                new Staff {Department = Staff.Departments.HQ, JobTitle = Staff.JobTitles.Manager, Salary = 63420.00m},
                new Staff {Department = Staff.Departments.HR, JobTitle = Staff.JobTitles.Supervisor, Salary = 35320.00m},
                new Staff {Department = Staff.Departments.Sales, JobTitle = Staff.JobTitles.SalesStaff, Salary = 25125.00m},
                new Staff {Department = Staff.Departments.Support, JobTitle = Staff.JobTitles.CustomerAssistant, Salary = 23500.00m},
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
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.received, SubTotal = 2.50m, UserID = 1},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.delivered, SubTotal = 5.00m, UserID = 2},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.intransit, SubTotal = 7.50m, UserID = 3},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.delivered, SubTotal = 25.00m, UserID = 4},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.received, SubTotal = 17.00m, UserID = 5},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.intransit, SubTotal = 4.50m, UserID = 6},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.received, SubTotal = 5.50m, UserID = 7},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.intransit, SubTotal = 12.50m, UserID = 8},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.intransit, SubTotal = 9.00m, UserID = 9},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.delivered, SubTotal = 7.50m, UserID = 10},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.received, SubTotal = 17.50m, UserID = 11},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.delivered, SubTotal = 25.50m, UserID = 12},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.intransit, SubTotal = 2.00m, UserID = 13},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.received, SubTotal = 43.50m, UserID = 14},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.delivered, SubTotal = 13.20m, UserID = 15},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.intransit, SubTotal = 11.00m, UserID = 16},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.delivered, SubTotal = 19.50m, UserID = 17},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.delivered, SubTotal = 1.50m, UserID = 18},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.delivered, SubTotal = 5.00m, UserID = 19},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.intransit, SubTotal = 22.00m, UserID = 20},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.intransit, SubTotal = 8.00m, UserID = 21},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.received, SubTotal = 22.10m, UserID = 22},
                new Order {DateOrdered = DateTime.Now, Status = OrderStatus.intransit, SubTotal = 10.00m, UserID = 23}
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
                new Lace {Colour = Colours.Pink, Brand = Brands.Fila, Length = 10, ImageURL = "Image3.co.uk", Description = "A great lace"},
                new Lace {Colour = Colours.Yellow, Brand = Brands.Adidas, Length = 15, ImageURL = "Adidas15Lace.co.uk", Description = "One of a kind"},
                new Lace {Colour = Colours.Green, Brand = Brands.UnderArmour, Length = 19, ImageURL = "thatUnderArmour.co.uk", Description = "Simply the best"},
                new Lace {Colour = Colours.Black, Brand = Brands.Lacoste, Length = 12, ImageURL = "DamnDaniel.co.uk", Description = "Sporty and colourful"},
                new Lace {Colour = Colours.Cyan, Brand = Brands.Puma, Length = 15, ImageURL = "Wowcher123.co.uk", Description = "On the older range of laces but the quality still holds up today"},
                new Lace {Colour = Colours.Red, Brand = Brands.Champion, Length = 11, ImageURL = "DatImage.co.uk"},
                new Lace {Colour = Colours.Green, Print = "Who Dat Boi", Brand = Brands.Ellesse, Length = 22, ImageURL = "GOLF.co.uk", Description = "Who him is?"},
                new Lace {Colour = Colours.Pink, Print = "Happy Birthday", Brand = Brands.Adidas, Length = 10, ImageURL = "pictures.com"},
                new Lace {Colour = Colours.Blue, Brand = Brands.Champion, Length = 16, ImageURL = "greenlace.com", Description = "A new and exciting pink lace"},
                new Lace {Colour = Colours.Purple, Print = "Hello", Brand = Brands.Kappa, Length = 14, ImageURL = "Wow.com",},
                new Lace {Colour = Colours.White, Brand = Brands.Reebok, Length = 10, ImageURL = "Image7.co.uk", Description = "A Classic!!!"},
                new Lace {Colour = Colours.Grey, Brand = Brands.Fila, Length = 11, ImageURL = "Imagine.co.uk"},
                new Lace {Colour = Colours.Pink, Print = "Kick it", Brand = Brands.Nike, Length = 14, ImageURL = "Images123456787919.co.uk"},
                new Lace {Colour = Colours.Yellow, Print = "Congrats Johny", Brand = Brands.Jordan, Length = 5, ImageURL = "TimesNewRoman.co.uk", Description = "A good lace to gift to someone special"},
                new Lace {Colour = Colours.Blue, Brand = Brands.Puma, Length = 17, ImageURL = "heyheyhey.co.uk"},
                new Lace {Colour = Colours.Pink, Brand = Brands.Reebok, Length = 11, ImageURL = "3guys.co.uk"},
                new Lace {Colour = Colours.Cyan, Print = "Happy Mothers Day", Brand = Brands.Adidas, Length = 15, ImageURL = "Mother.co.uk", Description = "For that special day"},
                new Lace {Colour = Colours.Yellow, Brand = Brands.Fila, Length = 10, ImageURL = "Image10.co.uk"}
            };

            foreach (Lace a in laces)
            {
                context.Lace.Add(a);
            }

            context.SaveChanges();
        }

        //Seed Data by Hayden
        private static void InitialiseItems(ApplicationDbContext context)
        {
            if (context.Item.Any())
            {
                return;
            }

            var items = new Item[]
            {
                new Item{Quantity = 3, Price = 20.50m, LaceID = 1, OrderID = 1,},
                new Item{Quantity = 1, Price = 5m, LaceID = 3, OrderID = 2,},
                new Item{Quantity = 15, Price = 45.30m, LaceID = 5, OrderID = 3,},
                new Item{Quantity = 6, Price = 19.00m, LaceID = 2, OrderID = 4,},
                new Item{Quantity = 8, Price = 33.00m, LaceID = 10, OrderID = 5,},
                new Item{Quantity = 1, Price = 2.00m, LaceID = 11, OrderID = 6,},
                new Item{Quantity = 9, Price = 18.00m, LaceID = 6, OrderID = 7,},
                new Item{Quantity = 20, Price = 55.00m, LaceID = 1, OrderID = 8,},
                new Item{Quantity = 90, Price = 115.36m, LaceID = 15, OrderID = 9,},
                new Item{Quantity = 4, Price = 8.25m, LaceID = 20, OrderID = 10,},
                new Item{Quantity = 6, Price = 11.70m, LaceID = 14, OrderID = 11,},
                new Item{Quantity = 14, Price = 16.40m, LaceID = 7, OrderID = 12,},
                new Item{Quantity = 7, Price = 9.25m, LaceID = 4, OrderID = 13,},
                new Item{Quantity = 10, Price = 31.05m, LaceID = 11, OrderID = 14,},
                new Item{Quantity = 30, Price = 64.21m, LaceID = 18, OrderID = 15,},
                new Item{Quantity = 26, Price = 44.00m, LaceID = 13, OrderID = 16,},
                new Item{Quantity = 8, Price = 24.99m, LaceID = 2, OrderID = 17,},
                new Item{Quantity = 2, Price = 4.50m, LaceID = 5, OrderID = 18,},
                new Item{Quantity = 1, Price = 3.60m, LaceID = 19, OrderID = 19,},
                new Item{Quantity = 5, Price = 8.99m, LaceID = 8, OrderID = 20,},


            };

            foreach (Item a in items)
            {
                context.Item.Add(a);
            }

            context.SaveChanges();
        }

        private static void InitialiseContacts(ApplicationDbContext context)
        {
            if (context.Contact.Any())
            {
                return;
            }

            var contacts = new Contact[]
            {
                new Contact {Email = "TheRightfulcustomer@gmail.com", Phone = "07885979893"},
                new Contact {Email = "TheHumorouscustomer@gmail.com", Phone = "07700 900347"},
                new Contact {Email = "TheCutcustomer@gmail.com", Phone = "07700 900295"},
                new Contact {Email = "TheDisgustingcustomer@gmail.com", Phone = "07700 900005"},
                new Contact {Email = "gamma@outlook.com", Phone = "07700900485"},
                new Contact {Email = "sokol@hotmail.com", Phone = "07700900029"},
                new Contact {Email = "mhouston@live.com", Phone = "07700900249"},
                new Contact {Email = "jyoliver@gmail.com", Phone = "07811270000"},
                new Contact {Email = "pfitza@gmail.com", Phone = "07867290000"},
                new Contact {Email = "andrei@hotmail.com", Phone = "07896740000"},
                new Contact {Email = "kiddailey@hotmail.com", Phone = "07049519971"},
                new Contact {Email = "oracle@gmail.com", Phone = "07918103448"},
                new Contact {Email = "raides@msn.com", Phone = "07720524101"},
                new Contact {Email = "Jaffe@gmail.com", Phone = "07030216070"},
                new Contact {Email = "msloan@gmail.com", Phone = "07712129738"},
                new Contact {Email = "jbearp@outlook.com", Phone = "07001263673"},
                new Contact {Email = "twoflower@yahoo.com", Phone = "07737908103"},
                new Contact {Email = "zeller@hotmail.com", Phone = "07854418459"},
                new Contact {Email = "malin@msn.com", Phone = "07886545833"},
                new Contact {Email = "dimensio@live.com", Phone = "07976777169"},
                new Contact {Email = "jusdisgi@hotmail.com", Phone = "07777409515"},
                new Contact {Email = "pedwards@hotmail.com", Phone = "07975395614"},
                new Contact {Email = "burns@hotmail.com", Phone = "07724630714"},
                new Contact {Email = "daveed@outlook.com", Phone = "07082724859"},
                new Contact {Email = "privcan@live.com", Phone = "07906619496"},
                new Contact {Email = "camenisch@outlook.com", Phone = "07978800056"}
            };

            foreach (Contact a in contacts)
            {
                context.Contact.Add(a);
            }

            context.SaveChanges();
        }

        private static void InitialisePaymentCards(ApplicationDbContext context)
        {
            if (context.PaymentCard.Any())
            {
                return;
            }

            var paymentcards = new PaymentCard[]
            {
                new PaymentCard{ CardName = "Leon",  CardNumber = "8753 2716 2638 4597", ExpiryMonth = 12, ExpiryYear = 2023, SecurityCode = 546},
                new PaymentCard{ CardName = "Tracey",CardNumber = "2635 1728 3492 7261", ExpiryMonth = 1, ExpiryYear = 2025, SecurityCode = 963},
                new PaymentCard{ CardName = "Bruce", CardNumber = "5627 2651 4289 9283", ExpiryMonth = 2, ExpiryYear = 2028, SecurityCode = 240},
                new PaymentCard{ CardName = "Frank", CardNumber = "6178 2531 5432 7766", ExpiryMonth = 11, ExpiryYear = 2020, SecurityCode = 663},
                new PaymentCard{ CardName = "Zack",  CardNumber = "2445 3311 7665 0998", ExpiryMonth = 7, ExpiryYear = 2023, SecurityCode = 922},
                new PaymentCard{ CardName = "Owen",  CardNumber = "5918 2712 0099 4433", ExpiryMonth = 4, ExpiryYear = 2025, SecurityCode = 248},
                new PaymentCard{ CardName = "Hayden",CardNumber = "5918 6372 8675 2245", ExpiryMonth = 3, ExpiryYear = 2026, SecurityCode = 348},
                new PaymentCard{ CardName = "Jess",  CardNumber = "7653 5564 9122 0675", ExpiryMonth = 9, ExpiryYear = 2025, SecurityCode = 553},
                new PaymentCard{ CardName = "Conor", CardNumber = "6563 7834 3356 0092", ExpiryMonth = 12, ExpiryYear = 2021, SecurityCode = 341},
                new PaymentCard{ CardName = "Alice", CardNumber = "2352 8876 2826 9820", ExpiryMonth = 11, ExpiryYear = 2026, SecurityCode = 232},
                new PaymentCard{ CardName = "Lisa",  CardNumber = "3343 6253 8272 9826", ExpiryMonth = 1, ExpiryYear = 2020, SecurityCode = 764},
                new PaymentCard{ CardName = "Hew",   CardNumber = "8732 8374 9826 3822", ExpiryMonth = 3, ExpiryYear = 2023, SecurityCode = 983},
                new PaymentCard{ CardName = "Joe",   CardNumber = "7653 5564 9122 0675", ExpiryMonth = 9, ExpiryYear = 2025, SecurityCode = 012},
                new PaymentCard{ CardName = "Robyn", CardNumber = "9384 8273 9938 0032", ExpiryMonth = 6, ExpiryYear = 2022, SecurityCode = 007},
                new PaymentCard{ CardName = "Nick",  CardNumber = "8376 7362 9386 9936", ExpiryMonth = 2, ExpiryYear = 2025, SecurityCode = 726},
                new PaymentCard{ CardName = "John",  CardNumber = "7465 8837 2263 9836", ExpiryMonth = 9, ExpiryYear = 2029, SecurityCode = 874},
                new PaymentCard{ CardName = "Arnold", CardNumber = "5364 6322 8374 7364", ExpiryMonth = 1, ExpiryYear = 2023, SecurityCode = 984},
                new PaymentCard{ CardName = "William",CardNumber = "6474 3362 9484 3629 ", ExpiryMonth = 10, ExpiryYear = 2021, SecurityCode = 645},
                new PaymentCard{ CardName = "Riley",  CardNumber = "7464 3362 7443 8367", ExpiryMonth = 2, ExpiryYear = 2020, SecurityCode = 474},
                new PaymentCard{ CardName = "Sienna", CardNumber = "7364 6352 3336 8376", ExpiryMonth = 4, ExpiryYear = 2022, SecurityCode = 734},
                new PaymentCard{ CardName = "Spencer", CardNumber = "7465 8837 0039 1263", ExpiryMonth = 8, ExpiryYear = 2025, SecurityCode = 544},
            };

            foreach (PaymentCard a in paymentcards)
            {
                context.PaymentCard.Add(a);
            }

            context.SaveChanges();
        }
    }
}
