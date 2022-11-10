using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GSGD1;

public class EntityManager : MonoBehaviour
{
    [SerializeField]
    private List<WaveEntity> _entities = null;

    public int GetEntitiesCount()
    {
        return _entities.Count;
    }

    public void Register(WaveEntity entity)
    {
        _entities.Add(entity);
    }

    public void Unregister(WaveEntity entity)
    {
        _entities.Remove(entity);
    }
}
