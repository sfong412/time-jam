using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardGenerator : MonoBehaviour
{

    Vector3 generatedRandomPosition;

    float groundSpawnTime = 2f;

    float airSpawnTime = 5f;

    Vector3 groundHazardSpawnPosition;
    Vector3 ceilingHazardSpawnPosition;

    Vector3 nonAirHazardSpawnPosition;


    Vector3 airHazardSpawnPosition;

    float groundHazardTimer;
    float airHazardTimer;


    int randomNumber;
    public GameObject hazard;

    Transform transform;
    Transform movingThingTransform;

    BoxCollider2D movingThingBoxCollider;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();

        movingThingTransform = GameObject.Find("MovingThing").GetComponent<Transform>();
        movingThingBoxCollider = GameObject.Find("MovingThing").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        //spawn positions for floor / ceiling hazards
        Vector3 groundHazardSpawnPosition = new Vector3(movingThingTransform.position.x + movingThingBoxCollider.bounds.size.x/2 + Random.Range(-1.00f, 4.00f), -2f, transform.position.z);

        Vector3 ceilingHazardSpawnPosition = new Vector3(movingThingTransform.position.x + movingThingBoxCollider.bounds.size.x/2 + Random.Range(-1.00f, 4.00f), 2f, transform.position.z);

        //random number generator to randomize floor/ceiling hazard generation
        randomNumber = Random.Range(0, 2);
        switch(randomNumber)
        {
            case 0:
                nonAirHazardSpawnPosition = groundHazardSpawnPosition;
                break;
            case 1:
                nonAirHazardSpawnPosition = ceilingHazardSpawnPosition;
                break;
        }

        //spawn position for air hazards
        Vector3 airHazardSpawnPosition = new Vector3(movingThingTransform.position.x + movingThingBoxCollider.bounds.size.x/2 + Random.Range(-2.00f, 8.00f), Random.Range(-2.00f, 2.00f), transform.position.z);

        Timer();
        spawnHazard(nonAirHazardSpawnPosition, 0, 3, groundHazardTimer);
        spawnHazard(airHazardSpawnPosition, 1, 1, airHazardTimer);
    }

    //Function for spawning hazards
    void spawnHazard(Vector3 spawnPosition, int index, int maxHazards, float timer)
    {
        if (transform.GetChild(index).childCount <= maxHazards && timer <= 0)
        {
            Instantiate(hazard, spawnPosition, transform.rotation, transform.GetChild(index));
        }
    }

    void Timer()
    {
        groundHazardTimer -= Time.deltaTime;
        airHazardTimer -= Time.deltaTime;

        if (groundHazardTimer <= 0)
        {
            groundHazardTimer = Random.Range(0f, 2f);
        }

        if (airHazardTimer <= 0)
        {
            groundHazardTimer = Random.Range(0f, 24f);
        }
    }
}
