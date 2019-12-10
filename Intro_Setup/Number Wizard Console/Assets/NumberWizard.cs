using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int max = 1000;
    int min = 1;
    int guess = 500;

    void Reset()
    {
         max = 1000;
        min = 1;
         guess = 500;
    }

    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        Reset();
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Please pick a number, but don't tell anyone yet....");
        Debug.Log("The highest value can be " + max);
        Debug.Log("The lowest value can be " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess + "?");
        Debug.Log("push up = number is higher, push down = number is lower, push enter = number is correct");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("The Up Arrow was pushed");
            if(guess == 999)
            {
                guess = 1000;
            }
            
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("The Down Arrow was pushed");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed");
            Debug.Log("Awesome we got the number right");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than " + guess + "?");
    }
}
