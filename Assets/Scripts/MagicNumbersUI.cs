﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MagicNumbersUI : MonoBehaviour
{
    public int minNumber = 1;
    public int maxNumber = 1000;

    public Text textGuess;
    public TextMeshProUGUI textCount;

    public int guess;


    // Start is called before the first frame update
    void Start()
    {
        


        DontDestroyOnLoad(gameObject);

        //guess = (minNumber + maxNumber) / 2;
        guess = Random.Range(minNumber, maxNumber + 1);

        //задать это значение компоенту  Text на сцене
        textGuess.text = "Ваше число " + guess + "?";

        textCount.text = "Количество ходов: " + 2;

    }

    void OnDestroy()
    {
        Debug.Log("Destroy Script");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
