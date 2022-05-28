using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
    
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "border")
        {
            Destroy(this.gameObject);                 // n�r bomben tr�ffar en spel objekt med dessa tag, det kommer att f�rst�ras.//
        }

        else if (collision.tag == "Player")
        {
            Destroy(player.gameObject);                   // Vi beh�ver kontrollera om spelaren tr�ffar bombem. ska spelaren f�rlura!//
        }
    }

}
