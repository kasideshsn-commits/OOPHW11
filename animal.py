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
    def sound(self): pass

    @abstractmethod
    def eat(self): pass

class Animal:
    def __init__(self, color, size):
        self.color = color
        self.size = size

    def __str__(self):
        return f"{self.__class__.__name__} color:{self.color.name} size:{self.size.name}"

class Mammalia(Animal, AnimalInterface):
    def __init__(self, color, size, number_babies):
        super().__init__(color, size)
        self.number_babies = number_babies

    def sound(self):
        print("Mammalia sound")

    def eat(self):
        print("Mammalia eat")

class Dog(Mammalia):
    def __init__(self, color, size, number_babies, fierce):
        super().__init__(color, size, number_babies)
        self.fierce = fierce

    def sound(self):
        print("Dog sound")

    def eat(self):
        print("Dog eat")

    def __str__(self):
        return f"Dog color:{self.color.name} size:{self.size.name} fierce:{self.fierce}"

class Bird(Animal, AnimalInterface):
    def __init__(self, color, size, egg):
        super().__init__(color, size)
        self.egg = egg

    def sound(self):
        print("Bird sound")

    def eat(self):
        print("Bird eat")

class Fish(Animal, AnimalInterface):
    def __init__(self, color, size, water_group):
        super().__init__(color, size)
        self.water_group = water_group

    def sound(self):
        print("Fish sound")

    def eat(self):
        print("Fish eat")

a1 = Dog(Color.BROWN, Size.MEDIUM, 5, True)
a2 = Bird(Color.WHITE, Size.SMALL, 2)
a3 = Fish(Color.GREY, Size.LARGE, "Fresh")

a1.sound()
a2.sound()
a3.sound()

print(a1)
