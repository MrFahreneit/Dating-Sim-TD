using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    [SerializeField]
    private string _Scene;


    public void StartGame()
    {
        SceneManager.LoadScene(_Scene);
    }










}
