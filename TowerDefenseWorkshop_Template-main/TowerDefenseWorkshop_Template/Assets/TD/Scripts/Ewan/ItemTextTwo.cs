using GSGD1;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemTextTwo : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textTwoText;

    private void Update()
    {

        textTwoText.text = LevelReferences.Instance._statsManager.GetItemsTwo() + " : ItemsTwo";
    }
}
