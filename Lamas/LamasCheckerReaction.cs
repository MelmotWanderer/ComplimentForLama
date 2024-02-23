using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamasCheckerReaction : MonoBehaviour
{
  
    [SerializeField] private CutsceneActivator _cutsceneActivator;



    public void CheckLikedComplimentAllLamas(List<Lama> _lamas)
    {
        int i = 0;
        foreach (var lama in _lamas)
        {
            if (lama.Liked)
            {
                i += 1;
            }
        }
        if (i == _lamas.Count)
        {
            _cutsceneActivator.StartEnding();
        }
    }
}
