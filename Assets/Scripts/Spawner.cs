using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject [] munitionPrefab;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("SpawnBullets", startDelay, spawnInterval);
    }

    void SpawnBullets() {
        int bulletIndex = Random.Range(0, munitionPrefab.Length);
        Instantiate(munitionPrefab[bulletIndex], transform.position, munitionPrefab[bulletIndex].transform.rotation);


    }



}
