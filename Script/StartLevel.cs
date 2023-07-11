using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ui;

    public GameObject ui2;
    public GameObject Player;

    void Start()
    {
        Timer.timeLeft = 103;
        Timer.TimeStop = false;
        TilesDestroy.count = 0;
        Invoke("HideUIAfterDelay", 3f); 
    }

    void HideUIAfterDelay()
    {
        ui.SetActive(false);
        ui2.SetActive(true);
        Player.SetActive(true);

    } 
}
