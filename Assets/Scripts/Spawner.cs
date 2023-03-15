using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fish;
    public GameObject bomb;

    public float xBound, yBound;

    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1,2));

        if (Random.value <= .6f)
        {
            Instantiate(fish, new Vector2(Random.Range(-xBound, xBound), yBound), Quaternion.identity);
        }
        else
        {
            
            Instantiate(bomb, new Vector2(Random.Range(-xBound, xBound), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnRandomGameObject());
    }
}
