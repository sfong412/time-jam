using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedBlock : Hazard
{

    public Transform transform1;

    BoxCollider2D blockCollider;

    SpriteRenderer renderer;

    Camera mainCamera;

    BoxCollider2D movingThingBoxCollider;

    public PlacedBlock placedBlock;

    public bool blockPlaced;



    void Start()
    {
        transform1 = GetComponent<Transform>();
        renderer = GetComponent<SpriteRenderer>();
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();

        movingThingTransform = GameObject.Find("MovingThing").GetComponent<Transform>();
        movingThingBoxCollider = GameObject.Find("MovingThing").GetComponent<BoxCollider2D>();
        blockPlaced = true;
    }

    void OnBecameInvisible()
    {
        transform1.position = new Vector3(transform1.position.x + movingThingBoxCollider.bounds.size.x, transform1.position.y, transform1.position.z);
    }
    /*
        void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("Pressed secondary button.");
            }
        }
    */

    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }
    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }
}
