using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lama : MonoBehaviour
{
    public bool Liked { get; private set; }
    [SerializeField] private LamaReactionAnimator _animator;
    
    private void Init()
    {

    }

    public void ShowEstimation(float isLike, float isNeutral, float isDislike)
    {

       if(isDislike > 0)
        {
            Liked = false;
            _animator.DislikeReact();
        }
       
       else if(isLike > 0)
        {
            Liked = true;
            _animator.LikeReact();
        }else
        {
            Liked = false;
            _animator.NeutralReact();
        }
        
    }
}
