using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCutscene : MonoBehaviour
{
    [SerializeField] private Transform _targetOne;
    [SerializeField] private Transform _targetTwo;
    [SerializeField] private PlayerMover _mover;


    public void SetTargetStartScene()
    {
        _mover.SetTarget(_targetOne);


    }
    public void SetTargetEndingScene()
    {
        _mover.SetTarget(_targetTwo);
    }
}
