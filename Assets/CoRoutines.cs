using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutines : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ScoreUpdate());
    }

    IEnumerator ScoreUpdate()
    {
        yield return new WaitForSeconds(5);
        print(score++);
        print(Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ScoreUpdate());
    }
}
