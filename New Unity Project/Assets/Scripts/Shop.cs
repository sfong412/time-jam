using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class Shop : MonoBehaviour
{
    public int coinAmount;

    public GameObject blackFade;

    TextMeshProUGUI coinCounter;

    // Start is called before the first frame update
    void Start()
    {
        coinAmount = 1500;
        coinCounter = GameObject.Find("Coin Amount").GetComponent<TextMeshProUGUI>();

        UIThings2.blockTypeLoadout = new int[5] { 1, 2, 3, 4, 5 };
    }

    // Update is called once per frame
    void Update()
    {
        coinCounter.text = "Coins: " + coinAmount.ToString();

        Debug.Log(UIThings2.blockTypeLoadout[1]);
    }
    
    void Awake()
    {
        StartCoroutine(blackFade22());
    }

    public void BuyItem(int itemCost)
    {
        if (coinAmount >= itemCost)
        {
            coinAmount = coinAmount - itemCost;
            UIThings2.blockTypeLoadout[1] = 5;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }

    IEnumerator blackFade22()
    {
        yield return new WaitForSeconds(1);
        blackFade.SetActive(false);
    }
}
