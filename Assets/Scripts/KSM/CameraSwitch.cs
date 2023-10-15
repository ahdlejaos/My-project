using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CameraSwitch : MonoBehaviour
{
    public GameObject m_CharacterCamera;
    public GameObject m_TimelineCamera;
    public PlayableDirector m_Timeline;

    private bool switched = false;

    private void Start()
    {
        m_TimelineCamera.SetActive(true);
        m_CharacterCamera.SetActive(false);
    }

    public void SwitchCamera()
    {
        if (!switched)
        {
            m_TimelineCamera.SetActive(false);
            m_CharacterCamera.SetActive(true);
            switched = true;
        }
    }

    public void OnTimelineEvent()
    {
        SwitchCamera();
    }
}

