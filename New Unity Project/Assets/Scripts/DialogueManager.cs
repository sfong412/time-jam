using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    public string[] lines;

    public string[] lines2;

    public Dialogue dialogue;

    public int eventNumber;

    public bool one3 = false;

    public bool complete;
    

    // Update is called once per frame
    void Update()
    {
        switch(eventNumber)
        {
            case 0:
            one();
            break;
            case 1:
            two();
            break;

        }

        if (complete == true)
        {
             switch(eventNumber)
            {
            case 0:
            dialogue.startNextThing= true;
            dialogue.indexCap = 4;
            dialogue.index2 = 1;
            dialogue.cutscene.textPlaying = true;
            complete = false;
            eventNumber++;
            break;

            }
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
            Debug.Log("done2");
        }
        else
        {
            one3= false;
        }
    }
}
