public class Person
{
    private int age;
    public string Name { get; set; }

    public Person(int age, string name)
    {
        this.age = age;
        this.Name = name;
    }

    public string Introduction()
    {
        return $"Hi, I'm {Name} and I'm {age} years old";
    }
}

// გამოყენება:
Person person = new Person(20, "YourName");
Console.WriteLine(person.Introduction());
