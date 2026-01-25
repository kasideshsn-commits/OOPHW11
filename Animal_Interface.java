public interface Animal_Interface {

    void sound();
    void eat();

    default void printInfo() {
        System.out.println(this.toString());
    }

}
interface IMammalia{
    void run();
    
}
interface IDog{
    void bark();
    void bite();
}
void IAves{
    void fly();
}
interface Ifish{
    void swimming();
}

