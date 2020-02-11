using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMethod : MonoBehaviour
{
    int globalNumber = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        Debug.Log("Global number: " + globalNumber);
        Study();
        Debug.Log("Start2");

        int result = Number();
        Debug.Log("Result: " + result);

        PrintName("Denis");

        Debug.Log(NumbersAverage(1, 10));
        Debug.Log("Global number: " + globalNumber);

        int number = 10;
        Debug.Log(NumberX2(number));
        Debug.Log(number);

    }

    //метод (функция) с именем 'Study', которая не возвращает никакой результат (void) и не принимает никаких аргументов: ()
    void Study()
    {
        Debug.Log("Study");
    }

    //метод (функция) с именем 'Number', которая возвращает результат типа int и не принимает никаких аргументов: ()
    int Number()
    {
        int a = 4;
        a = a * 26;

        return a; //return - выход из функции, код после return не выполняется

        //код здесь никогда не выполняется
    }

    //метод (функция) с именем 'NumberX2', которая возвращает результат типа int и принимает в качестве аргумента int: (int number)
    int NumberX2(int number)
    {
        number = number * 2;
        return number;
    }

    //метод (функция) с именем 'PrintName', которая не возвращает никакой результат (void) и принимает в качестве аргумента строку string: (string name)
    void PrintName(string name)
    {
        //переменная globalNumber доступна, так как объявлена на уровне класса
        globalNumber = 100;
        Debug.Log("Hello, " + name);
    }


    //метод (функция) с именем 'NumbersAverage', которая возвращает результат типа int и принимает два аргумента типа  int: (int number1, int number2)
    int NumbersAverage(int number1, int number2)
    {
        //в одно строке рассчитывается результат и сразу возвращается как результат выполнения функции
        return (number1 + number2) / 2;

    }
}
