namespace HW10;

public class Pupils
{ 
    public string Name { set; get; }
	public string Surname { set; get; }
    public int Age { set; get; }

    public Pupils(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
}