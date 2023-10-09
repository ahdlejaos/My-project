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
        Time.timeScale = 0.0f; // �ð� �帧�� ����ϴ�.
    }

    // ���� ������ϴ� �Լ�
    void RestartScene()
    {
        Time.timeScale = 1.0f; // �ð� �帧�� �ٽ� �����մϴ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // ���� ���� �ٽ� �ҷ��ɴϴ�.
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

    // Ÿ�̸� ����
    void StopTimer()
    {
        m_IsTimerRunning = false;
    }

}
