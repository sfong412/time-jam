using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gone : MonoBehaviour
{

    public Animator button;

    public Animator camera2;

    public GameObject button1;

    public GameObject airHazards;

    public GameObject groundHazards;

    public audioFix1 boom;

    public bool pushed = true;

    // Start is called before the first frame update
    void Start()
    {
        airHazards = GameObject.Find("Air Hazards");
        groundHazards = GameObject.Find("Ground Enemies");
        camera2 = GameObject.Find("Main Camera").GetComponent<Animator>();
        boom = GameObject.Find("AudioController (2)").GetComponent<audioFix1>();
        pushed = true;
    }

    void Awake()
    {
        pushed = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
           if (other.tag == "Player")
        {
            boom.kaboom = true;
            StartCoroutine(camShake());
            button.SetBool("pressed", true);
            StartCoroutine(gone2());
        }
        
       
    }

    IEnumerator pressed()
   {
       yield return new WaitForSeconds(0.25f);
       Destroy(button1);
   }

   IEnumerator gone2()
   {
       airHazards.SetActive(false);
       groundHazards.SetActive(false);
       yield return new WaitForSeconds(3);
       airHazards.SetActive(true);
       groundHazards.SetActive(true);
       StartCoroutine(pressed());
   }

   IEnumerator camShake()
   {
        camera2.SetBool("shook", true);
        yield return new WaitForSeconds(0.1f);
        camera2.SetBool("shook", false);
   }

}
