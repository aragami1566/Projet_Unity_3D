using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    // Update is called once per frame

    IEnumerator CountdownToStart() { 
        while (countdownTime > 0)
        {
            countdownDisplay.text = "Temps restant: " + countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;

            if (countdownTime == 0)
            {
                countdownDisplay.color = Color.red;
                countdownDisplay.text = "Le temps est ecoule !";
            }
        }

      
    }
}
