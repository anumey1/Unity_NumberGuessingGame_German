using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumWiz : MonoBehaviour {


    int max;
    int min;
    int guess;

    public int mguess = 5;

    public Text text;

    

    // Use this for initialization
    void Start () {
        star_game();
	}

    void star_game()
    {

        max = 1000;
        min = 1;
        next();
        max = max + 1;
    }

    public void high()
    {
        min = guess;
        next();
    }

    public void low()
    {
        max = guess;
        next();
    }


    void next()
    {
        guess = Random.Range(min,max+1);

        text.text = guess.ToString();

        mguess = mguess - 1;


        if (mguess <= 0)
        {
            Application.LoadLevel("WIn");

            
        }


    }
	
	// Update is called once per frame
	
}
