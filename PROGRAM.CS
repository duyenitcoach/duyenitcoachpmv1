using myClass;
using System;

Person person1 = new Person();
person1.Id = 1;
person1.Name = "Long";
person1.Age = 30;

Person person2 = new Person();
person2.Id = 2;
person2.Name = "Lon";
person2.Age = 50;

List<Person> listPerson = new List<Person>();
listPerson.Add(person1);
listPerson.Add(person2);

Console.WriteLine("danh sach nhung khach hang ma toi co:");

if (listPerson.Count > 0)
{   
    foreach ( var person in listPerson)     
    {
        Console.WriteLine(string.Format("Name :{0}, Age : {1}",person.Name, person.Age));
    }
}
else
{
    Console.WriteLine("Toi ko co quyen sach nao");
}

