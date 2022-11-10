using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretStat : MonoBehaviour
{
    private int _currentLevel = 1;

    [SerializeField]
    private float _currentDamage = 3f;

    [SerializeField]
    private float _attackSpeed = 1f;

    [SerializeField]
    private float _currentRange = 5f;


    [SerializeField]
    private float _addDamagePer = 0.5f;

    [SerializeField]
    private float _addAttackSpeed = 1f;

    [SerializeField]
    private float _addRange = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
