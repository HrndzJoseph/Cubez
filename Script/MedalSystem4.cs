using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalSystem4 : MonoBehaviour
{
    public Score score;
    public GameObject medalG1;
    public GameObject medalS1;
    public GameObject medalB1;
    public GameManager GM;



    // Update is called once per frame
    void Update()
    {
        if (score.finalScore <= 3999){
            GM.noMedal4Earn=true;

        }
        else if (score.finalScore >= 4000 && score.finalScore <= 5999){
            medalB1.SetActive(true);
            GM.medalB4Earn=true;
   
        }
        else if (score.finalScore >= 6000 && score.finalScore <= 9999){
            medalS1.SetActive(true);
            medalB1.SetActive(false);
            GM.medalS4Earn=true;
            
        }
        else if (score.finalScore >= 10000){
            medalG1.SetActive(true);
            medalS1.SetActive(false);
            medalB1.SetActive(false);
            GM.medalG4Earn=true;
            
        }
        
    }
}
