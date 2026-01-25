from abc import ABC, abstractmethod
from enum import Enum


class Color(Enum):
    BLACK = 1
    WHITE = 2
    GREY = 3
    BROWN = 4
    DARK_BROWN = 5
    BLACK_STRIPES = 6
    WHITE_STRIPES = 7


class Size(Enum):
    SMALL = 1
    MEDIUM = 2
    LARGE = 3
    HUGE = 4


class AnimalInterface(ABC):
    @abstractmethod
    def sound(self):
        pass

    @abstractmethod
    def eat(self):
        pass


class IMammalia(ABC):
    @abstractmethod
    def run(self):
        pass


class IDog(ABC):
    @abstractmethod
    def bark(self):
        pass

    @abstractmethod
    def bite(self):
        pass


class IAves(ABC):
    @abstractmethod
    def fly(self):
        pass


class IFish(ABC):
    @abstractmethod
    def swimming(self):
        pass


class Animal(AnimalInterface):
    def __init__(self, color, size):
        self.color = color
        self.size = size

    def sound(self):
        print("animal")

    def eat(self):
        print("eat animal")

    def __str__(self):
        return "Animal"


class Mammalia(Animal, IMammalia):
    def __init__(self, color, size, number_babies):
        super().__init__(color, size)
        self.number_babies = number_babies

    def sound(self):
        print("Mammalia sound")

    def eat(self):
        print("Mammalia eat")

    def run(self):
        print("Mammalia Run")


class Dog(Mammalia, IDog):
    def __init__(self, color, size, number_babies, fierce):
        super().__init__(color, size, number_babies)
        self.fierce = fierce

    def sound(self):
        print("sound Dog")

    def eat(self):
        print("Dog eat")

    def bark(self):
        print("Hong!")

    def bite(self):
        print("kad!!")

    def __str__(self):
        return "Dog"


class ThaiRidgeBack(Dog):
    def sound(self):
        print("Dog thai hong")

    def eat(self):
        print("Dog thai eat")


class Aves(Animal, IAves):
    def sound(self):
        print("Aves sound")

    def eat(self):
        print("Aves eat")

    def fly(self):
        print("Aves Fly")


class Bird(Aves):
    def __init__(self, color, size, egg):
        super().__init__(color, size)
        self.egg = egg

    def sound(self):
        print("Bird sound")

    def eat(self):
        print("Bird eat")

    def __str__(self):
        return "Bird"


class HummingBird(Bird):
    def sound(self):
        print("Humming sound")

    def eat(self):
        print("Humming eat")


class Osteicthyes(Animal, IFish):
    def sound(self):
        print("sound Os")

    def eat(self):
        print("eat Os")

    def swimming(self):
        print("os swimming")


class Fish(Osteicthyes):
    def __init__(self, color, size, water_group):
        super().__init__(color, size)
        self.water_group = water_group

    def sound(self):
        print("sound Fish")

    def eat(self):
        print("eat Fish")

    def __str__(self):
        return "Fish"


class AngleFish(Fish):
    def __init__(self, color, size, water_group, location):
        super().__init__(color, size, water_group)
        self.location = location

    def sound(self):
        print("AngleFish Sound")

    def eat(self):
        print("Eat AngleFish")

    def __str__(self):
        return "AngleFish"

dog = ThaiRidgeBack(Color.BLACK, Size.MEDIUM, 5, True)
dog.sound()
dog.eat()
dog.bark()
dog.bite()
dog.run()

bird = HummingBird(Color.WHITE, Size.SMALL, 2)
bird.sound()
bird.eat()
bird.fly()

fish = AngleFish(Color.GREY, Size.SMALL, "Freshwater", "Thailand")
fish.sound()
fish.eat()
fish.swimming()

