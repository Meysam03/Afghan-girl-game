using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float playerSpeed;              // Denna variabel kommer att best�mma hur snabbt v�r spelare kommer att r�ra sig.//
    private Rigidbody2D rb;                // Jag kommer att anv�nda Rigidbody f�r att ha enkelt fysik f�r mitt spelare objekt.//
    private Vector2 playerDirection;        // Denna variabel kommer att l�sa av v�r spelare input//
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();                  // Jag h�mtar Rigidbody2D fr�n mitt Player spelobjekt //
        
    }


    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");                   // anv�nder "directionY" f�r att uppt�cka vilket knapp anv�ndaren trycker p�.//
        playerDirection = new Vector2(0, directionY).normalized;          
    }

void FixedUpdate()
{
  rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);          // Skrev 0 p� x f�r kordinater eftersom min spelare objekt kommer bara flytta sig upp och ner med tangeter//  
    }
}