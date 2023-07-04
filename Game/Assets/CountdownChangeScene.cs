using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownChangeScene : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;

    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime; 
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
