using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalSystem3 : MonoBehaviour
{
    public Score score;
    public GameObject medalG1;
    public GameObject medalS1;
    public GameObject medalB1;
    public GameManager GM;



    // Update is called once per frame
    void Update()
    {
        if (score.finalScore <= 5999){
            GM.noMedal3Earn=true;

        }
        else if (score.finalScore >= 6000 && score.finalScore <= 7999){
            medalB1.SetActive(true);
            GM.medalB3Earn=true;
   
        }
        else if (score.finalScore >= 8000 && score.finalScore <= 9999){
            medalS1.SetActive(true);
            medalB1.SetActive(false);
            GM.medalS3Earn=true;
            
        }
        else if (score.finalScore >= 10000){
            medalG1.SetActive(true);
            medalS1.SetActive(false);
            medalB1.SetActive(false);
            GM.medalG3Earn=true;
            
        }
        
    }
}
