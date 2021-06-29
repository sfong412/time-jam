using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public Transform transform1;

    public Transform movingThingTransform;

  //  SpriteRenderer movingThingSprite;

    // Start is called before the first frame update
    void Start()
    {
        transform1 = GetComponent<Transform>();

        movingThingTransform = GameObject.Find("MovingThing").GetComponent<Transform>();
       // movingThingSprite = GameObject.Find("MovingThing").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < movingThingTransform.position.x)
        {
            
        }

        if (Input.GetMouseButton(0))
        {
               Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
        }
    }


}
