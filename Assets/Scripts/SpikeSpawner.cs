using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public float maxTime = 3;
    private float timer = 0;
    public GameObject spike;
    public float height;

    void Start()
    {
        GameObject newSpike = Instantiate(spike);
        newSpike.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newSpike = Instantiate(spike);
            newSpike.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newSpike, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
