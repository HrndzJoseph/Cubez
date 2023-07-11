using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreUi : MonoBehaviour
{
    public TMP_Text ScoreText;
    public Score score;
    void Update()
    {
        ScoreText.text = score.finalScore.ToString();
 
    }
}
