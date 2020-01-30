using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int a = 4;

    // Start is called before the first frame update
    void Start()
    {
        // комментарий
        Debug.Log("HelloWorld");

        int b = 2;
        Debug.Log(a);
        Debug.Log(a);
        a = a + 5;
        a += 5;
        a++; //a = a + 1;

        string name = "Denis";
        name += ", Hello!";

        bool isAlive = true;
        bool isActive = true;
        isAlive = false;


        int number = 5;
        if ((isAlive && isActive) || a == b)
        {
            //isAlive = true
            number = 5;
        }
        else
        {
            //isAlive = false

            number = 7;
        }

        if (true)
        {
            Debug.Log("asd");
        }

        Debug.Log("asd 2");
    }

    // Update is called once per frame
    void Update()
    {
        a = 3;
        Debug.Log("Hello World Update");
    }
}
