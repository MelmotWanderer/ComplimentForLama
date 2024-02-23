using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamaReactionAnimator : MonoBehaviour
{
    [SerializeField] private LamaReaction _likeReaction;
    [SerializeField] private LamaReaction _neutralReaction;
    [SerializeField] private LamaReaction _dislikeReaction;



    public void LikeReact()
    {
        _likeReaction?.React();
    }
    public void NeutralReact() 
    { 
        _neutralReaction?.React();
    }
    public void DislikeReact()
    {
        _dislikeReaction?.React();
    }
} 
