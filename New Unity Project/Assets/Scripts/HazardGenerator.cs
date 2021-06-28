using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardGenerator : MonoBehaviour
{

    Vector3 generatedRandomPosition;
    Vector3 spawnPosition;

    public GameObject hazard;

    Transform transform;
    Transform movingThingTransform;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();

        movingThingTransform = GameObject.Find("MovingThing").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        generatedRandomPosition = new Vector3(movingThingTransform.position.x + 9f, Random.Range(-3.00f, 2.00f), transform.position.z);

        if (transform.childCount <= 0)
        {
            Instantiate(hazard, generatedRandomPosition, transform.rotation, transform);
        }

        Debug.Log(generatedRandomPosition.y);
    }
}
