using System;
namespace PracticeCSharp
{
    public class NamedAndOptional
    {
        public static void Search(string name, int age = 21, string city = "Beijing")
        {
            Console.WriteLine("Name = {0} - Age = {1} - City = {2}", name, age, city);
        }

        static void Main(string[] args)
        {
            Search("Bruce", 22, "New York");
            Search("Jack", 23);
            Search("Lucky", city: "Paris");
            Search("James", age: 10, city: "Chengdu");
        }
    }
}
