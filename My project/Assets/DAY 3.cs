using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class DAY3 : MonoBehaviour
{
    public Text Scoretext;
    public int score = 0;

    int inc = 1;
    public Text Inctext;

    // Start is called before the first frame update
    private void Start()
    {

    }

 // Update is called once per frame
    void Update()
    {

    }
    public void Increase()
    {
        score += inc;
        Scoretext.text = score.ToString();
    }
   public void Shop()
    {
        if(score >= 5)
            {
            score -= 5;
            inc += 1;
            Inctext.text = "increace = " + inc;
            Scoretext.text = score.ToString();

        }
    }

}