using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopingbackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;


   
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);                // koden �r f�r att best�mma hur snabbt kommer backgrunds bilden flytta p� sig//
    }
}
