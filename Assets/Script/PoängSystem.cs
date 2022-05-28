using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Po�ngSystem : MonoBehaviour
{
    public Text scoreText;  // denna variabel kommer att visa spelarens po�ng//
    private float score;     // denna variabel kommer att lagra spelarens po�ng//


    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)             // vi kontrollerar om spelaren �r fortfarande vid liv, eftersom vi vill inte l�gga till po�ng n�r spelaren �r d�d//d
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();      //omvandlar till heltal siffror//
        }
        
    }
}
