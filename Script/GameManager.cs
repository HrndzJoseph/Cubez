using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int Tiles = 0;

    public bool medalGEarn = false;
    public bool medalBEarn = false;
    public bool medalSEarn = false;
    public bool noMedalEarn = false;



    public bool medalG1Earn = false;
    public bool medalB1Earn = false;
    public bool medalS1Earn = false;
    public bool noMedal1Earn = false;

    public bool medalG2Earn = false;
    public bool medalB2Earn = false;
    public bool medalS2Earn = false;
    public bool noMedal2Earn = false;

    public bool medalG3Earn = false;
    public bool medalB3Earn = false;
    public bool medalS3Earn = false;
    public bool noMedal3Earn = false;

    public bool medalG4Earn = false;
    public bool medalB4Earn = false;
    public bool medalS4Earn = false;
    public bool noMedal4Earn = false;

    public bool medalG5Earn = false;
    public bool medalB5Earn = false;
    public bool medalS5Earn = false;
    public bool noMedal5Earn = false;

    public void gameOver()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Start()
    {
        medalG1Earn = PlayerPrefs.GetInt("medalG1Earn") == 1;
        medalB1Earn = PlayerPrefs.GetInt("medalB1Earn") == 1;
        medalS1Earn = PlayerPrefs.GetInt("medalS1Earn") == 1;
        noMedal1Earn = PlayerPrefs.GetInt("noMedal1Earn") == 1;

        medalG2Earn = PlayerPrefs.GetInt("medalG2Earn") == 1;
        medalB2Earn = PlayerPrefs.GetInt("medalB2Earn") == 1;
        medalS2Earn = PlayerPrefs.GetInt("medalS2Earn") == 1;
        noMedal2Earn = PlayerPrefs.GetInt("noMedal2Earn") == 1;

        medalG3Earn = PlayerPrefs.GetInt("medalG3Earn") == 1;
        medalB3Earn = PlayerPrefs.GetInt("medalB3Earn") == 1;
        medalS3Earn = PlayerPrefs.GetInt("medalS3Earn") == 1;
        noMedal3Earn = PlayerPrefs.GetInt("noMedal3Earn") == 1;

        medalG4Earn = PlayerPrefs.GetInt("medalG4Earn") == 1;
        medalB4Earn = PlayerPrefs.GetInt("medalB4Earn") == 1;
        medalS4Earn = PlayerPrefs.GetInt("medalS4Earn") == 1;
        noMedal4Earn = PlayerPrefs.GetInt("noMedal4Earn") == 1;

        medalG5Earn = PlayerPrefs.GetInt("medalG5Earn") == 1;
        medalB5Earn = PlayerPrefs.GetInt("medalB5Earn") == 1;
        medalS5Earn = PlayerPrefs.GetInt("medalS5Earn") == 1;
        noMedal5Earn = PlayerPrefs.GetInt("noMedal5Earn") == 1;
    }

   
    void Update()
    {
        PlayerPrefs.SetInt("medalG1Earn", medalG1Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalB1Earn", medalB1Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalS1Earn", medalS1Earn ? 1 : 0);
        PlayerPrefs.SetInt("noMedal1Earn", noMedal1Earn ? 1 : 0);

        PlayerPrefs.SetInt("medalG2Earn", medalG2Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalB2Earn", medalB2Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalS2Earn", medalS2Earn ? 1 : 0);
        PlayerPrefs.SetInt("noMedal2Earn", noMedal2Earn ? 1 : 0);

        PlayerPrefs.SetInt("medalG3Earn", medalG3Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalB3Earn", medalB3Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalS3Earn", medalS3Earn ? 1 : 0);
        PlayerPrefs.SetInt("noMedal3Earn", noMedal3Earn ? 1 : 0);

        PlayerPrefs.SetInt("medalG4Earn", medalG4Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalB4Earn", medalB4Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalS4Earn", medalS4Earn ? 1 : 0);
        PlayerPrefs.SetInt("noMedal4Earn", noMedal4Earn ? 1 : 0);

        PlayerPrefs.SetInt("medalG5Earn", medalG5Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalB5Earn", medalB5Earn ? 1 : 0);
        PlayerPrefs.SetInt("medalS5Earn", medalS5Earn ? 1 : 0);
        PlayerPrefs.SetInt("noMedal5Earn", noMedal5Earn ? 1 : 0);
        PlayerPrefs.Save();
        
    }
    
}
