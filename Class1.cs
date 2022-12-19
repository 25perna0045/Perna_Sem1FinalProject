using System;

public class Creature
{
    public string name;
    public string password;
    public Creature(string n, string pw)
    {
        name = n;
        password = pw;
    }
}

public class Human : Creature
{
    public int age;
    public string sex;
    public float height;
    public int weight;
    public Human(string n, string pw) : base(n, pw)
    {
        name = n;
        password = pw;
    }
}

public class Elf : Creature
{
    public int age;
    public string sex;
    public string height;
    public string weight;
    public Elf(string n, string pw) : base(n, pw)
    {
        name = n;
        password = pw;
    }
}

public class Harpy : Creature
{
    public int age;
    public string sex;
    public string height;
    public string weight;
    public Harpy(string n, string pw) : base(n, pw)
    {
        name = n;
        password = pw;
    }
}

public class Centaur : Creature
{
    public int age;
    public string sex;
    public string height;
    public string weight;
    public Centaur(string n, string pw) : base(n, pw)
    {
        name = n;
        password = pw;
    }
}
public class Goblin : Creature
{
    public int age;
    public string sex;
    public string height;
    public string weight;
    public Goblin(string n, string pw) : base(n, pw)
    {
        name = n;
        password = pw;
    }
}
public class Golem : Creature
{
    public int age;
    public string sex;
    public string height;
    public string weight;
    public Golem(string n, string pw) : base(n, pw)
    {
        name = n;
        password = pw;
    }
}