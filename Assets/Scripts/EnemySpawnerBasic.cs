using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBasic : MonoBehaviour
{
    [SerializeField]
    private float spawnRateSec;
    [SerializeField]
    private float spawnGroupRate;
    [SerializeField]

    private GameObject basicEnemy;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BasicSpawn", 0, spawnGroupRate);
        InvokeRepeating("BasicSpawn", spawnRateSec, spawnGroupRate);
        InvokeRepeating("BasicSpawn", spawnRateSec * 2, spawnGroupRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BasicSpawn()
    {
        Instantiate(basicEnemy, this.transform.position, Quaternion.identity);
    }
}
