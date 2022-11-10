using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Give : MonoBehaviour
{

    public void Press()
    {
        MoneyManager.coins += 50;
        MoneyManager.UpdateCoins();

    }

}
