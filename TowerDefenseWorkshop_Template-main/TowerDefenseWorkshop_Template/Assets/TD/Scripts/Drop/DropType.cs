using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropType : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _loot;

    private int _lootID;

    [SerializeField]
    private int _lootChance = 70;

    [SerializeField]
    private int _lootPercent;




    private void Start()
    {
        _lootID = UnityEngine.Random.Range(0, 3);

        _lootPercent = UnityEngine.Random.Range(0, 100);
        //IL FAUT LE CODE POUR LE PROCÉDURAL


    }

    private void OnDestroy()
    {
        if (_lootPercent <= _lootChance)
        {
            Instantiate(_loot[_lootID], transform.position, transform.rotation);

        }

    }








}
