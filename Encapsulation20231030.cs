using System;

namespace Encapsulation
{
    class User
    {
        private string name;
        private string location;

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    public class Program 
    {
        public static void Main(string[] args)
        {
            User userObject = new User();
            userObject.Name = "Gautam Jaisawl";
            userObject.Location = "Lucknow";

            Console.WriteLine("Name is: " + userObject.Name);
            Console.WriteLine("Location is: " + userObject.Location);
        }
    }
}
