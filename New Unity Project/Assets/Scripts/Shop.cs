using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class Shop : MonoBehaviour
{
    public int coinAmount = 2000;

    TextMeshProUGUI coinCounter;

    // Start is called before the first frame update
    void Start()
    {
        coinCounter = GameObject.Find("Coin Amount").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        coinCounter.text = "Coins: " + coinAmount.ToString();
    }

    public void BuyItem()
    {
        coinAmount = coinAmount - 500;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
