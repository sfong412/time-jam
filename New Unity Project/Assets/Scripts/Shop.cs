using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Shop : MonoBehaviour
{
    public GameObject blackFade;

    public GameObject shopScreen;
    public GameObject perkScreen;

    public GameObject secret;
    public Animator blackFade2;

    public Animator audioFade2;

    public Animator perkScreen2;

    public int nextRoundNumber;
    UIThings2 ui;

    UIThings3 uiThings3;

    bool isBuying = false;

    int blockType;

    int currentBlockType;

    int currentPerkType;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.Find("Selectors").GetComponent<UIThings2>();

        if (UIThings2.blockTypeLoadout == null)
        {
            UIThings2.blockTypeLoadout = new int[5] { 1, 2, 3, 4, 5};
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C) && Input.GetKey(KeyCode.D))
        {
            StartCoroutine(secret1());
        }
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

    public void SelectPerk(int perkType)
    {
        isBuying = true;
        currentPerkType = perkType;
        
        switch (currentPerkType)
        {
            case 0:
                PerkSystem.inkRegenUpPerk = !PerkSystem.inkRegenUpPerk;
                Debug.Log("inkRegenUpPerk: " + PerkSystem.inkRegenUpPerk);
                break;
            case 1: 
                PerkSystem.eraserUseUpPerk = !PerkSystem.eraserUseUpPerk;
                Debug.Log("eraserUseUpPerk: " + PerkSystem.eraserUseUpPerk);
                break;
            case 2:
                PerkSystem.focusCapacityUpPerk = !PerkSystem.focusCapacityUpPerk;
                Debug.Log("focusCapacityUpPerk: " + PerkSystem.focusCapacityUpPerk);
                break;
        }
       // Debug.Log(PerkSystem.inkRegenUpPerk);
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
                    UIThings2.loadouts[platform].color = Color.white;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(0.9f, 0.7f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[0].ToString();
                    break;
                case 2:
                    UIThings2.loadouts[platform].sprite = ui.blockType2;
                    UIThings2.loadouts[platform].color = Color.white;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(-0.8f, 0.7f, 1f);
                    rectTransform.sizeDelta = new Vector2(36.7f, 153.3f);
                    priceText.text = UIThings2.blockTypeInkCost[1].ToString();
                    break;
                case 3:
                    UIThings2.loadouts[platform].sprite = ui.blockType3;
                    UIThings2.loadouts[platform].color = Color.white;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 180);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(-0.7f, -2.78f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[2].ToString();
                    break;
                case 4:
                    UIThings2.loadouts[platform].sprite = ui.blockType4;
                    UIThings2.loadouts[platform].color = Color.white;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 90);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(-0.7f, 2.78f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[3].ToString();
                    break;
                case 5:
                    UIThings2.loadouts[platform].sprite = ui.blockType5;
                    UIThings2.loadouts[platform].color = Color.white;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(0.7f, 2.78f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[4].ToString();
                    break;
                case 6:
                    UIThings2.loadouts[platform].sprite = ui.blockType6;
                    UIThings2.loadouts[platform].color = Color.white;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(1f, 1f, 1f);
                    rectTransform.sizeDelta = new Vector2(154.8f, 39.8f);
                    priceText.text = UIThings2.blockTypeInkCost[5].ToString();
                    break;
                case 7:
                    UIThings2.loadouts[platform].sprite = ui.blockType7;
                    UIThings2.loadouts[platform].color = Color.white;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(0.7f, 3.4f, 1f);
                    rectTransform.sizeDelta = new Vector2(91.1f, 19.4f);
                    priceText.text = UIThings2.blockTypeInkCost[6].ToString();
                    break;

                case 8:
                    UIThings2.loadouts[platform].sprite = ui.blockType8;
                    UIThings2.loadouts[platform].color = new Color(0f, 164.7f, 255f);
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(0.7f, 3.4f, 1f);
                    rectTransform.sizeDelta = new Vector2(91.1f, 19.4f);
                    priceText.text = UIThings2.blockTypeInkCost[7].ToString();
                    break;
                case 9:
                    UIThings2.loadouts[platform].sprite = ui.blockType9;
                    UIThings2.loadouts[platform].color =  Color.white;
                    UIThings2.loadouts[platform].transform.localRotation = Quaternion.Euler(0, 0, 0);
                    UIThings2.loadouts[platform].transform.localScale = new Vector3(0.7f, 3.4f, 1f);
                    rectTransform.sizeDelta = new Vector2(91.1f, 19.4f);
                    priceText.text = UIThings2.blockTypeInkCost[8].ToString();
                    break;
            }

            //   UIThings2.loadouts[platform].sprite = ui.blockType5;
            isBuying = false;
        }
    }

    public void PlacePerk()
    {
        if (isBuying == true)
        {

        }
    }


    public void PerkScreen()
    {
        isBuying = false;
        perkScreen2.SetBool("move", true);
    }

    public void ShopScreen()
    {
        isBuying = false;
        perkScreen2.SetBool("move", false);
    }

    public void DisplayPerkState(GameObject button)
    {
       // perkState = !perkState;

        button.GetComponentInChildren<Text>().text = "Ink Regen Up Perk: " + PerkSystem.inkRegenUpPerk.ToString();
    }

    public void ChangePerkState()
    {
        PerkSystem.inkRegenUpPerk = !PerkSystem.inkRegenUpPerk;
    }

    public void StartGame()
    {
        isBuying = false;
        StartCoroutine(nextRound());
    }

    public void StartGameTest()
    {
        SceneManager.LoadScene("Round 2");
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

    IEnumerator secret1()
    {
        secret.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(8);

    }
}
