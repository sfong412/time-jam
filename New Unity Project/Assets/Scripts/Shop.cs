using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class Shop : MonoBehaviour
{
    public GameObject blackFade;

    public GameObject shopScreen;
    public GameObject perkScreen;
    public Animator blackFade2;

    public Animator audioFade2;

    public int nextRoundNumber;
    UIThings2 ui;

    bool isBuying = false;

    int blockType;

    int currentBlockType;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.Find("Selectors").GetComponent<UIThings2>();

        if (UIThings2.blockTypeLoadout == null)
        {
            UIThings2.blockTypeLoadout = new int[6] { 1, 2, 3, 4, 5, 6 };
        }
    }

    // Update is called once per frame
    void Update()
    {
        DisplayPerkState(GameObject.Find("Ink Regen Perk Button"));
    }

    void Awake()
    {
        StartCoroutine(blackFade22());
    }

    public void SelectItem(int blockType)
    {
        isBuying = true;
        currentBlockType = blockType;
    }

    public void PlaceItem(int platform)
    {
        if (isBuying == true)
        {
            TextMeshProUGUI priceText = UIThings2.prices[platform].GetChild(0).GetComponent<TextMeshProUGUI>();
            UIThings2.blockTypeLoadout[platform] = currentBlockType;
            RectTransform rectTransform = UIThings2.loadouts[platform].GetComponent<RectTransform>();

            switch (currentBlockType)
            {
                case 1:
                    UIThings2.loadouts[platform].sprite = ui.blockType1;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(0.9f, 0.7f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[0].ToString();
                    break;
                case 2:
                    UIThings2.loadouts[platform].sprite = ui.blockType2;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(-0.8f, 0.7f, 1f);
                    rectTransform.sizeDelta = new Vector2(36.7f, 153.3f);
                    priceText.text = UIThings2.blockTypeInkCost[1].ToString();
                    break;
                case 3:
                    UIThings2.loadouts[platform].sprite = ui.blockType3;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 180);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(-0.7f, -2.78f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[2].ToString();
                    break;
                case 4:
                    UIThings2.loadouts[platform].sprite = ui.blockType4;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 90);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(-0.7f, 2.78f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[3].ToString();
                    break;
                case 5:
                    UIThings2.loadouts[platform].sprite = ui.blockType5;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(0.7f, 2.78f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[4].ToString();
                    break;
                case 6:
                    UIThings2.loadouts[platform].sprite = ui.blockType6;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(1f, 1f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[5].ToString();
                    break;
                 case 7:
                    UIThings2.loadouts[platform].sprite = ui.blockType7;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(0.7f, 3.4f, 1f);
                    rectTransform.sizeDelta = new Vector2(91.1f, 19.4f);
                    priceText.text = UIThings2.blockTypeInkCost[6].ToString();
                    break;
            }

            //   UIThings2.loadouts[platform].sprite = ui.blockType5;
            isBuying = false;
        }
    }

    public void PerkScreen()
    {
        perkScreen.SetActive(true);
        shopScreen.SetActive(false);
    }

    public void ShopScreen()
    {
        perkScreen.SetActive(false);
        shopScreen.SetActive(true);
    }

    public void DisplayPerkState(GameObject button)
    {
       // perkState = !perkState;

        //button.GetComponent<TextMeshProUGUI>().text = "bop";
    }

    public void StartGame()
    {
        StartCoroutine(nextRound());
    }

    IEnumerator blackFade22()
    {
        yield return new WaitForSeconds(1);
        blackFade.SetActive(false);
    }

    IEnumerator nextRound()
    {
        blackFade.SetActive(true);
        blackFade2.SetBool("fade", true);
        audioFade2.SetBool("fade2", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nextRoundNumber);

    }
}
