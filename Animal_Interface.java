public interface Animal_Interface {

    void sound();
    void eat();

    default void printInfo() {
        System.out.println(this.toString());
    }

}
