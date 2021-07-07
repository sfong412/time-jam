using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeAI : MonoBehaviour
{
   public Transform transform1;
    public float Speed;
    public float velocity;

public Rigidbody2D rigidbody2D;

public Vector3 lastPos;

    public bool detected;

    public Animator Bee;

    Transform target;

    public float turnThreshhold;

    public SpriteRenderer blue;

    public Color blueballed;


  //  SpriteRenderer movingThingSprite;

    // Start is called before the first frame update
    void Start()
    {
        transform1 = GetComponent<Transform>();
        

       
    }

    // Update is called once per frame
    void Update()
    {   
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
            target = GameObject.FindGameObjectWithTag("catchMe").GetComponent<Transform>();
        

var velocity = transform.position - lastPos;
 lastPos = transform.position;

 if (velocity.x > turnThreshhold)
 {
     
      Bee.SetBool("goodmorning", false);
    
 }

 if (velocity.x < turnThreshhold)
 {
    
     Bee.SetBool("goodmorning", true);

    
 }
    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ice")
        {
            Speed = 0.5f;
            turnThreshhold = 0.003f;
            blue.material.color = Color.Lerp(Color.white, blueballed, 0.3f);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        StartCoroutine(slow());
    }

    void FixedUpdate()
    {
        target = GameObject.FindGameObjectWithTag("catchMe").GetComponent<Transform>();
    }

    IEnumerator slow()
    {
        yield return new WaitForSeconds(1);
        Speed = 1f;
        turnThreshhold = 0.005f;
        blue.material.color = Color.white;
    }

   
}
