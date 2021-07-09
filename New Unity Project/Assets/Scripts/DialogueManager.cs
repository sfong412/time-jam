using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public string[] lines;

    public string[] lines2;

    public Dialogue dialogue;

    public int eventNumber;

    public bool one3 = false;

    public bool complete;

    public bool thatonething;

    public GameObject flag;

    public GameObject[] spawnPoints;

    public flag Flag2;

    public GameObject spike;

    public GameObject hazardManager;

    public GameObject UISelector;

    public GameObject placedBlockShadow;

    public GameObject birds;

    public GameObject birds2;

    public Transform blocks;

    public GameObject blocks2;

    public Gameplay1 scroll;

    public HazardGenerator1 generator1;

    public Image TimerBorder;

    public Image TimerFill;

    public Text timer;

    public UIThings Timer;

    int childs;
    

    void Awake()
    {
        flag.transform.localScale = new Vector3(0, 0 , 0);
        thatonething = false;
        TimerFill = GameObject.Find("Fillbots").GetComponent<Image>();
        TimerBorder = GameObject.Find("Timer").GetComponent<Image>();
        timer = GameObject.Find("Textbots").GetComponent<Text>();
        generator1.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
      
        
            if (eventNumber == 0)
            {
                one();
                if (complete == true)
                {
                     dialogue.NextEvent();
                    complete = false;
                dialogue.startNextThing= true;
               
                }
            }
            else if (eventNumber == 1)
            {
                two();
            }
            else if (eventNumber == 2)
            {
                three();
            }
            else if (eventNumber == 3)
            {
                four();
            }
            else if (eventNumber == 4)
            {
                five();
            }
            else if (eventNumber == 5)
            {
                six();
            }
            else if (eventNumber == 6)
            {
                seven();
            }
            else if (eventNumber == 7)
            {
                eight();
            }
    
        
    }

    void one()
    {
        if (dialogue.cutscene.textPlaying == false)
        {
             if (dialogue.player.isMoving)
            {
                if (one3 == false)
                {
                    StartCoroutine(one2());
                    
                }
                
            }
        }
           
    
    }

    void two()
    {
        if (dialogue.cutscene.textPlaying == false)
        {
             flag.transform.position = spawnPoints[0].transform.position;
             flag.transform.localScale = new Vector3(5, 5 , 5);
        if (Flag2.flagCaptured == true)
        {
            flag.transform.localScale = new Vector3(0, 0 , 0);
            complete = true;
            Debug.Log("sys");
            dialogue.NextEvent();
            complete = false;
            dialogue.startNextThing= true;
            Flag2.flagCaptured = false;
        }
        }
       
    }

    void three()
    {
         if (dialogue.cutscene.textPlaying == false)
        {
            flag.transform.localScale = new Vector3(5, 5 , 5);
             flag.transform.position = spawnPoints[1].transform.position;
             spike.SetActive(true);
        if (Flag2.flagCaptured == true)
        {
            flag.transform.localScale = new Vector3(0, 0 , 0);
            complete = true;
            Debug.Log("sys");
            dialogue.NextEvent();
            complete = false;
            dialogue.startNextThing= true;
            spike.SetActive(false);
            Flag2.flagCaptured = false;
        }
        }
    }

    void four()
    {
        if (dialogue.cutscene.textPlaying == false)
        {
            flag.transform.localScale = new Vector3(5, 5 , 5);
             flag.transform.position = spawnPoints[2].transform.position;
             if (thatonething == false)
        {
            StartCoroutine(owned());
        }
        }
        
    }

    void five()
    {
        if (dialogue.cutscene.textPlaying == false)
        {
            UISelector.SetActive(true);
            placedBlockShadow.SetActive(true);
             flag.transform.localScale = new Vector3(5, 5 , 5);
             flag.transform.position = spawnPoints[2].transform.position;
        if (Flag2.flagCaptured == true)
        {
            flag.transform.localScale = new Vector3(0, 0 , 0);
            complete = true;
            Debug.Log("sys");
            dialogue.NextEvent();
            complete = false;
            dialogue.startNextThing= true;
            Flag2.flagCaptured = false;
            UISelector.SetActive(false);
            placedBlockShadow.SetActive(false);
            childs = blocks.childCount;
            for(int i = childs - 1; i >= 0; i--)
            {
                GameObject.Destroy(blocks.GetChild(i).gameObject);
            }
            
                
            

        }
        }
    }

    void six()
    {
         if (dialogue.cutscene.textPlaying == false)
        {
            UISelector.SetActive(true);
            placedBlockShadow.SetActive(true);
            flag.transform.localScale = new Vector3(5, 5 , 5);
             flag.transform.position = spawnPoints[3].transform.position;
             birds.SetActive(true);
        if (Flag2.flagCaptured == true)
        {
            flag.transform.localScale = new Vector3(0, 0 , 0);
            complete = true;
            Debug.Log("sys");
            dialogue.NextEvent();
            complete = false;
            dialogue.startNextThing= true;
            birds.SetActive(false);
            Flag2.flagCaptured = false;
             UISelector.SetActive(false);
            placedBlockShadow.SetActive(false);
            childs = blocks.childCount;
            for(int i = childs - 1; i >= 0; i--)
            {
                GameObject.Destroy(blocks.GetChild(i).gameObject);
            }
        }
        }
    }

    void seven()
    {
          if (dialogue.cutscene.textPlaying == false)
        {
            UISelector.SetActive(true);
            placedBlockShadow.SetActive(true);
            flag.transform.localScale = new Vector3(5, 5 , 5);
             flag.transform.position = spawnPoints[4].transform.position;
             birds2.SetActive(true);
        if (Flag2.flagCaptured == true)
        {
            flag.transform.localScale = new Vector3(0, 0 , 0);
            complete = true;
            Debug.Log("sys");
            dialogue.NextEvent();
            complete = false;
            dialogue.startNextThing= true;
            birds2.SetActive(false);
            Flag2.flagCaptured = false;
             UISelector.SetActive(false);
            placedBlockShadow.SetActive(false);
            childs = blocks.childCount;
            for(int i = childs - 1; i >= 0; i--)
            {
                GameObject.Destroy(blocks.GetChild(i).gameObject);
            }
        }
        }
    }

    void eight()
    {
        if (dialogue.cutscene.textPlaying == false)
        {
             flag.transform.localScale = new Vector3(5, 5 , 5);
             flag.transform.position = spawnPoints[5].transform.position;
        UISelector.SetActive(true);
        placedBlockShadow.SetActive(true);
        scroll.scrollSpeed = 0.4f;
        StartCoroutine(missFlag());
        generator1.maxAirEnemies = 10;
        generator1.maxSpikes = 12;
        generator1.enabled = true;

        if (Flag2.flagCaptured == true)
        {
            Timer.OnEnd();
        }

        }
       

    }

    IEnumerator one2()
    {
        yield return new WaitForSeconds(0.01f);
        one3 = true;
        yield return new WaitForSeconds(0.1f);
        if (dialogue.player.isMoving)
        {
            yield return new WaitForSeconds(4f);
            complete = true;
        }
        else
        {
            one3= false;
        }
        yield return new WaitForSeconds(1);
        one3= false;
    }

    IEnumerator owned()
    {
        thatonething = true;
        Debug.Log("sus");
        yield return new WaitForSeconds(4);
         flag.transform.localScale = new Vector3(0, 0 , 0);
            complete = true;
            Debug.Log("sus?");
            dialogue.NextEvent();
            complete = false;
            dialogue.startNextThing= true;
            spike.SetActive(false);
            Flag2.flagCaptured = false;

    }

    IEnumerator missFlag()
    {
        yield return new WaitForSeconds(10);
        scroll.scrollSpeed = 0f;
    }
}
