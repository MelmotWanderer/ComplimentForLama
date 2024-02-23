using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LikeReaction : LamaReaction
{
    [SerializeField] private float _heightJump;
    [SerializeField] private float _timeJump;
    [SerializeField] private float _timeDown;



    public override void React()
    {
        StopAllCoroutines();
        StartCoroutine(Up());
    }


    private IEnumerator Up()
    {
        float time = 0f;
        Vector3 newPostion = transform.position + new Vector3(0, _heightJump, 0);
        while(time < _timeJump)
        {
            transform.position = Vector3.Lerp(transform.position, newPostion, time / _timeJump);
            time += Time.deltaTime;
            yield return null;

        }
        transform.position = newPostion;
        yield return StartCoroutine(Down());
        
    }
    private IEnumerator Down()
    {
        float time = 0f;
        Vector3 newPostion = transform.position - new Vector3(0, _heightJump, 0);
        while (time < _timeDown)
        {
            transform.position = Vector3.Lerp(transform.position, newPostion, time / _timeDown);
            time += Time.deltaTime;
            yield return null;

        }
        transform.position = newPostion;
    }
    
}
