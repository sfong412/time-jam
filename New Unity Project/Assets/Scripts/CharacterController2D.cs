using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Made by Color!Please Studios

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class CharacterController2D : MonoBehaviour
{

    public float MovementSpeed;
    public float JumpForce;

    public bool isgrounded;

    public Rigidbody2D rb2d;

    public UIThings itsTimeToStop;

    public bool jumpHigh;

    public Animator Player;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if (itsTimeToStop.stopping == false)
        {
            var movementx = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movementx, 0, 0) * Time.deltaTime * MovementSpeed;
            Player.SetFloat("X", movementx);
        }
        else
        {
            Player.SetBool("time", true);
            rb2d.constraints = RigidbodyConstraints2D.FreezeAll;    
        }

    }

    void Update()
    {
        //MAKE SURE TO HAVE A "GROUND" TAG WITH A TRIGGER IF YOU WANT TO USE THE JUMPING FUNCTION
        if (Input.GetButtonDown("Jump") && isgrounded == true)
        {
             if (itsTimeToStop.stopping == false)
             {
                 rb2d.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            Player.SetBool("Jumped", true);
             }
            
            //Debug.Log("jumped");
        }

        if (jumpHigh == true)

{
    rb2d.AddForce(new Vector2(0, JumpForce + 1), ForceMode2D.Impulse);
    Player.SetBool("Jumped", true);
    jumpHigh = false;
}

      


    }


   
}
