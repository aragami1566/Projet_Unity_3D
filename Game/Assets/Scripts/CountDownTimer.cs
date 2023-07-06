using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    private Coroutine countdownCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        countdownCoroutine = StartCoroutine(CountdownToStart());
    }

    // Update is called once per frame

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = "Temps restant: " + countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;

            if (countdownTime <= 0)
            {
                countdownDisplay.color = Color.red;
                countdownDisplay.text = "Le temps est écoulé !";
                yield return new WaitForSeconds(2f);
                LoadEndScene();
                yield break; 
            }
        }
    }

    void LoadEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }


    // Optional: You can provide a method to manually stop the countdown coroutine
    void StopCountdown()
    {
        if (countdownCoroutine != null)
        {
            StopCoroutine(countdownCoroutine);
        }
    }
}
