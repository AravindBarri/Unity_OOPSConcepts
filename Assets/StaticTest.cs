using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    static int score = 0;

    static void IncrementScore()
    {
        Debug.Log("Updated Score is :" + ++score);
    }

    private void Start()
    {
        StaticTest stest = new StaticTest();
        IncrementScore();
    }
}
