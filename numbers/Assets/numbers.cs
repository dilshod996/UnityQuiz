using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numbers : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {

        StartGame();


    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("welcome to our world");
        Debug.Log("pick a number");
        Debug.Log("The highest number you can pick is : " + max);
        Debug.Log("The lowestest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up = higher, Push Down = lower Push enter = correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genuis!");
            StartGame();
        }


        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
 
            max = guess;
            NextGuess();

        }

    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("it is higher or lower than we expected: " + guess);
    }
}
