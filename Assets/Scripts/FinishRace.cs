using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinishRace : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }*/
    public TextMeshProUGUI endText;
    public GameObject but1;
    public GameObject but2;
    public TextMeshProUGUI timer;
    void OnCollisionEnter2D(Collision2D collision)
    {
        endText.text = string.Format("Congratulations!");
        but1.SetActive(true);
        if(but2 != null) but2.SetActive(true);
        timer.GetComponent<TimerComponent>().over = true;
        

    }
}
