using GSGD1;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemTextOne : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textOneText;

    private void Update()
    {

        textOneText.text = LevelReferences.Instance._statsManager.GetItemsOne() + " : ItemsOne";
    }
}
