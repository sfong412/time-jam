using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopioAI : MonoBehaviour
{
    public float Speed;
    public int direction = 1;


public Rigidbody2D rigidbody2D1;


    public Animator Scopio;


  //  SpriteRenderer movingThingSprite;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Awake()
    {
        
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

        
    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

   void OnCollisionEnter2D()
   {
       if (direction == 1)
       {
           direction = 0;
       }
       else
       {
           direction = 1;

       }
   }

   void MoveLeft()
   {
       rigidbody2D1.AddForce(new Vector2(Speed, 0));
   }

   void MoveRight()
   {
        rigidbody2D1.AddForce(new Vector2(-Speed + 0.3f, 0));

   }

   


}
