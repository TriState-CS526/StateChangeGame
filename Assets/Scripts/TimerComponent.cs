using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerComponent : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 0;
    // Update is called once per frame
    public TextMeshProUGUI timeText;

    void Update()
    {
        time += Time.deltaTime;
        DisplayTime(time);
    }
    void DisplayTime(float time)
    {
        float minutes = Mathf.FloorToInt(time/60);
        float seconds = Mathf.FloorToInt(time%60);

        timeText.text = string.Format("{0:00}:{1:00}",minutes,seconds);

    }
}
