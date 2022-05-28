using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoängSystem : MonoBehaviour
{
    public Text scoreText;  // denna variabel kommer att visa spelarens poäng//
    private float score;     // denna variabel kommer att lagra spelarens poäng//


    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)             // vi kontrollerar om spelaren är fortfarande vid liv, eftersom vi vill inte lägga till poäng när spelaren är död//d
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();      //omvandlar till heltal siffror//
        }
        
    }
}
