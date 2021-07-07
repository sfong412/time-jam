using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    Transform transform;

    Transform hazardTransform;

    public GameObject insult;

    public GameObject spitball;

    public float timer = 3f;

    public int health = 3;

    public BossInsult bossThing;

    public Animator boss;

    public Animator cam;

    public bool gotcha;

    public Rigidbody2D goodbye;

    public UIThings huzzah;

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
                        StartCoroutine(insult1());
                        break;
                    case 1:
                        StartCoroutine(spitball2());
                        break;
                }
                timer = Random.Range(1f, 3f);
            }
        }
        else if (health <= 0)
        {
            boss.SetBool("adios", true);
            goodbye.bodyType = RigidbodyType2D.Dynamic;
            StartCoroutine(woo());
            

        }

       

        if (gotcha == true)
        {
           StartCoroutine(hit());
           health -= 1;
           gotcha = false;
        }
    }

    IEnumerator hit()
    {
        boss.SetBool("hit", true);
        cam.SetBool("shook", true);
        yield return new WaitForSeconds(0.1f);
        cam.SetBool("shook", false);
        yield return new WaitForSeconds(0.2f);
        boss.SetBool("hit", false);
    }

    IEnumerator insult1()
    {
        boss.SetBool("insult", true);
        yield return new WaitForSeconds(0.3f);
        boss.SetBool("insult", false);
    }

     IEnumerator spitball2()
    {
        boss.SetBool("ball", true);
        yield return new WaitForSeconds(0.5f);
        Instantiate(spitball, transform.position, transform.rotation, hazardTransform);
         yield return new WaitForSeconds(0.15f);
        boss.SetBool("ball", false);
        
    }

    IEnumerator woo()
    {
        yield return new WaitForSeconds(0.5f);
        huzzah.OnEnd();
    }

     void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "insult")
            {
                gotcha = true;
            }
        }

    

}
