using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class CutsceneActivator : MonoBehaviour
{
    [SerializeField] private PlayableDirector _director;
    [SerializeField] private TimelineAsset _firstScene;
    [SerializeField] private TimelineAsset _endingScene;
    [SerializeField] private PlayerCutscene _cutscenePlayer;   
    private void Start()
    {
        StartFirstScene();
    }


    private void StartFirstScene()
    {
        _cutscenePlayer.SetTargetStartScene();
        _director.playableAsset = _firstScene;
        _director.Play();
    }
    
    public void StartEnding()
    {
        _cutscenePlayer.SetTargetEndingScene();
        _director.playableAsset = _endingScene;
        _director.Play();
    }


}
