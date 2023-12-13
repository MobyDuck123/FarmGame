using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SpawnGameObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnTransform; 
    public float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 0.0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
      
        GameObject tempObject = Instantiate(objectToSpawn, spawnTransform.position, spawnTransform.rotation);
       
       
    }

   
}
