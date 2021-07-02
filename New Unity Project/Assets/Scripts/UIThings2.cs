using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIThings2 : MonoBehaviour
{
    public Image image;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public int blockType;

    public int[] blockTypeLoadout;
    public int scrollNumber;
    public UIThings2 uIThings2;

    // Start is called before the first frame update
    void Start()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);

        blockTypeLoadout = new int[5] {1, 2, 3, 4, 5};
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y < -0.1f)
        {
            scrollNumber--;
            Debug.Log("impostor");
        }

         if (Input.mouseScrollDelta.y > 0.1f)
        {
            scrollNumber++;
            Debug.Log("impostor2");
        }
        switch(scrollNumber)
        {
            case 0:
            one();
            break;
            
            case 1: 
            three();
            break;

            case 2:
            two();
            break;

            case 3:
            four();
            break;

            case 4:
            five();
            break;
        }

        if (scrollNumber >= 5)
        {
            scrollNumber = 0;
        }
        if (scrollNumber < 0)
        {
            scrollNumber = 4;
        }
    }
//Block Types
    public void one()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = blockTypeLoadout[0];

        //Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    public void two()
    {
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
         image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = blockTypeLoadout[1];

        //Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    public void three()
    {
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
         image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = blockTypeLoadout[2];

        //Cursor.SetCursor(cursorTexture3, Vector2.zero, cursorMode);
    }

    public void four()
    {
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
         image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = blockTypeLoadout[3];

        //Cursor.SetCursor(cursorTexture4, Vector2.zero, cursorMode);
    }

    public void five()
    {
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
         image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = blockTypeLoadout[4];

        //Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
