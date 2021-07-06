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
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        

var velocity = transform.position - lastPos;
 lastPos = transform.position;

 if (velocity.x > 0.005)
 {
     
      Bee.SetBool("goodmorning", false);
    
 }

 if (velocity.x < 0.005)
 {
    
     Bee.SetBool("goodmorning", true);

    
 }
    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

   
}
