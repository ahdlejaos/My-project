using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelIneTimerManager : MonoBehaviour
{
    public PlayableDirector m_Timeline;
    public float m_TimerDuration = 10.0f;

    private float m_Timer;
    private bool m_TimelineFinished = false;

    private void Start()
    {
        m_Timer = m_TimerDuration;
    }

    private void Update()
    {
        if (m_Timeline.state != PlayState.Playing)
        {
            if (!m_TimelineFinished)
            {

                StartTimer();
                m_TimelineFinished = true;
            }


            if (m_Timer > 0)
            {
                m_Timer -= Time.deltaTime;
                if (m_Timer <= 0)
                {

                    TimerFinishedAction();
                }
            }
        }
    }

    private void StartTimer()
    {

        m_Timer = m_TimerDuration;
    }

    private void TimerFinishedAction()
    {
        Debug.Log("타이머가 끝났습니다.");
    }
}
