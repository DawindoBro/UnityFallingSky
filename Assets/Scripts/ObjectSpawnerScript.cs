using UnityEngine;
using System.Collections;
public class ObjectSpawnerScript : MonoBehaviour
{
    public GameObject ScoreObject;
    public GameObject EnemyObject;

    public float delay = 3;
    public float ProgressDelay = 2;
    public float MaxDelay = 0.1f;
    public float Progress = 0.4f;
    public int offset =10;


    [Range(0, 1)]
    public float scoreSpawnChance = 0.2f;

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
        StartCoroutine(DelayReducer());
    }

    IEnumerator DelayReducer()
    {
        while (delay > MaxDelay)
        {
            delay = delay -Progress;
            yield return new WaitForSeconds(ProgressDelay);
        }
    }
    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            
            determineAndSpawn();
            yield return new WaitForSeconds(delay);
        }
    }

    void determineAndSpawn()
    {
        Vector3 spawnPos = new Vector3(
            transform.position.x + Random.Range(-offset, offset),
            transform.position.y,
            transform.position.z
        );

        if(Random.value < scoreSpawnChance)
        {
            Instantiate(ScoreObject, spawnPos, Quaternion.identity);
        }
        else
        {
            Instantiate(EnemyObject, spawnPos, Quaternion.identity);
        }
    }
}
