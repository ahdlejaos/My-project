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
                // Ÿ�̸Ӱ� ����Ǿ��� �� �� �۾��� �߰�
            }

            m_TimerText.text = "�����ð� " + m_CurrentTime.ToString("F2");
        }
    }

    void StartTimer()
    {
        m_CurrentTime = m_TotalTime;
        m_IsTimerRunning = true;
    }

    // Ÿ�̸� ����
    void StopTimer()
    {
        m_IsTimerRunning = false;
    }

}
