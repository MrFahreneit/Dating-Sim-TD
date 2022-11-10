using GSGD1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCountManager : MonoBehaviour
{
    [SerializeField]
    private int _entityCount = 0;

    private bool isDatingSimMode = false;

    public int GetEntityCount()
    {
        return _entityCount;
    }

    private void Update()
    {
        _entityCount = LevelReferences.Instance.entityManager.GetEntitiesCount();
    }

    public void PassIntoDatingSimulatorMode()
    {
        if (_entityCount == 0 && LevelReferences.Instance.SpawnerManager.CurrentWaveRunning <= 0 && !isDatingSimMode)
        {
            isDatingSimMode = true;
            //Ici, il ny a plus de spawners qui spawnent, et il ny a plus d'ennemis
        }
    }
}
