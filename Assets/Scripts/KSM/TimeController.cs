using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public float m_TotalTime = 60.0f;
    private float m_CurrentTime;
    private bool m_IsTimerRunning = false;
    public TextMeshProUGUI m_TimerText;
    public Button m_Btn;



    void PauseScene()
    {
        Time.timeScale = 0.0f; // 시간 흐름을 멈춥니다.
    }

    // 씬을 재시작하는 함수
    void RestartScene()
    {
        Time.timeScale = 1.0f; // 시간 흐름을 다시 시작합니다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // 현재 씬을 다시 불러옵니다.
    }


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

                PauseScene();
                m_Btn.gameObject.SetActive(true);
            }

            m_TimerText.text = m_CurrentTime.ToString("F2");
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
