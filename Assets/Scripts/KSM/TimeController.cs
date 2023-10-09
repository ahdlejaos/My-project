using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public float m_TotalTime = 60.0f; 
    private float m_CurrentTime; 
    private bool m_IsTimerRunning = false; 
    public TextMeshProUGUI m_TimerText; 

    void Start()
    {
        m_CurrentTime = m_TotalTime;
        m_IsTimerRunning = true; 
    }

    void Update()
    {
        if (m_IsTimerRunning)
        {
            m_CurrentTime -= Time.deltaTime; 

            
            if (m_CurrentTime <= 0)
            {
                m_CurrentTime = 0;
                m_IsTimerRunning = false;
                // 타이머가 종료되었을 때 할 작업을 추가
            }

            m_TimerText.text = "남은시간 " + m_CurrentTime.ToString("F2");
        }
    }

    void StartTimer()
    {
        m_CurrentTime = m_TotalTime;
        m_IsTimerRunning = true;
    }

    // 타이머 종료
    void StopTimer()
    {
        m_IsTimerRunning = false;
    }

}
