using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuzzy : MonoBehaviour
{

    [SerializeField] private List<Lama> _lamas;
    [SerializeField] private UICompliment _complimentUI;
    [SerializeField] private LamasCheckerReaction _lamasCheckerReaction;

    private void Start()
    {
        _complimentUI._checkCompliment.AddListener(Fuzz);
    }
    public void Fuzz(List<string> compliment)
    {
        var generator = new FuzzySetsGenerator();
        
     

        var neutral = generator.Triangle_FS(20, 30, 80, 60, 1);

        var dislike = generator.Triangle_FS(0, 0, 30, 20, 1);

        var liked = generator.Triangle_FS(70, 90, 100, 100, 1);


        for (int i = 0; i < 5; i++)
        {


            float isLiked = 0;
            float isNeutral = 0;
            float isDislike = 0;


            for (int j = 0; j < compliment.Count; j++)
            {
                var word = compliment[j];

                float wordWeightForLama = LamaData.plentyLamas[i][word];



                isLiked += liked[wordWeightForLama];
                isNeutral += neutral[wordWeightForLama];
                isDislike += dislike[wordWeightForLama];


            }
            _lamas[i].ShowEstimation(isLiked, isNeutral, isDislike);

        }
        _lamasCheckerReaction.CheckLikedComplimentAllLamas(_lamas);
    }

}

