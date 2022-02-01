using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ItemManager : MonoBehaviour
{
    public GameObject berryPrefab;
    public GameObject candyPrefab;
    private int i;
    private float spawnTime;
    public float countdown = 0;


    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(1, 10);
        StartSpawn();
    }

    void StartSpawn()
    {
        if (i > 5)
        {
            InvokeRepeating("berryPrefab", 50f, spawnTime);
        }
        else
        {
            InvokeRepeating("candyPrefab", 50f, spawnTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        countdown += Time.deltaTime;

        if(countdown >= 2)
        {
            float randomChance = Random.Range(0.0f, 1.0f);
            if(randomChance < 0.5f)
            {
                DropBerry();
            }
            else
            {
                DropCandy();
            }

            countdown = 0;
        }

        if(transform.position.y <= -6.5f)
        {
            Destroy(this.gameObject);
        }
    }

    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-8, 8);
        return new Vector2(x, 9);
    }

    void DropBerry()
    {
        Instantiate(berryPrefab, GetSpawnPoint(), Quaternion.identity);
    }

    void DropCandy()
    {
        Instantiate(candyPrefab, GetSpawnPoint(), Quaternion.identity);
    }
}
