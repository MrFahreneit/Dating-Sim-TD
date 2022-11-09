using GSGD1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField]
    public GameObject _firstCamera;
    [SerializeField]
    public GameObject _secondCamera;

    [SerializeField]
    public int _waitingTime = 1;


    public enum GamePhase
    {
        FightPhase,
        DatingPhase
    }

    public GamePhase _gamePhase = GamePhase.FightPhase;

    private void Start()
    {
        LevelReferences.Instance.SpawnerManager.WaveStatusChanged -= SpawnerManager_OnWaveStatusChanged;
        LevelReferences.Instance.SpawnerManager.WaveStatusChanged += SpawnerManager_OnWaveStatusChanged;
    }

    private void SpawnerManager_OnWaveStatusChanged(SpawnerManager sender, SpawnerStatus status, int runningWaveCount)
    {
        if(runningWaveCount <= 0)
        {
            StartCoroutine(WaitForXSeconds());
            _gamePhase = GamePhase.DatingPhase;
            _firstCamera.SetActive(false);
            _secondCamera.SetActive(true);
        }
        else
        {
            _gamePhase = GamePhase.FightPhase;
            _firstCamera.SetActive(true);
            _secondCamera.SetActive(false);
        }
    }

    IEnumerator WaitForXSeconds()
    {
        Debug.Log("Started coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(_waitingTime);
        Debug.Log("Finished coroutine at timestamp : " + Time.time);
    }
}
