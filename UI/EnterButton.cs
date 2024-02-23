using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class EnterButton : MonoBehaviour
{

    public UnityEvent _checkedCompliment;
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(StartCheck);
    }



    private void StartCheck()
    {
        _checkedCompliment.Invoke();
    } 
}
