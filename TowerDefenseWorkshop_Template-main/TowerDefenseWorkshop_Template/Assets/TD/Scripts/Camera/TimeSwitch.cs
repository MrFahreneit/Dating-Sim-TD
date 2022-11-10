using GSGD1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSwitch : MonoBehaviour
{
    [SerializeField]
    public GameObject _firstCamera;
    [SerializeField]
    public GameObject _secondCamera;

    [SerializeField]
    public GameObject _player;

    [SerializeField]
    public Daycycle _dayCycle;

    private int _entitiesNumber;

    private bool _shouldCheckForLastingEnemies = false;

    public enum GamePhase
    {
        FightPhase,
        DatingPhase
    }

    public GamePhase _gamePhase = GamePhase.FightPhase;

    private void Awake()
    {

    }

    private void Start()
    {
        _entitiesNumber = LevelReferences.Instance.enemyCountManager.GetEntityCount();
        //PassIntoDatingSimulatorMode();
        ChangeGamePhase(GamePhase.DatingPhase);
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    //private void CameraSwitching()
    //{
    //    if(_entitiesNumber <= 0)
    //    {
    //        _gamePhase = GamePhase.DatingPhase;
    //        _firstCamera.SetActive(false);
    //        _secondCamera.SetActive(true);
    //    }
    //    if(_entitiesNumber >= 1)
    //    {
    //        _gamePhase = GamePhase.FightPhase;
    //        _firstCamera.SetActive(true);
    //        _secondCamera.SetActive(false);
    //    }
    //}

    public void PassIntoDatingSimulatorMode()
    {
        Debug.Log("_entitiesNumber : " + (_entitiesNumber == 0));
        Debug.Log("CurrentWaveRunning " + (LevelReferences.Instance.SpawnerManager.CurrentWaveRunning <= 0));

        if (_entitiesNumber == 0 && LevelReferences.Instance.SpawnerManager.CurrentWaveRunning <= 0 && _gamePhase != GamePhase.DatingPhase)
        {
            //Ici, il ny a plus de spawners qui spawnent, et il ny a plus d'ennemis
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

    public void ChangeGamePhase(GamePhase gamePhase)
    {
        switch (gamePhase)
        {
            case GamePhase.FightPhase:
                {
                    _gamePhase = GamePhase.FightPhase;
                    _dayCycle.CycleStateEnum = Daycycle.CycleState.Night;
                }
                break;
            case GamePhase.DatingPhase:
                {
                    _gamePhase = GamePhase.DatingPhase;
                    _dayCycle.CycleStateEnum = Daycycle.CycleState.Day;
                }
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        if (_shouldCheckForLastingEnemies == true)
        {
            
        }
    }

    private void SpawnerManager_OnWaveStatusChanged(SpawnerManager sender, SpawnerStatus status, int runningWaveCount)
    {
        switch (status)
        {
            case SpawnerStatus.Inactive:
                _shouldCheckForLastingEnemies = true;
                break;
            case SpawnerStatus.WaveRunning:
                ChangeGamePhase(GamePhase.FightPhase);
                break;
            default:
                break;
        }
    }
}
