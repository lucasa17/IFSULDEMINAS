package view;

import model.Counter;

public class Main {
    public static void main(String[] args) {

    	Counter counter1 = Counter.getInstance();
        Counter counter2 = Counter.getInstance();

        counter1.increment();
        counter1.increment();
        counter2.increment();

        System.out.println("Valor final do contador: " + counter1.getCount());
        System.out.println("Referência é a mesma? " + (counter1 == counter2));
    }
}
