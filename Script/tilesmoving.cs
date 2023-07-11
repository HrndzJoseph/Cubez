using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilesmoving : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        FindObjectOfType<AudioManager>().play("Tiles");
        Collider.Destroy(gameObject);
    }
}
