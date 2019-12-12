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

        private static void InitialiseUsers(ApplicationDbContext context)
        {
        }

        private static void InitialiseAddresses(ApplicationDbContext context)
        {
            if(context.Address.Any())
            {
                return;
            }

            var addresses = new Address[]
            {
                new Address
                {
                    StreetAddress = "High Street"
                }
            };

            foreach (Address a in addresses)
            {
                context.Address.Add(a);
            }

            context.SaveChanges();
        }
    }
}
