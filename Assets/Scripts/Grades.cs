using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grades : MonoBehaviour
{
    [Range(0, 100)]
    public int Score = 0;

    void Start()
    {
        
    }

    private void Update()
    {
        CheckGrade();
    }

    void CheckGrade()
    {
        if (Score >= 70)
        {
            Debug.Log("You got an A");
        }
        else if (Score >= 60)
        {
            Debug.Log("You got a B");
        }
        else if (Score >= 50)
        {
            Debug.Log("You got a C");
        }
        else if (Score >= 40)
        {
            Debug.Log("You got a D");
        }
        else
        {
            Debug.Log("You did not pass");
        }
    }
}
