using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpitball : Hazard
{
    public float speed = -0.03f;

    public bool isReflected = false;

    // Start is called before the first frame update
    void Start()
    {
        transform1 = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform1.position = new Vector3(transform1.position.x + speed, transform1.position.y, transform1.position.z);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
