using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class TextWriter : MonoBehaviour
{
 
    [SerializeField] private float _timeWrite;
    [SerializeField] private GameObject _uiWriter;
    [SerializeField] private Text _text;
    [SerializeField] private List<Remark> _remarks;
    
    private void Start()
    {
        _text.text = string.Empty;
        _uiWriter.SetActive(false);
    }
    public void Wrtie()
    {
        _uiWriter.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(Writed());
    }


    private IEnumerator Writed()
    {


        foreach (Remark remark in _remarks)
        {
            foreach (char item in remark.Text)
            {
                _text.text += item;
                yield return new WaitForSeconds(_timeWrite);
            }
            yield return new WaitForSeconds(3f);
            _text.text  = string.Empty;
        }

        _uiWriter.SetActive(false);
    }
}
