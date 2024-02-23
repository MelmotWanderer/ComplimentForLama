using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutralReaction : LamaReaction
{
    [SerializeField] private float _angleRotationX;
    [SerializeField] private float _angleRotationY;
    [SerializeField] private float _angleRotationZ;
    [SerializeField] private float _timeThere;
    [SerializeField] private float _timeBack;



    public override void React()
    {
        StopAllCoroutines();
        StartCoroutine(There());
    }


    private IEnumerator There()
    {
        float time = 0f;
        Vector3 newRotation = transform.eulerAngles + new Vector3(_angleRotationX, _angleRotationY, _angleRotationZ);
        while (time < _timeThere)
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, newRotation, time / _timeThere);
            time += Time.deltaTime;
            yield return null;

        }
        transform.eulerAngles = newRotation;
        yield return StartCoroutine(Back());

    }
    private IEnumerator Back()
    {
        float time = 0f;
        Vector3 newRotation = transform.eulerAngles - new Vector3(_angleRotationX, _angleRotationY, _angleRotationZ);
        while (time < _timeBack)
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, newRotation, time / _timeBack);
            time += Time.deltaTime;
            yield return null;

        }
        transform.eulerAngles = newRotation;
    }
}
