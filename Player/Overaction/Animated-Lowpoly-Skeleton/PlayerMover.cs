using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
   
    [SerializeField] private float _timeRunning;
    private Transform _currentTarget;


    public void Run()
    {
        StartCoroutine(Running());
    }
    public void SetTarget(Transform target)
    {
        _currentTarget = target;
    }
    private IEnumerator Running()
    {
        float time = 0;
        while(time < _timeRunning)
        {
            transform.position = Vector3.MoveTowards(transform.position, _currentTarget.position, time / _timeRunning);

            time += Time.deltaTime;
            yield return null;


        }
       
    }
}
