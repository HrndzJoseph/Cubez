using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalSystem1 : MonoBehaviour
{
    public Score score;
    public GameObject medalG;
    public GameObject medalS;
    public GameObject medalB;
    public GameManager GM;



    // Update is called once per frame
    void Update()
    {
        if (score.finalScore <= 1000){
            GM.noMedal1Earn=true;

        }
        else if (score.finalScore >= 1001 && score.finalScore <= 2800){
            medalB.SetActive(true);
            GM.medalB1Earn=true;
   
        }
        else if (score.finalScore >= 2801 && score.finalScore <= 3199){
            medalS.SetActive(true);
            medalB.SetActive(false);
            GM.medalS1Earn=true;
            
        }
        else if (score.finalScore >= 3200){
            medalG.SetActive(true);
            medalS.SetActive(false);
            medalB.SetActive(false);
            GM.medalG1Earn=true;
            
        }
        
    }
}
