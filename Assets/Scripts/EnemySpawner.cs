using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float timeToSpawn;
    public GameObject objectToSpawn;

    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= timeToSpawn)
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            currentTime = 0;
        }
    }


}
