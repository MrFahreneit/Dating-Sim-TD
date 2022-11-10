using GSGD1;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemTextThree : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textThreeText;

    private void Update()
    {

        textThreeText.text = LevelReferences.Instance._statsManager.GetItemsThree() + " : ItemsThree";
    }
}
