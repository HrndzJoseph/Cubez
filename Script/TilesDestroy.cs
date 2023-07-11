using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesDestroy : MonoBehaviour
{
    public static int count = 0;
    

    /// Destroy(other.gameObject);

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tile"){
            
            count += 1;
            
        }
    } 

    

}
