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
            Destroy(this.gameObject);                 // när bomben träffar en spel objekt med dessa tag, det kommer att förstöras.//
        }

        else if (collision.tag == "Player")
        {
            Destroy(player.gameObject);                   // Vi behöver kontrollera om spelaren träffar bombem. ska spelaren förlura!//
        }
    }

}
