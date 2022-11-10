using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    private Text text;
    void Start()

    {
        text = GetComponent<Text>();
    }

 
    void Update()
    {
        string[] temp = text.text.Split("$");
        text.text = temp[0] + "$" + MoneyManager.coins;
    }
}
