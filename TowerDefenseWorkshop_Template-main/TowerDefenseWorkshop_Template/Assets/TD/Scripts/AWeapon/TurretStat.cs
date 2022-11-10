using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GSGD1;

public class TurretStat : MonoBehaviour
{

    [SerializeField]
    private WeaponController _currentWeaponController = null;
    [SerializeField]
    private SphereCollider _rangeSphere = null;

    private int _currentLevel = 1;

    [SerializeField]
    private int _maxLevel = 5;

    [SerializeField]
    private float _currentDamage = 3f;

    [SerializeField]
    private float _attackSpeed = 1f;

    [SerializeField]
    private float _currentRange = 5f;


    [SerializeField]
    private float _addDamagePer = 0.5f;

    [SerializeField]
    private float _ReduceAttackSpeed = 0.2f;

    [SerializeField]
    private float _addRange = 1f;

    public void LevelUp()
    {

        if(_currentDamage >= _maxLevel)
        {

        }

        else if (_currentDamage == _maxLevel - 1)
        {

        }
        else
        {
            _currentDamage = _currentDamage + _addDamagePer;
            _attackSpeed = _attackSpeed - _ReduceAttackSpeed;
            _attackSpeed = Mathf.Clamp(_attackSpeed, 0.1f, 999f);
            _currentRange = _currentRange + _addRange;

            _currentLevel++;
        }

    }

    private void UpdateStats()
    {

        AWeapon _currentWeaponScript = _currentWeaponController.GetWeapon();
        _currentWeaponScript.SetTimerNewTimer(_attackSpeed);
        _rangeSphere.radius = _currentRange;
    }

}
