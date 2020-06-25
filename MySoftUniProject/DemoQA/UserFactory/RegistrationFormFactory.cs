using AutoFixture;
using DemoQA.UserModel;

namespace DemoQA.UserFactory
{
    public class RegistrationFormFactory
    {
        public static RegistrationFormModel CreateUser()
        {


            var fixture = new Fixture();
            string mail = fixture.Create<string>() + "@gmail.com";



            return new RegistrationFormModel

            {
                FirstName = "Testercho",

                LastName = "HadzhiCodev",

                Email = mail,

                Phone = "0888888888",

                Address = "Botev Street",

                City = "Sofia",


            };























        }



    }
}
