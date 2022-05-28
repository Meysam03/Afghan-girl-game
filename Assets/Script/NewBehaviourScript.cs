using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float playerSpeed;              // Denna variabel kommer att bestämma hur snabbt vår spelare kommer att röra sig.//
    private Rigidbody2D rb;                // Jag kommer att använda Rigidbody för att ha enkelt fysik för mitt spelare objekt.//
    private Vector2 playerDirection;        // Denna variabel kommer att läsa av vår spelare input//
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();                  // Jag hämtar Rigidbody2D från mitt Player spelobjekt //
        
    }


    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");                   // använder "directionY" för att upptäcka vilket knapp användaren trycker på.//
        playerDirection = new Vector2(0, directionY).normalized;          
    }

void FixedUpdate()
{
  rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);          // Skrev 0 på x för kordinater eftersom min spelare objekt kommer bara flytta sig upp och ner med tangeter//  
    }
}