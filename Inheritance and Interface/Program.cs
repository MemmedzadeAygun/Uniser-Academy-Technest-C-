
using Inheritance_and_Interface.Classes;
using Inheritance_and_Interface.Interfaces;

Teacher teacher = new Teacher("Teacher message")
{
   FirstName = "Walter",
   Lastname = "LastName",
   Salary = 2000
};

Student student = new Student
{
    FirstName = "Bruce",
    Lastname = "Whine",
    GroupName = "Technest"
};

Person person = new Person();
person.FirstName = "Jhon";
person.Lastname = "Wick";

//Person person1 = new Student();
//Person person2 = new Teacher();

student.GetData();
teacher.GetData();

IPerson person1 = new Student();
IPerson person2 = new Teacher();

person1.Add();
person2.Add();