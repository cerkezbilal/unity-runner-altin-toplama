using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static bool isGameStarted;
    public static int numberOfCoins;
    public Text coinsText;

    public Text startingText;

    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberOfCoins = 0;
        coinsText.text = "Score: "+numberOfCoins.ToString();
    }

    
    void Update()
    {
        coinsText.text = "Score: " + numberOfCoins.ToString();

        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        if (SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(startingText);
        }
    }
}
