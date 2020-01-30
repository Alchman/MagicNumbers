using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    int minNumber = 1;
    int maxNumber = 1000;
    string playerName = "Denis";

    int guess;

    //float health = 50.45f;
    //bool isGameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Добро пожаловать, " + playerName);
        Debug.Log("Загадайте число");
        Debug.Log("Мин. число: " + minNumber);
        Debug.Log("Макс. число: " + maxNumber);

        guess = (minNumber + maxNumber) / 2;

        Debug.Log("Ваше число: " + guess + "?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow pressed");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow pressed");
        }
        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("Я угадал! Ваше число было: " + guess);
        }

    }
}
