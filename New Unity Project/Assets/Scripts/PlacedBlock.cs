using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedBlock : Hazard
{

    public Transform transform1;

    BoxCollider2D blockCollider;

    SpriteRenderer renderer;

    Camera mainCamera;

    BoxCollider2D movingThingBoxCollider;

    public PlacedBlock placedBlock;

    public bool blockPlaced;

    public UIThings3 eraser;

    public Animator block;



    void Start()
    {
        transform1 = GetComponent<Transform>();
        renderer = GetComponent<SpriteRenderer>();
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();

        movingThingTransform = GameObject.Find("MovingThing").GetComponent<Transform>();
        movingThingBoxCollider = GameObject.Find("MovingThing").GetComponent<BoxCollider2D>();
        eraser = GameObject.Find("Ink Bar").GetComponent<UIThings3>();
        blockPlaced = true;
    }

    void OnBecameInvisible()
    {
        transform1.position = new Vector3(transform1.position.x + movingThingBoxCollider.bounds.size.x, transform1.position.y, transform1.position.z);
    }
    /*
        void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("Pressed secondary button.");
            }
        }
    */

    private void OnMouseEnter()
    {
        if (eraser.canErase)
        {
            renderer.material.color = Color.red;
            block.SetBool("Bop", true);
        }
        else
        {
            renderer.material.color = Color.gray;
            block.SetBool("Bop", true);
        }
    
    }
    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
        block.SetBool("Bop", false);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (eraser.canErase)
            {
                StartCoroutine(goner());
            }
           
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Insult(Clone)" && other.gameObject.GetComponent<BossInsult>().isReflected == false)
        {
            other.gameObject.GetComponent<BossInsult>().isReflected = true;
            Debug.Log("touched");
        }

        if (other.gameObject.name == "Spitball(Clone)" && other.gameObject.GetComponent<BossSpitball>().isReflected == false)
        {
            other.gameObject.GetComponent<BossSpitball>().speed = 0.05f;
            other.gameObject.GetComponent<BossSpitball>().isReflected = true;
            Debug.Log("touched");
        }
    }

    IEnumerator goner()
    {
        block.SetBool("gone", true);
        eraser.erased = true;
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
