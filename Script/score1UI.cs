using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score1UI : MonoBehaviour
{
    public TMP_Text ScoreTextTime;
    void Update()
    {
        ScoreTextTime.text = Timer.timeLeft.ToString();
 
    }
}

