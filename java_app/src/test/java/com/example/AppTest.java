package com.example;

public class AppTest {
    public static void main(String[] args) {
        if (App.add(2, 3) != 5) {
            System.err.println("Test failed: expected 5");
            System.exit(1);
        }
        System.out.println("All tests passed");
    }
}
