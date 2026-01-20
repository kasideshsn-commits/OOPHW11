using System;

enum Color {
    BLACK, WHITE, GREY, BROWN, DARK_BROWN, BLACK_STRIPES, WHITE_STRIPES
}

enum Size {
    SMALL, MEDIUM, LARGE, HUGE
}

interface IAnimal {
    void Sound();
    void Eat();
}

abstract class Animal {
    protected Color color;
    protected Size size;

    protected Animal(Color color, Size size) {
        this.color = color;
        this.size = size;
    }

    public override string ToString() {
        return $"{GetType().Name} color:{color} size:{size}";
    }
}

class Mammalia : Animal, IAnimal {
    protected int numberBabies;

    public Mammalia(Color color, Size size, int numberBabies)
        : base(color, size) {
        this.numberBabies = numberBabies;
    }

    public virtual void Sound() {
        Console.WriteLine("Mammalia sound");
    }

    public virtual void Eat() {
        Console.WriteLine("Mammalia eat");
    }

    public void Run() {
        Console.WriteLine("Mammalia run");
    }
}

class Dog : Mammalia {
    protected bool fierce;

    public Dog(Color color, Size size, int numberBabies, bool fierce)
        : base(color, size, numberBabies) {
        this.fierce = fierce;
    }

    public override void Sound() {
        Console.WriteLine("Dog sound");
    }

    public override void Eat() {
        Console.WriteLine("Dog eat");
    }

    public override string ToString() {
        return $"Dog color:{color} size:{size} fierce:{fierce}";
    }
}

class Bird : Animal, IAnimal {
    protected int egg;

    public Bird(Color color, Size size, int egg)
        : base(color, size) {
        this.egg = egg;
    }

    public void Sound() {
        Console.WriteLine("Bird sound");
    }

    public void Eat() {
        Console.WriteLine("Bird eat");
    }
}

class Fish : Animal, IAnimal {
    protected string waterGroup;

    public Fish(Color color, Size size, string waterGroup)
        : base(color, size) {
        this.waterGroup = waterGroup;
    }

    public void Sound() {
        Console.WriteLine("Fish sound");
    }

    public void Eat() {
        Console.WriteLine("Fish eat");
    }
}

class Program {
    static void Main() {
        IAnimal a1 = new Dog(Color.BROWN, Size.MEDIUM, 5, true);
        IAnimal a2 = new Bird(Color.WHITE, Size.SMALL, 2);
        IAnimal a3 = new Fish(Color.GREY, Size.LARGE, "Fresh");

        a1.Sound();
        a2.Sound();
        a3.Sound();

        Console.WriteLine(a1);
    }
}
