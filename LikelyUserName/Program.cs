using System;

namespace LikelyUserName
{
    
    internal class Program
    {
        public delegate bool LikelyUsername(Name name);
        static void Main(string[] args)
        {
            LikelyUsername dUserCount = delegate (Name name)
            {
                return name.UserName == (name.likelyUserName = name.FirstName + "." + name.LastName);
            };

            Name personOne = new Name();
            personOne.FirstName = "Ephraim";
            personOne.LastName = "Usoroh";
            personOne.UserName = "Ephraim.Usoroh";
            Console.WriteLine(dUserCount(personOne));
        }

    }
}