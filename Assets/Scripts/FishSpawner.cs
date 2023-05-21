using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public float maxTime = 3;
    private float timer = 0;
    public GameObject fish;
    public float height;

    void Start()
    {
        GameObject newFish = Instantiate(fish);
      
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newFish = Instantiate(fish);
            Destroy(newFish, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
