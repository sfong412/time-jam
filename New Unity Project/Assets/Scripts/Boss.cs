using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    Transform transform;

    Transform hazardTransform;

    public GameObject insult;

    public GameObject spitball;

    float timer = 3f;

    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();

        hazardTransform = GameObject.Find("Hazard Generator").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        int randomNumberGenerator = Random.Range(0, 2);

        timer -= Time.deltaTime;

        if (health > 0)
        {
            transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.time) * 1.75f) - 1.25f, transform.position.z);

            if (timer <= 0)
            {
                switch (randomNumberGenerator)
                {
                    case 0:
                        Instantiate(insult, transform.position, transform.rotation, hazardTransform);
                        break;
                    case 1:
                        Instantiate(spitball, transform.position, transform.rotation, hazardTransform);
                        break;
                }
                timer = Random.Range(3f, 8f);
            }
        }
        else if (health < 0)
        {

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Insult(Clone)" && other.gameObject.GetComponent<BossInsult>().isReflected == true)
        {
            health = health - 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Spitball(Clone)" && other.gameObject.GetComponent<BossSpitball>().isReflected == true)
        {
            health = health - 1;
            Destroy(other.gameObject);
        }
    }

}
