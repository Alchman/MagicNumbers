using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScene : MonoBehaviour
{
    public InputField input;
    public Text resultText;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        /*
        int[] numbers = { 0, 5, 67, 85};
        Debug.Log("Before for");
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log("number: " + numbers[i]);
        }
        Debug.Log("After for");
        */

        /*
        Text[] allTexts = FindObjectsOfType<Text>();
        for (int i = 0; i < allTexts.Length; i++)
        {
            allTexts[i].text = "Text " + i;
        }
        */

        MagicNumbersUI magicNumbers = FindObjectOfType<MagicNumbersUI>();
        int number = magicNumbers.guess;
        resultText.text = "Ваше было: " + number;


        //Destroy(magicNumbers); //destroy component
        Destroy(magicNumbers.gameObject); //destroy Game Object

    }

    // Update is called once per frame
    void Update()
    {
    }
}
