using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;                          // Dessa 4 variabler behövs eftersom Jag vill att bomb ska spawna inom max och minimum området för varje axel//
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
        float randomX = Random.Range(minX, maxX);  // anledningen till varför jag använder koden  är att jag vill inte bomb ska spawna i samma position// 
        float randomY = Random.Range(minY, maxY);     //  Jag  gör samma sak för y axel.
        // Positionen jag vill att bomben ska visas kommer vara random och 0 på z kordinater eftersom jag kommer inte använda den.// 
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);   

    }
}
