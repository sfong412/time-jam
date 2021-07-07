using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopioAI : MonoBehaviour
{
    public float Speed;

    public float shouldIJump;
    public bool shouldIReally;
    public bool shouldIReally2;

    public bool high;

    public bool ignore;
    public int direction = 1;

    public bool stopim;

    public bool shouldI;


public Rigidbody2D rigidbody2D1;


    public Animator Scopio;


  //  SpriteRenderer movingThingSprite;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Awake()
    {
        ignore = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch(direction)
        {
            case 0:
            MoveLeft();
            break;

            case 1: 
            MoveRight();
            break;
        }

        if (shouldIReally == true)
        {
            if (shouldI == true)
            {
            Jump();
            shouldIReally = false;
            }
           
        }

        if (high == true)
        {
            if (shouldI == true)
            {
            Jump2();
            high = false;
            }
           
        }
        
        if (stopim == true)
        {
            rigidbody2D1.velocity = new Vector3(0, 0, 0);
            stopim = false;
        }
        
    }

    void FixedUpdate()
    {
        shouldIJump = Random.Range(0, 50);
        
        switch(shouldIJump)
        {
            case 0:
            shouldIReally = true;
            break;
        }

    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

  
       
     
   

   void MoveLeft()
   {
       Scopio.SetBool("right", true);
       transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime * Speed;
   }

   void MoveRight()
   {
         Scopio.SetBool("right", false);
        transform.position += new Vector3(-Speed + 0.4f, 0, 0) * Time.deltaTime * Speed;

   }

   void Jump()
   {
       rigidbody2D1.AddForce(new Vector2(0, 1), ForceMode2D.Impulse);
   }

    void Jump2()
   {
       rigidbody2D1.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
   }



    

   


}
