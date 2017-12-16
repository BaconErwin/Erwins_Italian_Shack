using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erwins_Italian_Shack.Domain.Infrastructure
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataAccess>
    {
        protected override void Seed(DataAccess db)
        {
            #region Users
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Erwin",
                    LastName = "Gallo",
                    Password = "123123",
                    UserName = "erwingallo",
                    Role = Models.Enums.Role.Admin
                }
             );
            db.SaveChanges();
            db.Users.Add(
              new Models.User()
              {
                  Id = Guid.NewGuid(),
                  FirstName = "Kelvin",
                  LastName = "Ili",
                  Password = "123123",
                  UserName = "kelvinili",
                  Role = Models.Enums.Role.Admin
              }
           );
            db.SaveChanges();
            db.Users.Add(
              new Models.User()
              {
                  Id = Guid.NewGuid(),
                  FirstName = "Allan",
                  LastName = "Novalta",
                  Password = "123123",
                  UserName = "allannovalta",
                  Role = Models.Enums.Role.Waiter
              }
           );
            db.SaveChanges();
            db.Users.Add(
              new Models.User()
              {
                  Id = Guid.NewGuid(),
                  FirstName = "Wendell",
                  LastName = "Aton",
                  Password = "123123",
                  UserName = "wendellaton",
                  Role = Models.Enums.Role.Waiter
              }
           );
            db.SaveChanges();
            db.Users.Add(
              new Models.User()
              {
                  Id = Guid.NewGuid(),
                  FirstName = "Hayna",
                  LastName = "Mallo",
                  Password = "123123",
                  UserName = "haynamallo",
                  Role = Models.Enums.Role.Cashier
              }
           );
            db.SaveChanges();
            db.Users.Add(
              new Models.User()
              {
                  Id = Guid.NewGuid(),
                  FirstName = "Shane",
                  LastName = "Maravillo",
                  Password = "123123",
                  UserName = "shanemaravillo",
                  Role = Models.Enums.Role.Cashier
              }
           );
            db.SaveChanges();
            db.Users.Add(
              new Models.User()
              {
                  Id = Guid.NewGuid(),
                  FirstName = "Jane",
                  LastName = "Ticar",
                  Password = "123123",
                  UserName = "janeticar",
                  Role = Models.Enums.Role.Chef
              }
           );
            db.SaveChanges();
            db.Users.Add(
              new Models.User()
              {
                  Id = Guid.NewGuid(),
                  FirstName = "Larich",
                  LastName = "Morales",
                  Password = "123123",
                  UserName = "larichmorales",
                  Role = Models.Enums.Role.InventoryController
              }
           );
            db.SaveChanges();
            db.Users.Add(
              new Models.User()
              {
                  Id = Guid.NewGuid(),
                  FirstName = "Nizan",
                  LastName = "Casupanan",
                  Password = "123123",
                  UserName = "nizancasupanan",
                  Role = Models.Enums.Role.Chef
              }
           );
            db.SaveChanges();
            db.Users.Add(
              new Models.User()
              {
                  Id = Guid.NewGuid(),
                  FirstName = "Goshen",
                  LastName = "Jimenez",
                  Password = "123123",
                  UserName = "goshenjimenez",
                  Role = Models.Enums.Role.InventoryController
              }
           );
            db.SaveChanges();
            #endregion
        }
    }
}
