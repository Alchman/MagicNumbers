using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    //объявление переменной на уровне класса с типом int (целое число), именем 'a' и сразу присваивается значение 4
    int a = 4;

    // Start выполняется один раз при запуске игры в Unity
    void Start()
    {
        // комментарий
        Debug.Log("HelloWorld");

        int b = 2;

        //вывод значения переменной в консоль Unity
        Debug.Log(a);

        //арифметические операции
        a = a + 5;
        a += 5; //a = a + 5;
        a++; //a = a + 1;

        
        string name = "Denis"; //строковая переменая
        name += ", Hello!"; //значение переменной будет "Denis, Hello!"

        //переменная типа bool (возможные значения true и false)
        bool isAlive = true;
        bool isActive = true;
        isAlive = false;


        int number = 5;
        if ((isAlive && isActive) || a == b) //&& - логическая операция И, || - логическая операция ИЛИ
        {
            //заходит сюда если условия в скобках if равняется true
            number = 5;
        }
        else
        {
            //заходит сюда если условия в скобках if равняется false
            number = 7;
        }

        if (true)
        {
            Debug.Log("asd");
        }

        Debug.Log("asd 2");
    }

    // Update выполняется каждый кадр
    void Update()
    {
        //переменная 'a' доступна, так как объявлена на уровне класса
        a = 3;
        Debug.Log("Hello World Update");
    }
}
