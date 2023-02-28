using myClass;
using System;

Person person1 = new Person();
person1.Id = 1;
person1.FirstName = "Long";
person1.LastName = "Le";
person1.Age = 30;
person1.Country = "VN";

Person person2 = new Person();
person2.Id = 2;
person2.FirstName = "Quyet";
person2.LastName = "Trinh Van";
person2.Age = 50;
person2.Country = "JP";

List<Person> listPerson = new List<Person>();
listPerson.Add(person1);
listPerson.Add(person2);

void Checkperson(Person person)
{
    string fullName = GetFullName(person);

    Console.WriteLine(string.Format("Name: {0}, Age: {1}, Country: {2}", fullName, person.Age, person.Country));

    if (person.Country != "VN")
    {
        Console.WriteLine("Day la nguoi nuoc ngoai");
    }
    else
    {
        Console.WriteLine("Day la nguoi VN");
    }
}

string GetFullName(Person person)
{
    string fullName = string.Format("{0} {1}", person.LastName, person.FirstName);

    return fullName;
}

foreach (var person in listPerson)
{
    Checkperson(person);
}

Console.ReadLine();
