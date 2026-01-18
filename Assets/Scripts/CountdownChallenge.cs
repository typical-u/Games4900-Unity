using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownChallenge : MonoBehaviour
{
    public int startSeconds = 10;

    private float timer = 0.0f;
    private float waitTime = 1.0f;
    private int currentSeconds;

    public GameObject targetObject;

    void Start()
    {
        currentSeconds = startSeconds;
        Debug.Log("Time left: " + currentSeconds);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            timer -= waitTime;
            currentSeconds--;

            if (currentSeconds >= 0)
            {
                Debug.Log("Time left: " + currentSeconds);
            }

            targetObject.transform.position += new Vector3(0f, 0.1f, 0f);

            if (currentSeconds <= 0)
            {
                Debug.Log("TIMES UP");
                enabled = false;
            }
        }
    }
}