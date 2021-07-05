using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    Transform transform;

    Transform hazardTransform;

    public GameObject insult;

    float timer = 3f;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();

        hazardTransform = GameObject.Find("Hazard Generator").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (transform.position.x, (Mathf.Sin(Time.time) * 1.75f) - 1.25f, transform.position.z);

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(insult, transform.position, transform.rotation, hazardTransform);
            timer = Random.Range(3f, 8f);
        }
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Insult(Clone)" && other.gameObject.GetComponent<BossInsult>().isReflected == true)
        {
            Destroy(other.gameObject);
        }
    }

}
