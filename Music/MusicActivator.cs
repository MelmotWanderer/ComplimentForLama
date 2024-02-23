using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicActivator : MonoBehaviour
{
   [SerializeField] private AudioClip musicClip;
    [SerializeField]private AudioSource musicSource;

    private void Start()
    {
        musicSource.clip  = musicClip;
        musicSource.Play();
    }
}
