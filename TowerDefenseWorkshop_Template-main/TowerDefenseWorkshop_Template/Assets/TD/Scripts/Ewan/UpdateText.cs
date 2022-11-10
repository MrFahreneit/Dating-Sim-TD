using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using GSGD1;

public class UpdateText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI coinsText;

    private void Update()
    {
        coinsText.text = LevelReferences.Instance._statsManager.GetCoins() + " : Coins";
    }
}
