using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CquirrelAI : MonoBehaviour
{
    public Transform transform1;
    public float Speed;
    public float velocity;

public Rigidbody2D rigidbody2D;

public Vector3 lastPos;

    public bool detected;

    public Animator Cquirrel;

    Transform target;


  //  SpriteRenderer movingThingSprite;

    // Start is called before the first frame update
    void Start()
    {
        transform1 = GetComponent<Transform>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
               Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }

        if (detected == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }

var velocity = transform.position - lastPos;
 lastPos = transform.position;

 if (velocity.x > 0.005)
 {
     
      Cquirrel.SetBool("Pointing", false);
    
 }

 if (velocity.x < 0.005)
 {
    
     Cquirrel.SetBool("Pointing", true);

    
 }
    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "catchMe")
        {
            StartCoroutine(noticed());
        }

        if (other.tag == "Hazard")
        {
           detected = false; 
           Cquirrel.SetBool("Detected", false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "catchMe")
        {
            detected = false;
        }
    }

    IEnumerator noticed()
    {
        Cquirrel.SetBool("Detected", true);
        yield return new WaitForSeconds(1);
        detected = true; 
    }


}
