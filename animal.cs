using System;

namespace AnimalSystem
{
    enum Color
    {
        BLACK, WHITE, GREY, BROWN, DARK_BROWN, BLACK_STRIPES, WHITE_STRIPES
    }

    enum Size
    {
        SMALL, MEDIUM, LARGE, HUGE
    }

    interface IAnimal
    {
        void Sound();
        void Eat();
    }

    interface IMammalia
    {
        void Run();
    }

    interface IDog
    {
        void Bark();
        void Bite();
    }

    interface IAves
    {
        void Fly();
    }

    interface IFish
    {
        void Swimming();
    }

    abstract class Animal : IAnimal
    {
        protected Color color;
        protected Size size;

        public Animal(Color color, Size size)
        {
            this.color = color;
            this.size = size;
        }

        public virtual void Sound()
        {
            Console.WriteLine("animal");
        }

        public virtual void Eat()
        {
            Console.WriteLine("eat animal");
        }

        public virtual string ToStringAnimal()
        {
            return "Animal";
        }
    }

    class Mammalia : Animal, IMammalia
    {
        protected int numberBabies;

        public Mammalia(Color color, Size size, int numberBabies)
            : base(color, size)
        {
            this.numberBabies = numberBabies;
        }

        public override void Sound()
        {
            Console.WriteLine("Mammalia sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Mammalia eat");
        }

        public void Run()
        {
            Console.WriteLine("Mammalia Run");
        }
    }

    class Dog : Mammalia, IDog
    {
        protected bool fierce;

        public Dog(Color color, Size size, int numberBabies, bool fierce)
            : base(color, size, numberBabies)
        {
            this.fierce = fierce;
        }

        public override void Sound()
        {
            Console.WriteLine("sound Dog");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog eat");
        }

        public void Bark()
        {
            Console.WriteLine("Hong!");
        }

        public void Bite()
        {
            Console.WriteLine("kad!!");
        }

        public override string ToStringAnimal()
        {
            return "Dog";
        }
    }

    class ThaiRidgeBack : Dog
    {
        public ThaiRidgeBack(Color color, Size size, int numberBabies, bool fierce)
            : base(color, size, numberBabies, fierce) { }

        public override void Sound()
        {
            Console.WriteLine("Dog thai hong");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog thai eat");
        }
    }

    class Aves : Animal, IAves
    {
        public Aves(Color color, Size size) : base(color, size) { }

        public override void Sound()
        {
            Console.WriteLine("Aves sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Aves eat");
        }

        public void Fly()
        {
            Console.WriteLine("Aves Fly");
        }
    }

    class Bird : Aves
    {
        protected int egg;

        public Bird(Color color, Size size, int egg)
            : base(color, size)
        {
            this.egg = egg;
        }

        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Bird eat");
        }

        public override string ToStringAnimal()
        {
            return "Bird";
        }
    }

    class HummingBird : Bird
    {
        public HummingBird(Color color, Size size, int egg)
            : base(color, size, egg) { }

        public override void Sound()
        {
            Console.WriteLine("Humming sound");
        }

        public override void Eat()
        {
            Console.WriteLine("humming eat");
        }
    }

    class Osteicthyes : Animal, IFish
    {
        public Osteicthyes(Color color, Size size) : base(color, size) { }

        public override void Sound()
        {
            Console.WriteLine("sound Os");
        }

        public override void Eat()
        {
            Console.WriteLine("eat Os");
        }

        public void Swimming()
        {
            Console.WriteLine("os swimming");
        }
    }

    class Fish : Osteicthyes
    {
        protected string waterGroup;

        public Fish(Color color, Size size, string waterGroup)
            : base(color, size)
        {
            this.waterGroup = waterGroup;
        }

        public override void Sound()
        {
            Console.WriteLine("sound Fish");
        }

        public override void Eat()
        {
            Console.WriteLine("eat Fish");
        }

        public override string ToStringAnimal()
        {
            return "Fish";
        }
    }

    class AngleFish : Fish
    {
        protected string location;

        public AngleFish(Color color, Size size, string waterGroup, string location)
            : base(color, size, waterGroup)
        {
            this.location = location;
        }

        public override void Sound()
        {
            Console.WriteLine("AngleFish Sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat AngleFish");
        }

        public override string ToStringAnimal()
        {
            return "AngleFish";
        }
    }
}
