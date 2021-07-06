using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSelector : MonoBehaviour
{
    public GameObject platforms1;

    public GameObject platforms2;

    public GameObject platforms3;

    public GameObject platforms4;

    HazardGenerator generator;
    void Start()
    {
        generator = GameObject.Find("Hazard Generator").GetComponent<HazardGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        int randomNumber = Random.Range(0, 4);
        switch (randomNumber)
        {
            case 0:
                generator.platformSpawnY = Random.Range(-2.5f, -1.5f);
                generator.currentPlatform = platforms1;
                break;
            case 1:
                generator.platformSpawnY = Random.Range(-6.25f, -3.35f);
                generator.currentPlatform = platforms2;
                break;
            case 2:
             //   generator.platformSpawnY = Random.Range(-2.5f, -1.5f);
                generator.currentPlatform = null;
                break;

            case 3: 
            generator.platformSpawnY = -3.35f;
            generator.currentPlatform = platforms4;
            break;
        }
    }
}
