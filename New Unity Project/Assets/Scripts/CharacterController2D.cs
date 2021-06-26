using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Made by Color!Please Studios

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class CharacterController2D : MonoBehaviour
{

    public float MovementSpeed = 1f;
    public float JumpForce = 1f;

    public bool isgrounded;

    public Rigidbody2D rb2d; 
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        //Horizontal Movement 
        var movementx = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movementx, 0, 0) * Time.deltaTime * MovementSpeed;
        //Vertical Movement 
        //var movementy = Input.GetAxis("Vertical");
        //transform.position += new Vector3(0, movementy, 0) * Time.deltaTime * MovementSpeed;
        

        

        
    }

    void Update()
    {
        //MAKE SURE TO HAVE A "GROUND" TAG WITH A TRIGGER IF YOU WANT TO USE THE JUMPING FUNCTION
        if (Input.GetButtonDown("Jump") && isgrounded == true)
        {
            rb2d.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            isgrounded = true;
        }
       
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            isgrounded = false;
        }
    }
}
