using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private int minite;
    [SerializeField]
    private float seconds;
    private float oldSeconds;
    [SerializeField]
    private TextMeshProUGUI timeText;

    private void Start()
    {
        minite = 0;
        seconds = 0;
        oldSeconds = 0;
    }
    private void Update()
    {
        seconds += Time.deltaTime;
        if(seconds >= 60f)
        {
            minite++;
            seconds = seconds - 60f;
        }

        if((int)seconds != (int)oldSeconds)
        {
            timeText.text = minite.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
    }

}
