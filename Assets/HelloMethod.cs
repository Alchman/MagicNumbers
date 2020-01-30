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

    void Study()
    {
        Debug.Log("Study");
    }

    int Number()
    {
        int a = 4;
        a = a * 26;

        return a;
    }

    int NumberX2(int number)
    {
        number = number * 2;
        return number;
    }

    void PrintName(string name)
    {
        globalNumber = 100;
        Debug.Log("Hello, " + name);
    }



    int NumbersAverage(int number1, int number2)
    {
        return (number1 + number2) / 2;

       // return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
