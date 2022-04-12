using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineLauncher : MonoBehaviour
{
    private PlayableDirector timeline;
    private void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            timeline.Play();
        }
    }
}
