using System;
using System.Collections.Generic;

namespace lesson_6_uzd_3
{
    internal class Program
    {
        private delegate bool Filter(Person person);
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Person1", 10));
            people.Add(new Person("Person2", 15));
            people.Add(new Person("Person3", 25));
            people.Add(new Person("Person4", 30));
            people.Add(new Person("Person5", 65));
            people.Add(new Person("Person5", 70));

            DisplayPeople("Children:", people, IsChild);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);
        }

        static bool IsChild(Person person)
        {
            return person.Age < 18;
        }

        static bool IsAdult(Person person)
        {
            return person.Age >= 18 && person.Age < 65;
        }

        static bool IsSenior(Person person)
        {
            return person.Age >= 65;
        }

        static void DisplayPeople(string title, List<Person> people, Filter filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
            Console.Write("\n");
        }

    }
}
