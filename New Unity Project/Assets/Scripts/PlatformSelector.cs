using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSelector : MonoBehaviour
{
    public GameObject platforms1;

    public GameObject platforms2;

    public GameObject platforms3;

    HazardGenerator generator;
    void Start()
    {
        generator = GameObject.Find("Hazard Generator").GetComponent<HazardGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        int randomNumber = Random.Range(0, 3);
        switch (randomNumber)
        {
            case 0:
            /*
                generator.platformSpawnY = Random.Range(-1.5f, -3f);
                generator.currentPlatform = platforms1;
            */
                generator.currentPlatform = platforms1;
                break;
            case 1:
                generator.platformSpawnY = -0.41f;
                generator.currentPlatform = platforms2;
                break;
            case 2:
                generator.currentPlatform = null;
                break;
        }
    }
}
