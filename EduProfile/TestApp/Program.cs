using BLL.Repository;
using Entity.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User() { Birth=DateTime.Now, CreatedAt=DateTime.Now, Email="burakozn@gmail.com", LastName="OZEN", Name="Ahmet", CreatedBy="Burak", PictureURL="asdas", Password="124", UpdatedAt=DateTime.Now, UpdatedBy=".can" };
            BaseRepository<User> br = new BaseRepository<User>();

            //var a = br.Add(usr);
            //a.Wait();
            var test = br.Get();
            test.Wait();
            List<User> users = test.Result;

            Console.ReadLine();
        }
    }
}
