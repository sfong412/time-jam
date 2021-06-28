using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    Transform transform;

    Transform movingThingTransform;

  //  SpriteRenderer movingThingSprite;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();

        movingThingTransform = GameObject.Find("MovingThing").GetComponent<Transform>();
       // movingThingSprite = GameObject.Find("MovingThing").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < movingThingTransform.position.x)
        {
            
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
