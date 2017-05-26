using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   public class User
    {
        protected string name;
        protected string surname;
        protected int age;

        public User() { }

        public User(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public User(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Incorrect value of name");
                }
                else { name = value; }
            }
            get { return name; }
        }

        public int Age
        {
            set
            {
                if (age > 0)
                {
                    age = value;

                }
                else
                {
                    Console.WriteLine("Incorrect age");
                }
            }
            get { return age; }
        }

    }

    public abstract class Site
    {
        public abstract void enterTheSite(User currentUser);
    }

   public class OldSite : Site
    {
        public OldSite() { }

        public override void enterTheSite(User currentUser)
        {
            Console.WriteLine("Hello, {0}", currentUser.Name);
        }
    }

    public class NewSite : Site
    {
        OldSite site = new OldSite();
        public NewSite() { }

        public override void enterTheSite(User currentUser)
        {
            if (currentUser.Age > 35 || currentUser.Age == 0)
            {
                Console.WriteLine("Good afternoon, {0}", currentUser.Name);
            }
            else enterTheSite(currentUser);
        }
    }
}


