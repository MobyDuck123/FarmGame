using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FizzBuzz()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else
            {
                Debug.Log(i);
            }

        }
    }
}



