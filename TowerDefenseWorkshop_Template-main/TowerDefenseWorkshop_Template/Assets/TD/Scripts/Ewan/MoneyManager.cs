using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public const string Coins = "Coins";
    public static int coins = 0;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
    }

    public static void UpdateCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
        coins = PlayerPrefs.GetInt("Coins");
        PlayerPrefs.Save();
    }
}
