using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NbOfTiles : MonoBehaviour
{
    public TMP_Text tilesText;

    // Update is called once per frame
    void Update()
    {
        tilesText.text = TilesDestroy.count.ToString();

        
    }
}
