using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GSGD1;

public class DialogueTurret : MonoBehaviour
{
    [SerializeField]
    private List<string> dialogue_Hello;

    [SerializeField]
    private List<string> dialogue_Ask;

    [SerializeField]
    private List<string> dialogue_Thanks;

    [SerializeField]
    private List<string> dialogue_NoThanks;


    public void StartDialogue()
    {

        DatingMenu _currentDatingMenu = LevelReferences.Instance._datingMenu;
        _currentDatingMenu.DatingStart
            (
            dialogue_Hello[Random.Range(0, dialogue_Hello.Count)],
            dialogue_Ask[Random.Range(0, dialogue_Ask.Count)],
            dialogue_Thanks[Random.Range(0, dialogue_Thanks.Count)],
            dialogue_NoThanks[Random.Range(0, dialogue_NoThanks.Count)]
            );

    }
}
