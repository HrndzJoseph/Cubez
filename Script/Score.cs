using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    
    public Collider col; 
    public int finalScore;
    public GameObject UIscore;
    public GameObject UIGeneral;

   
    void Update()
    {
        finalScore = Timer.timeLeft * TilesDestroy.count;
    }


    void OnTriggerEnter(Collider collider)
    {
        FindObjectOfType<AudioManager>().play("Victory");
        print("Score : " + finalScore);
        UIscore.SetActive(true);
        Timer.TimeStop = true;
        UIGeneral.SetActive(false);

    }
}
