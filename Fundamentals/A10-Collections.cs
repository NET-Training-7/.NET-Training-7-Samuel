using System;
using System.Collections.Generic;

class Collections
{
    void LearnList() // learning lists
    {
        int[] numbers = { 34, 56, 12, 45 };
        List<int> numList = new List<int>() { 12, 34, 56, 87, 1 };
        numList.Add(78);
        numList.Remove(56);

        List<Person> people = new List<Person>();
        people.Add(new Person() { Name = "Bishnu" });
        people.Add(new Person() { Name = "Sam" });
        people.Add(new Person() { Name = "Manoj" });
        people.Add(new Person() { Name = "Rakish" });

        people.Remove(new Person() { Name = "Sam" });
    }

    void LearnOthers() // learn stack
    {
        Stack<string> plates = new();
        plates.Push("Plate1");
        plates.Push("Plate2");
        plates.Push("Plate3");
        plates.Push("Plate4");
        plates.Push("Plate5");


        plates.Pop();

        Queue<string> qline = new Queue<string>();
        qline.Enqueue("Person1");
        qline.Enqueue("Person2");
        qline.Enqueue("Person3");
        qline.Enqueue("Person4");
        qline.Enqueue("Person5");

        qline.Dequeue();
    }

    void LearnDictionary()
    {
        // Store country and its capital
        Dictionary<string, string> countryCapitals = new();
        countryCapitals.Add("Nepal","Kathmandu");
        countryCapitals.Add("Bhutan","Thimpu");
        countryCapitals.Add("SriLanka","Colombo");
        countryCapitals.Add("Bangladesh","Dhaka");
        countryCapitals.Add("Pakistan","Islamabadh");

       
    }
}