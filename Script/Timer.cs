using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLeftDeci = 104;
    public static int timeLeft ;
    public static bool TimeStop = false;

    public GameManager gameOv;


    
    void Update()
    {
        if (TimeStop == false)
        {
            timeLeftDeci -= Time.deltaTime;
            timeLeft = Mathf.RoundToInt (timeLeftDeci);
        }

        if (TimeStop == true){
            timeLeftDeci = Time.deltaTime;
        }
    
        if (timeLeft < 0){
            gameOv.gameOver();
        }
    
    }

}
