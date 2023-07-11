using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedalSelectionMenu : MonoBehaviour
{
    public GameObject medalG1;
    public GameObject medalS1;
    public GameObject medalB1;

    public GameObject medalG2;
    public GameObject medalS2;
    public GameObject medalB2;

    public GameObject medalG3;
    public GameObject medalS3;
    public GameObject medalB3;

    public GameObject medalG4;
    public GameObject medalS4;
    public GameObject medalB4;

    public GameObject medalG5;
    public GameObject medalS5;
    public GameObject medalB5;
    public GameManager GM;

    public bool medalActiveG1 = false;
    public bool medalActiveS1 = false;
    public bool medalActiveB1 = false;

    public bool medalActiveG2 = false;
    public bool medalActiveS2 = false;
    public bool medalActiveB2 = false;

    public bool medalActiveG3 = false;
    public bool medalActiveS3 = false;
    public bool medalActiveB3 = false;

    public bool medalActiveG4 = false;
    public bool medalActiveS4 = false;
    public bool medalActiveB4 = false;

    public bool medalActiveG5 = false;
    public bool medalActiveS5 = false;
    public bool medalActiveB5 = false;


   
    void Start()
    {
        GM.medalG1Earn = PlayerPrefs.GetInt("medalG1Earn") == 1;
        GM.medalB1Earn = PlayerPrefs.GetInt("medalB1Earn") == 1;
        GM.medalS1Earn = PlayerPrefs.GetInt("medalS1Earn") == 1;
        GM.noMedal1Earn = PlayerPrefs.GetInt("noMedal1Earn") == 1;

        GM.medalG2Earn = PlayerPrefs.GetInt("medalG2Earn") == 1;
        GM.medalB2Earn = PlayerPrefs.GetInt("medalB2Earn") == 1;
        GM.medalS2Earn = PlayerPrefs.GetInt("medalS2Earn") == 1;
        GM.noMedal2Earn = PlayerPrefs.GetInt("noMedal2Earn") == 1;

        GM.medalG3Earn = PlayerPrefs.GetInt("medalG3Earn") == 1;
        GM.medalB3Earn = PlayerPrefs.GetInt("medalB3Earn") == 1;
        GM.medalS3Earn = PlayerPrefs.GetInt("medalS3Earn") == 1;
        GM.noMedal3Earn = PlayerPrefs.GetInt("noMedal3Earn") == 1;

        GM.medalG4Earn = PlayerPrefs.GetInt("medalG4Earn") == 1;
        GM.medalB4Earn = PlayerPrefs.GetInt("medalB4Earn") == 1;
        GM.medalS4Earn = PlayerPrefs.GetInt("medalS4Earn") == 1;
        GM.noMedal4Earn = PlayerPrefs.GetInt("noMedal4Earn") == 1;

        GM.medalG5Earn = PlayerPrefs.GetInt("medalG5Earn") == 1;
        GM.medalB5Earn = PlayerPrefs.GetInt("medalB5Earn") == 1;
        GM.medalS5Earn = PlayerPrefs.GetInt("medalS5Earn") == 1;
        GM.noMedal5Earn = PlayerPrefs.GetInt("noMedal5Earn") == 1;
        
    }
    void Update()
    {
        if (GM.medalG1Earn & !medalActiveG1){
            medalG1.SetActive(true);
        }
        if (GM.medalS1Earn & !medalActiveS1){
            medalS1.SetActive(true);
        }
        if (GM.medalB1Earn & !medalActiveB1){
            medalB1.SetActive(true);
        }

        

        if (GM.medalB2Earn & !medalActiveB2){
            medalB2.SetActive(true);
        }

        if (GM.medalS2Earn & !medalActiveS2){
            medalS2.SetActive(true);
        }

        if (GM.medalG2Earn & !medalActiveG2){
            medalG2.SetActive(true);
        }



        if (GM.medalG3Earn & !medalActiveG3){
            medalG3.SetActive(true);  
        }
        if (GM.medalS3Earn & !medalActiveS3){
            medalS3.SetActive(true);
        }
        if (GM.medalB3Earn & !medalActiveB3){
            medalB3.SetActive(true);
        }



        if (GM.medalB4Earn & !medalActiveB4){
            medalB4.SetActive(true);
        }

        if (GM.medalS4Earn & !medalActiveS4){
            medalS4.SetActive(true);
        }

        if (GM.medalG4Earn & !medalActiveG4){
            medalG4.SetActive(true);
        }



        if (GM.medalB5Earn & !medalActiveB5){
            medalB5.SetActive(true);
        }

        if (GM.medalS5Earn & !medalActiveS5){
            medalS5.SetActive(true);
        }

        if (GM.medalG5Earn & !medalActiveG5){
            medalG5.SetActive(true);
        }
    }

    
}
