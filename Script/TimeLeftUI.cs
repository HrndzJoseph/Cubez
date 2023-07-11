using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeLeftUI : MonoBehaviour
{
    public TMP_Text timeText;
    

    // Update is called once per frame
    void Update()
    {
        timeText.text = Timer.timeLeft.ToString();

        
    }
}
