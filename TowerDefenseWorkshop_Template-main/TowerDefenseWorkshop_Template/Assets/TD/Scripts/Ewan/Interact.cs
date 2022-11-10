using GSGD1;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Interact : MonoBehaviour
{
    private List<Tower> _towerList;

    private Tower _targetTower = null;

    void OnTriggerEnter(Collider other)
    {
        Tower _addedTower = other.GetComponentInParent<Tower>();
        if (_addedTower != null)
        {
            if (_towerList.Contains(_addedTower) == false)
            {
                _towerList.Add(_addedTower);
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        Tower _addedTower = other.GetComponentInParent<Tower>();
        if (_addedTower != null)
        {
            _towerList.Remove(_addedTower);
        }
    }

    private void Update()
    {
        if (_towerList.Count > 0)
        {
            Tower chosenTarget = null;
            float closestDistance = float.MaxValue;
            for (int i = 0; i < _towerList.Count; i++)
            {
                float distance = Vector3.Distance(_towerList[i].transform.position, transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    chosenTarget = _towerList[i];
                }
            }
            _targetTower = chosenTarget;

            
        }
    }
}
