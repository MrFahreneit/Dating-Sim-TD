using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DatingMenu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _dialogueText;

    private bool isDialoguePlaying = false;

    private string dialogue_Hello;
    private string dialogue_Ask;
    private string dialogue_Thanks;
    private string dialogue_NoThanks;

    public void DatingStart(string hello, string ask, string thanks, string NoThanks)
    {
        dialogue_Hello = hello;
        dialogue_Ask = ask;
        dialogue_Thanks = thanks;
        dialogue_NoThanks = NoThanks;

        isDialoguePlaying = true;

        gameObject.SetActive(true);

        _dialogueText.text = dialogue_Hello;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }





}
