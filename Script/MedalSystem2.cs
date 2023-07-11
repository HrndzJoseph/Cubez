using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalSystem2 : MonoBehaviour
{
    public Score score;
    public GameObject medalG;
    public GameObject medalS;
    public GameObject medalB;
    public GameManager GM;



    // Update is called once per frame
    void Update()
    {
        if (score.finalScore <= 2299){
            GM.noMedal2Earn=true;

        }
        else if (score.finalScore >= 2300 && score.finalScore <= 3999){
            medalB.SetActive(true);
            GM.medalB2Earn=true;
   
        }
        else if (score.finalScore >= 4000 && score.finalScore <= 6499){
            medalS.SetActive(true);
            medalB.SetActive(false);
            GM.medalS2Earn=true;
            
        }
        else if (score.finalScore >= 6500){
            medalG.SetActive(true);
            medalS.SetActive(false);
            medalB.SetActive(false);
            GM.medalG2Earn=true;
            
        }
        
    }
}
