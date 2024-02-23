using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
public class UICompliment : MonoBehaviour
{
    public UnityEvent<List<string>> _checkCompliment;
    [SerializeField] private List<WordComplimentUI> _wordsCompliment;
    [SerializeField] private EnterButton _enterButton;
    
    private List<string> _textCompliment;
    

    private void Start()
    {
        _textCompliment = new List<string>();
        _enterButton._checkedCompliment.AddListener(CheckLamaReaction);

        foreach (WordComplimentUI item in _wordsCompliment)
        {
            item._addedWord.AddListener(AddWord);
            item._deletedWord.AddListener(DeleteWord);
        }
  
    }
    private void CheckLamaReaction()
    {
        _checkCompliment.Invoke(_textCompliment);
    }
    private void AddWord(string word)
    {
        _textCompliment.Add(word);
        ShowWords();
    }
    private void DeleteWord(string word)
    {
        _textCompliment.Remove(word);
        ShowWords();
       
    }
    private void ShowWords()
    {
        string s = "";
        foreach (var item in _textCompliment)
        {
            s += item + " ";
        }
        Debug.Log(s);
    }

}
