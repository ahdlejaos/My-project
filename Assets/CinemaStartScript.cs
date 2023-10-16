using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CinemaStartScript : MonoBehaviour
{
    public PlayableDirector m_CinematicTimeline;

    private bool m_IsCinematicScenePlayed = false;

    void Start()
    { 
        if(!m_IsCinematicScenePlayed)
        {
            PlayCinematicScene();
            m_IsCinematicScenePlayed = true;
        }
    }

    void PlayCinematicScene()
    {
        m_CinematicTimeline.Play();
    }
}
