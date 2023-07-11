using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score2UI : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text ScoreTextTime;
    void Update()
    {
        ScoreTextTime.text = TilesDestroy.count.ToString();
 
    }
}

