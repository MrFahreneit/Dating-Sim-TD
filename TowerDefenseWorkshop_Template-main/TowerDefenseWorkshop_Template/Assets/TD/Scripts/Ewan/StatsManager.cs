using GSGD1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    [SerializeField]
    private int _coinsCount = 0;

    [SerializeField]
    private int _itemsOneCount = 0;

    [SerializeField]
    private int _itemsTwoCount = 0;

    [SerializeField]
    private int _itemsThreeCount = 0;

    public int GetCoins()
    {
        return _coinsCount;
    }

    public int GetItemsOne()
    {
        return _itemsOneCount;
    }

    public int GetItemsTwo()
    {
        return _itemsTwoCount;
    }

    public int GetItemsThree()
    {
        return _itemsThreeCount;
    }
}
