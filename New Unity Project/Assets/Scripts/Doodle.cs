using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doodle : MonoBehaviour
{
    public Transform transform1;

    public Transform movingThingTransform;

    public Sprite[] doodles;

    public Sprite currentDoodle;

    public HazardGenerator doodleMan;

    public int currentDoodleNumber;

    public SpriteRenderer doodle;

  //  SpriteRenderer movingThingSprite;

    // Start is called before the first frame update
    void Start()
    {
        transform1 = GetComponent<Transform>();

        movingThingTransform = GameObject.Find("MovingThing").GetComponent<Transform>();
        doodleMan = GameObject.Find("Hazard Generator").GetComponent<HazardGenerator>();
        doodle = gameObject.GetComponent<SpriteRenderer>();      
         // movingThingSprite = GameObject.Find("MovingThing").GetComponent<SpriteRenderer>();
    }

    void Awake()
    {
             doodleMan = GameObject.Find("Hazard Generator").GetComponent<HazardGenerator>();
             currentDoodleNumber = Random.Range(0, 37);
             doodle.sprite = doodles[currentDoodleNumber];
             
             
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < movingThingTransform.position.x)
        {
            
        }

        if (Input.GetMouseButton(0))
        {
               Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }


    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       
       if (other.tag == "doodle")
       {
           Destroy(gameObject);
       }
    }


}
