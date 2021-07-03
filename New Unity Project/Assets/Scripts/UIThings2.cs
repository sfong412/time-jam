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
    static public int blockType;

    static public int[] blockTypeLoadout = new int[5] { 1, 2, 3, 4, 5 };

    static public Image[] loadouts = new Image[5];
    public int scrollNumber;

    public Sprite blockType1, blockType2, blockType3, blockType4, blockType5;

    // Start is called before the first frame update
    void Start()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);

        loadouts[0] = GameObject.Find("Platform 1").GetComponent<Image>();
        loadouts[1] = GameObject.Find("Platform 2").GetComponent<Image>();
        loadouts[2] = GameObject.Find("Platform 3").GetComponent<Image>();
        loadouts[3] = GameObject.Find("Platform 4").GetComponent<Image>();
        loadouts[4] = GameObject.Find("Platform 5").GetComponent<Image>();

        if (blockTypeLoadout == null)
        {
            blockTypeLoadout = new int[5] { 1, 2, 3, 4, 5 };
        }

        for (int i = 0; i < blockTypeLoadout.Length; i++)
        {
            switch (blockTypeLoadout[i])
            {
                case 1:
                    loadouts[i].sprite = blockType1;
                    break;
                case 2:
                    loadouts[i].sprite = blockType2;
                    break;
                case 3:
                    loadouts[i].sprite = blockType3;
                    break;
                case 4:
                    loadouts[i].sprite = blockType4;
                    break;
                case 5:
                    loadouts[i].sprite = blockType5;
                    break;
            }
        }
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
        switch (scrollNumber)
        {
            case 0:
                one();
                break;

            case 1:
                two();
                break;

            case 2:
                three();
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
