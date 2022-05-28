using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;                          // Dessa 4 variabler beh�vs eftersom Jag vill att bomb ska spawna inom max och minimum omr�det f�r varje axel//
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;



    void Update()
    {
        if (Time.time > spawnTime)                     
        {
            spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    } 

    void spawn()
    {
        float randomX = Random.Range(minX, maxX);  // anledningen till varf�r jag anv�nder koden  �r att jag vill inte bomb ska spawna i samma position// 
        float randomY = Random.Range(minY, maxY);     //  Jag  g�r samma sak f�r y axel.
        // Positionen jag vill att bomben ska visas kommer vara random och 0 p� z kordinater eftersom jag kommer inte anv�nda den.// 
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);   

    }
}
