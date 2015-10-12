namespace People
{
    using System;

    public class PersonBuilder
    {
        public void BuildPerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "John";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Jane";
                newPerson.Gender = Gender.Female;
            }
        }
    }
}