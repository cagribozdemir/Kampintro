using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamermanager = new GamerManager(new UserValidationManager());
            gamermanager.Add(new Gamer { BirthYear = 1986, FirstName = "Engin", Id = 1, IdentityNumber = 12345, LastName = "Demiroğ" });
        }
    }
}