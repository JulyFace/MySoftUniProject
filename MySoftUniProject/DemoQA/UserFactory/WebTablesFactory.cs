using DemoQA.UserModel;
using System.ComponentModel.DataAnnotations;

namespace DemoQA.UserFactory
{
    
    public class WebTablesFactory
    {
        public static WebTablesModel UserData()
        {
            return new WebTablesModel
            {
                FirstName = "Juliano",

                LastName = "Borichelo",

                Age = "33",

                Email = "abv@gmail.com",

                Salary = "20000",

                Department = "IT",


            };

        }

       

    }


    
}
