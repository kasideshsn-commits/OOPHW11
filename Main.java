public class Main {

    public static void main(String[] args) {

        Animal_Interface dog =
                new Dog(Color.BROWN, Size.MEDIUM, 5, true);

        Animal_Interface thaiDog =
                new ThaiRidgeBack(Color.BLACK, Size.LARGE, 6, true);

        Animal_Interface bird =
                new Bird(Color.WHITE, Size.SMALL, 3);

        Animal_Interface humming =
                new HummingBird(Color.GREY, Size.SMALL, 2);

        Animal_Interface fish =
                new Fish(Color.GREY, Size.MEDIUM, "Freshwater");

        Animal_Interface angelFish =
                new AngleFish(Color.WHITE, Size.SMALL,
                        "Saltwater", "Thailand");


        dog.sound();
        dog.eat();
        dog.printInfo();

        System.out.println("---------------");

        angelFish.sound();
        angelFish.eat();
        angelFish.printInfo();

        System.out.println("---------------");


        System.out.println(dog instanceof Dog);
        System.out.println(dog instanceof Mammalia);
        System.out.println(dog instanceof Animal);
    }
}




enum Color{
  BLACK,WHITE,GREY,BROWN,DARK_BROWN,BLACK_STRIPES,WHITE_STRIPES
}
enum Size{
  SMALL,MEDIUM,LARGE,HUGE
}

abstract class Animal {

    protected Color color;
    protected Size size;


    public Animal(Color color ,Size size){
        this.color = color;
        this.size = size;
    }

    @Override
    public String toString() {
        return getClass().getName()+"color:"+color+"size:"+size;
    }
}
class Mammalia extends Animal implements Imammalia{

    protected int number_Babies;
    public Mammalia(Color color,Size size,int number_Babies){
        super(color, size);
        this.number_Babies = number_Babies;
    }


   
    public void eat() {
        System.out.println("Mammalia eat");
    }

    
    public void sound() {
        System.out.println("Mammalia sound");
    }
    @Oberride
    public void run() {
        System.out.println("Mammalia Run");
    }
}
class Dog extends Mammalia implements IDog {

    protected  boolean fierce;
    public Dog(Color color, Size size, int number_Babies,boolean fierce) {
        super(color, size, number_Babies);
        this.fierce = fierce;
    }

    
    public void sound() {
        System.out.println("sound Dog");
    }
    
    public void eat(){
        System.out.println("Dog eat");
    }
    @Override
    public void bark(){
        System.out.println("Hong!");
    }
    @Override
    public void Bite(){
        System.out.println("kad!!");
    }

    @Override
    public String toString() {
        return "Dog color:"+color+"size:"+size+"fierce:"+fierce;
    }
}
class ThaiRidgeBack extends Dog {


    public ThaiRidgeBack(Color color, Size size, int number_Babies,boolean fierce) {
        super(color, size, number_Babies,fierce);
    }

    
    public void sound() {
        System.out.println("Dog thai hong");
    }

    
    public void eat() {
        System.out.println("Dog thai eat");
    }
}
class Aves extends Animal implements IAves{

    public Aves(Color color, Size size) {
        super(color, size);
    }
    @Override
    public void fly(){
        System.out.println("Aves Fly");
    }
    
    public void sound() {
        System.out.println("Fly");
    }

    
    public void eat() {
        System.out.println("Aves eat");
    }
}
class Bird extends Aves {

    protected int egg;
    public Bird(Color color, Size size,int  egg) {
        super(color, size);
        this.egg = egg;
    }

  
    public void sound() {
        System.out.println("Bird sound");
    }

   
    public void eat() {
        System.out.println("Bird eat");
    }

    @Override
    public String toString() {
        return "Bird color :"+color+"size:"+size+"egg:"+egg;
    }
}
class HummingBird extends Bird {


    public HummingBird(Color color, Size size, int egg) {
        super(color, size, egg);
    }

   
    public void eat() {
        System.out.println("humming eat");
    }

  
    public void sound() {
        System.out.println("Humming sound");
    }
}
class Osteicthyes extends Animal implements IFish{


    public Osteicthyes(Color color, Size size) {
        super(color, size);
    }
    
    public void sound(){
        System.out.println("sound Os");
    }

    
    public void eat() {
        System.out.println("eat Os");
    }
    @Override
    public void swimming(){
        System.out.println("os swimming");
    }
}
class Fish extends Osteicthyes {

    protected String water_Group;
    public Fish(Color color, Size size,String water_Group) {
        super(color, size);
        this.water_Group = water_Group;
    }
 
    public void sound(){
        System.out.println("sound Fiah");
    }
  
    public void eat(){
        System.out.println("eat Fish");
    }

    @Override
    public String toString() {
        return "Fish color:"+color+"Size:"+size+"water_group:"+water_Group;
    }
}
class AngleFish extends Fish {

    protected String location;

    public AngleFish(Color color, Size size, String water_Group,String location) {
        super(color, size, water_Group);
        this.location = location;
    }
    
    public void sound(){
        System.out.println("AngleFish Sound");
    }
    
    public void eat(){
        System.out.println("Eat AngleFish");
    }

    @Override
    public String toString() {
        return "Angle color:"+color+"Size:"+size+"waterGroup:"+water_Group+"location:"+location;
    }
}
