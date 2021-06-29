using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedBlock : Hazard
{
    BoxCollider2D movingThingBoxCollider;
    public Transform transform1;

    void Start()
    {
        transform1 = GetComponent<Transform>();

        movingThingTransform = GameObject.Find("MovingThing").GetComponent<Transform>();
        movingThingBoxCollider = GameObject.Find("MovingThing").GetComponent<BoxCollider2D>();
    }

    void OnBecameInvisible()
    {
        transform1.position = new Vector3(transform1.position.x + movingThingBoxCollider.bounds.size.x, transform1.position.y, transform1.position.z);
    }
}
