using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIThings2 : MonoBehaviour
{
    public Image image;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    static public int blockType;

    static public int[] blockTypeLoadout = new int[5] { 1, 2, 3, 4, 5};

    static public int[] blockTypeInkCost = new int[10] { 30, 15, 10, 10, 40, 25, 35, 5, 50, 99 };

    static public Image[] loadouts = new Image[5];

    static public Transform[] prices = new Transform[blockTypeLoadout.Length];
    public int scrollNumber;

    public Color ice;

    public Sprite blockType1, blockType2, blockType3, blockType4, blockType5, blockType6, blockType7, blockType8, blockType9, blockType10;

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

        prices[0] = GameObject.Find("Price 1").GetComponent<Transform>();
        prices[1] = GameObject.Find("Price 2").GetComponent<Transform>();
        prices[2] = GameObject.Find("Price 3").GetComponent<Transform>();
        prices[3] = GameObject.Find("Price 4").GetComponent<Transform>();
        prices[4] = GameObject.Find("Price 5").GetComponent<Transform>();

        if (blockTypeLoadout == null)
        {
            blockTypeLoadout = new int[5] { 1, 2, 3, 4, 5};
        }

        for (int i = 0; i < blockTypeLoadout.Length; i++)
        {
            TextMeshProUGUI priceText = prices[i].GetChild(0).GetComponent<TextMeshProUGUI>();
            RectTransform rectTransform = loadouts[i].GetComponent<RectTransform>();

            switch (blockTypeLoadout[i])
            {
                case 1:
                    loadouts[i].sprite = blockType1;
                    loadouts[i].color = Color.white;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    loadouts[i].transform.localScale = new Vector3(0.9f, 0.7f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = blockTypeInkCost[0].ToString();
                    break;
                case 2:
                    loadouts[i].sprite = blockType2;
                    loadouts[i].color = Color.white;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    loadouts[i].transform.localScale = new Vector3(-0.8f, 0.7f, 1f);
                    rectTransform.sizeDelta = new Vector2(36.7f, 153.3f);
                    priceText.text = blockTypeInkCost[1].ToString();
                    break;
                case 3:
                    loadouts[i].sprite = blockType3;
                    loadouts[i].color = Color.white;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 180);
                    loadouts[i].transform.localScale = new Vector3(-0.7f, -2.78f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = blockTypeInkCost[2].ToString();
                    break;
                case 4:
                    loadouts[i].sprite = blockType4;
                    loadouts[i].color = Color.white;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 90);
                    loadouts[i].transform.localScale = new Vector3(-0.7f, 2.78f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = blockTypeInkCost[3].ToString();
                    break;
                case 5:
                    loadouts[i].sprite = blockType5;
                    loadouts[i].color = Color.white;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    loadouts[i].transform.localScale = new Vector3(0.7f, 2.78f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = blockTypeInkCost[4].ToString();
                    break;
                case 6:
                    loadouts[i].sprite = blockType6;
                    loadouts[i].color = Color.white;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    loadouts[i].transform.localScale = new Vector3(1f, 1f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = blockTypeInkCost[5].ToString();
                    break;

                case 7:
                    loadouts[i].sprite = blockType7;
                    loadouts[i].color =  Color.white;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    loadouts[i].transform.localScale = new Vector3(0.7f, 3.4f, 1f);
                    rectTransform.sizeDelta = new Vector2(91.1f, 19.4f);
                    priceText.text = blockTypeInkCost[6].ToString();
                    break;

                case 8:
                    loadouts[i].sprite = blockType8;
                    loadouts[i].color =  ice;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    loadouts[i].transform.localScale = new Vector3(0.7f, 3.4f, 1f);
                    rectTransform.sizeDelta = new Vector2(91.1f, 19.4f);
                    priceText.text = blockTypeInkCost[7].ToString();
                    break;
                case 9:
                    loadouts[i].sprite = blockType9;
                    loadouts[i].color =  Color.white;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    loadouts[i].transform.localScale = new Vector3(0.7f, 3.4f, 1f);
                    rectTransform.sizeDelta = new Vector2(91.1f, 19.4f);
                    priceText.text = blockTypeInkCost[8].ToString();
                    break;
                case 10:
                    loadouts[i].sprite = blockType10;
                    loadouts[i].color =  Color.white;
                    loadouts[i].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    loadouts[i].transform.localScale = new Vector3(0.7f, 3.4f, 1f);
                    rectTransform.sizeDelta = new Vector2(91.1f, 19.4f);
                    priceText.text = blockTypeInkCost[9].ToString();
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

    }

    public void two()
    {
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = blockTypeLoadout[1];
    }

    public void three()
    {
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = blockTypeLoadout[2];
    }

    public void four()
    {
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = blockTypeLoadout[3];
    }

    public void five()
    {
        image5.color = new Color(image.color.r, image.color.g, image.color.b, 0.36f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image2.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image3.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        image4.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        blockType = blockTypeLoadout[4];
    }
}
