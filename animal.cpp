#include <iostream>
#include <string>
using namespace std;

enum class Color {
    BLACK, WHITE, GREY, BROWN, DARK_BROWN, BLACK_STRIPES, WHITE_STRIPES
};

enum class Size {
    SMALL, MEDIUM, LARGE, HUGE
};

class Animal_Interface {
public:
    virtual void sound() = 0;
    virtual void eat() = 0;
    virtual ~Animal_Interface() {}
};

class Animal {
protected:
    Color color;
    Size size;

public:
    Animal(Color color, Size size) : color(color), size(size) {}

    virtual string toString() {
        return "Animal";
    }

    virtual ~Animal() {}
};

class Mammalia : public Animal, public Animal_Interface {
protected:
    int number_Babies;

public:
    Mammalia(Color color, Size size, int number_Babies)
        : Animal(color, size), number_Babies(number_Babies) {}

    void sound() override {
        cout << "Mammalia sound" << endl;
    }

    void eat() override {
        cout << "Mammalia eat" << endl;
    }

    void run() {
        cout << "Mammalia Run" << endl;
    }
};

class Dog : public Mammalia {
protected:
    bool fierce;

public:
    Dog(Color color, Size size, int number_Babies, bool fierce)
        : Mammalia(color, size, number_Babies), fierce(fierce) {}

    void sound() override {
        cout << "sound Dog" << endl;
    }

    void eat() override {
        cout << "Dog eat" << endl;
    }

    void bark() {
        cout << "Hong!" << endl;
    }

    void Bite() {
        cout << "kad!!" << endl;
    }

    string toString() override {
        return "Dog";
    }
};

class ThaiRidgeBack : public Dog {
public:
    ThaiRidgeBack(Color color, Size size, int number_Babies, bool fierce)
        : Dog(color, size, number_Babies, fierce) {}

    void sound() override {
        cout << "Dog thai hong" << endl;
    }

    void eat() override {
        cout << "Dog thai eat" << endl;
    }
};

class Aves : public Animal, public Animal_Interface {
public:
    Aves(Color color, Size size) : Animal(color, size) {}

    void sound() override {
        cout << "Fly" << endl;
    }

    void eat() override {
        cout << "Aves eat" << endl;
    }

    void fly() {
        cout << "Aves Fly" << endl;
    }
};

class Bird : public Aves {
protected:
    int egg;

public:
    Bird(Color color, Size size, int egg)
        : Aves(color, size), egg(egg) {}

    void sound() override {
        cout << "Bird sound" << endl;
    }

    void eat() override {
        cout << "Bird eat" << endl;
    }

    string toString() override {
        return "Bird";
    }
};

class HummingBird : public Bird {
public:
    HummingBird(Color color, Size size, int egg)
        : Bird(color, size, egg) {}

    void sound() override {
        cout << "Humming sound" << endl;
    }

    void eat() override {
        cout << "humming eat" << endl;
    }
};

class Osteicthyes : public Animal, public Animal_Interface {
public:
    Osteicthyes(Color color, Size size) : Animal(color, size) {}

    void sound() override {
        cout << "sound Os" << endl;
    }

    void eat() override {
        cout << "eat Os" << endl;
    }

    void swimming() {
        cout << "os swimming" << endl;
    }
};

class Fish : public Osteicthyes {
protected:
    string water_Group;

public:
    Fish(Color color, Size size, string water_Group)
        : Osteicthyes(color, size), water_Group(water_Group) {}

    void sound() override {
        cout << "sound Fish" << endl;
    }

    void eat() override {
        cout << "eat Fish" << endl;
    }

    string toString() override {
        return "Fish";
    }
};

class AngleFish : public Fish {
protected:
    string location;

public:
    AngleFish(Color color, Size size, string water_Group, string location)
        : Fish(color, size, water_Group), location(location) {}

    void sound() override {
        cout << "AngleFish Sound" << endl;
    }

    void eat() override {
        cout << "Eat AngleFish" << endl;
    }

    string toString() override {
        return "AngleFish";
    }
};

int main() {
    Animal_Interface* a1 = new Dog(Color::BROWN, Size::MEDIUM, 5, true);
    Animal_Interface* a2 = new Bird(Color::WHITE, Size::SMALL, 2);
    Animal_Interface* a3 = new Fish(Color::GREY, Size::LARGE, "Fresh");

    a1->sound();
    a2->sound();
    a3->sound();

    delete a1;
    delete a2;
    delete a3;

    return 0;
}
