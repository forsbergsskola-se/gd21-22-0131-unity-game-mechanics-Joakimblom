
using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class IntervalSpawner : MonoBehaviour
{
  [SerializeField] private float spawnInterval = 5f;

  [SerializeField] private GameObject prefabToSpawn;

  [SerializeField] private Transform spawnPointTransform;

  private float spawnTimer;

  private void OnEnable()
  {
    //var returnValueFromMethod = spawnTimerCoroutine(); This does the same thing as the one below.
    StartCoroutine(spawnTimerCoroutine());
  }
/*
  private void Update()
  {
   RunSpawnTimer();
    
  }

  private void RunSpawnTimer()
  {
     spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnInterval)
        {
         // spawnTimer = 0;//reset timer to zero.
          spawnTimer -= spawnInterval; //Decrease time by spawnInterval. This one will give us a more accurate timer.
          SpawnPrefab();
          
        }
  }
  */

  //A spawn timer implemented as a coroutine. note that the name does NOT need to contain Coroutine
  private IEnumerator spawnTimerCoroutine()
  {
   // var counter = 0;
    while (true) //this creates an infinite loop. Be careful when using infinite loops. We use it here because we can pause the execution inside the coroutine.
    {
     // yield return null; // this pauses the coroutine for one frame.
     yield return new WaitForSeconds(spawnInterval);// this pauses the coroutine for spawnInterval amount of seconds.
      //Debug.Log(counter++);
      
    }
  }
  private void SpawnPrefab()
  {
    Instantiate(prefabToSpawn,spawnPointTransform.position, spawnPointTransform.rotation);
  }
}
