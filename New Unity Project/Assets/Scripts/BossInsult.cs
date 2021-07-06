using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInsult : Hazard
{
    public float chasingPlayerSpeed = 0.025f;
    public float reflectedSpeed = 0.05f;

    public bool isReflected = false;

    public Transform player;
    Transform boss;

    // Start is called before the first frame update
    void Start()
    {
        transform1 = GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        boss = GameObject.Find("Boss").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isReflected == false)
        {
            transform1.position = Vector2.MoveTowards(transform1.position, player.position, chasingPlayerSpeed);
        }
        else
        {
            transform1.position = Vector2.MoveTowards(transform1.position, boss.position, reflectedSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
