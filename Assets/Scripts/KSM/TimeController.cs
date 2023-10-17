using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public float m_TotalTime = 60.0f;
    public float m_CurrentTime;
    private bool m_IsTimerRunning = false;
    public TextMeshProUGUI m_TimerText;
    public Button m_Btn;

    public PlayableDirector m_Timeline;
    private bool m_TimelineFinished = false;

    public void PauseScene()
    {
        Time.timeScale = 0.0f;
    }

    public void ResumeScene()
    {
        Time.timeScale = 1.0f;
        m_IsTimerRunning = true;
    }


    public void RestartScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Start()
    {
        m_CurrentTime = m_TotalTime;
        m_IsTimerRunning = true;
    }

    public void Update()
    {
        if (m_Timeline.state != PlayState.Playing)
        {
            if (!m_TimelineFinished)
            {
                m_TimerText.gameObject.SetActive(true);
                StartTimer();
                m_TimelineFinished = true;
            }

            if (m_IsTimerRunning)
            {
                m_CurrentTime -= Time.deltaTime;


                if (m_CurrentTime <= 0)
                {
                    m_CurrentTime = 0;
                    m_IsTimerRunning = false;

                    PauseScene();
                    m_Btn.gameObject.SetActive(true);
                }

                m_TimerText.text = m_CurrentTime.ToString("F2");
            }
        }

    }
    public void StartTimer()
    {
        m_CurrentTime = m_TotalTime;
        m_IsTimerRunning = true;
    }
    public void StopTimer()
    {
        m_IsTimerRunning = false;
    }

    public void ResumeTimer()
    {
        m_IsTimerRunning = true;
    }



}
