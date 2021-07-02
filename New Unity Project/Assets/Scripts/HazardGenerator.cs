using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardGenerator : MonoBehaviour
{

    Vector3 generatedRandomPosition;

    float groundSpawnTime = 3f;

    float airSpawnTime = 3f;

    Vector3 groundHazardSpawnPosition;
    Vector3 ceilingHazardSpawnPosition;

    Vector3 nonAirHazardSpawnPosition;


    Vector3 airHazardSpawnPosition;

    Vector3 platformSpawnPosition;
    public float platformSpawnY = -0.41f;

    int groundHazardTimer;
    int airHazardTimer;

    int platformTimer;

    int randomNumber;
    public GameObject hazard;

    public GameObject upsidedownHazard;
    public GameObject airHazard;

    public GameObject platform;

    public GameObject platform2;

    public GameObject Cquirrel;

    public GameObject Scopion;

    public GameObject currentAirHazard;
    public GameObject currentGroundHazard;

    public GameObject currentPlatform;


    Transform transform1;
    Transform movingThingTransform;

    BoxCollider2D movingThingBoxCollider;
    BoxCollider2D platformBoxCollider;

    // Start is called before the first frame update
    void Start()
    {
        transform1 = GetComponent<Transform>();

        movingThingTransform = GameObject.Find("MovingThing").GetComponent<Transform>();
        movingThingBoxCollider = GameObject.Find("MovingThing").GetComponent<BoxCollider2D>();
        platformBoxCollider = platform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //spawn positions for floor / ceiling hazards
        Vector3 groundHazardSpawnPosition = new Vector3(movingThingTransform.position.x + movingThingBoxCollider.bounds.size.x / 2 + Random.Range(-1.00f, 4.00f), -3.78f, transform.position.z);

        Vector3 ceilingHazardSpawnPosition = new Vector3(movingThingTransform.position.x + movingThingBoxCollider.bounds.size.x / 2 + Random.Range(-1.00f, 4.00f), 0.65f, transform.position.z);

        Vector3 platformSpawnPosition = new Vector3(movingThingTransform.position.x + movingThingBoxCollider.bounds.size.x + platformBoxCollider.size.x + Random.Range(-1.00f, 4.00f), platformSpawnY, transform.position.z);

        //random number generator to randomize floor/ceiling hazard generation
        randomNumber = Random.Range(0, 6);
        switch (randomNumber)
        {
            case 0:
                currentGroundHazard = Cquirrel;
                break;
            case 1:
                currentAirHazard = airHazard;
                break;

            case 2:
                currentGroundHazard = hazard;
                break;

            case 3:
                currentGroundHazard = Scopion;  
                break; 
        }

        currentPlatform = platform2;
        platformSpawnY = -0.41f;

        //spawn position for air hazards
        Vector3 airHazardSpawnPosition = new Vector3(movingThingTransform.position.x + movingThingBoxCollider.bounds.size.x / 2 + Random.Range(-2.00f, 8.00f), Random.Range(0.96f, -3.67f), transform.position.z);

        RandomNumberGenerator();
        spawnGroundHazard(groundHazardSpawnPosition, 0, 6, groundHazardTimer);
        spawnCeilingHazard(ceilingHazardSpawnPosition, 0, 6, groundHazardTimer);
        spawnAirHazard(airHazardSpawnPosition, 1, 2, airHazardTimer);

        if (platform != null)
        {
            spawnPlatform(platformSpawnPosition, 3, 1, platformTimer);
        }
    }

    //Function for spawning hazards
    void spawnGroundHazard(Vector3 spawnPosition, int index, int maxHazards, int timer)
    {
        if (transform.GetChild(index).childCount <= maxHazards && timer == 1)
        {
            float size = 1f;

            //clickPoint -= transform.position;

            int xCount = Mathf.RoundToInt(spawnPosition.x / size);
         //   int yCount = Mathf.RoundToInt(spawnPosition.y / size);
            int zCount = Mathf.RoundToInt(spawnPosition.z / size);

            Vector3 result = new Vector3(
                (float)xCount * size,
                //(float)yCount * size,
                spawnPosition.y,
                (float)zCount * size);
            
            Instantiate(currentGroundHazard, result, transform.rotation, transform.GetChild(index));
        }
    }

    void spawnCeilingHazard(Vector3 spawnPosition, int index, int maxHazards, int timer)
    {
        if (transform.GetChild(index).childCount <= maxHazards && timer == 1)
        {
            float size = 1f;

            //clickPoint -= transform.position;

            int xCount = Mathf.RoundToInt(spawnPosition.x / size);
           // int yCount = Mathf.RoundToInt(spawnPosition.y / size);
            int zCount = Mathf.RoundToInt(spawnPosition.z / size);

            Vector3 result = new Vector3(
                (float)xCount * size,
                //(float)yCount * size,
                spawnPosition.y,
                (float)zCount * size);
            
            Instantiate(upsidedownHazard, result, transform.rotation, transform.GetChild(index));
        }
    }

    void spawnAirHazard(Vector3 spawnPosition, int index, int maxHazards, int timer)
    {
        if (transform.GetChild(index).childCount <= maxHazards && timer == 1)
        {
            float size = 0.5f;

            //clickPoint -= transform.position;

            int xCount = Mathf.RoundToInt(spawnPosition.x / size);
            int yCount = Mathf.RoundToInt(spawnPosition.y / size);
            int zCount = Mathf.RoundToInt(spawnPosition.z / size);

            Vector3 result = new Vector3(
                (float)xCount * size,
                (float)yCount * size,
                (float)zCount * size);
            
            Instantiate(currentAirHazard, result, transform.rotation, transform.GetChild(index));
        }
    }

    void spawnPlatform(Vector3 spawnPosition, int index, int maxHazards, int timer)
    {
        if (transform.GetChild(index).childCount <= maxHazards && timer == 1)
        {
            float size = 0.5f;

            //clickPoint -= transform.position;

            int xCount = Mathf.RoundToInt(spawnPosition.x / size);
            int yCount = Mathf.RoundToInt(spawnPosition.y / size);
            int zCount = Mathf.RoundToInt(spawnPosition.z / size);

            Vector3 result = new Vector3(
                (float)xCount * size,
                (float)yCount * size,
                (float)zCount * size);
            
            Instantiate(currentPlatform, result, transform.rotation, transform.GetChild(index));
        }
    }

    void RandomNumberGenerator()
    {
        groundHazardTimer = Random.Range(0, 30);
        airHazardTimer = Random.Range(0, 100);
        platformTimer = Random.Range(0, 100);
    }
}
