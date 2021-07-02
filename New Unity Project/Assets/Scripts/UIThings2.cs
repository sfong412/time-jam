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
    public int scrollNumber;

    CursorMode cursorMode = CursorMode.Auto;

    Texture2D cursorTexture1, cursorTexture2, cursorTexture3, cursorTexture4, cursorTexture5;

    public UIThings2 uIThings2;

    // Start is called before the first frame update
    void Start()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);

        cursorTexture1 = null;
        cursorTexture2 = null;
        cursorTexture3 = Resources.Load<Texture2D>("Textures/03");
        cursorTexture4 = Resources.Load<Texture2D>("Textures/04");
        cursorTexture5 = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y < -0.1f)
        {
            scrollNumber--;
        }

         if (Input.mouseScrollDelta.y > 0.1f)
        {
            scrollNumber++;
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
        blockType = 1;

        //Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    public void two()
    {
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
         image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = 2;

        //Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    public void three()
    {
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
         image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = 3;

        //Cursor.SetCursor(cursorTexture3, Vector2.zero, cursorMode);
    }

    public void four()
    {
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
         image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = 4;

        //Cursor.SetCursor(cursorTexture4, Vector2.zero, cursorMode);
    }

    public void five()
    {
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
         image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = 5;

        //Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
