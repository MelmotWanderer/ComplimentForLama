using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class WordComplimentUI : MonoBehaviour
{
    [SerializeField] private Text _wordText;
    [SerializeField] private Image _backgroundColor;

    [SerializeField] private Color _colorAdded;
    [SerializeField] private Color _colorNeutral;

    public UnityEvent<string> _addedWord;
    public UnityEvent<string> _deletedWord;
    private bool _added;

    private void Start()
    {
        _added = false;
        Button button = GetComponent<Button>();
        button.onClick.AddListener(AddText);
        _backgroundColor.color = _colorNeutral;


    }

    private void AddText()
    {
        if (!_added)
        {
            _addedWord.Invoke(_wordText.text.ToLower());

            Enable();
        }
        else
        {
          
            _deletedWord.Invoke(_wordText.text.ToLower());
            Disable();
        }

    }
    private void Enable()
    {
        _added = true;
        _backgroundColor.color = _colorAdded;
    }
    private void Disable()
    {
        _added = false;
        _backgroundColor.color = _colorNeutral;
    }

}
