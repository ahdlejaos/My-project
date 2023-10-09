using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float m_BoostAmount = 3.0f; // 이동 속도를 얼마나 증가시킬 것인지
    private float m_OriginalSpeed; // 원래 이동 속도
    private bool m_IsBoosting = false; // 현재 부스팅 중인지 여부
    private float m_BoostDuration = 3.0f; // 부스팅 지속 시간
    public Status m_Status;

    private void Start()
    {
        // 캐릭터의 초기 이동 속도를 저장
      
        m_OriginalSpeed = m_Status.RunSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !m_IsBoosting)
        {
            Debug.Log("부스팅");
            // 부스팅 시작
            m_IsBoosting = true;
            m_Status.RunSpeed += m_BoostAmount;

            // 일정 시간이 지난 후 부스팅 종료
            Invoke("StopBoosting", m_BoostDuration);
        }
    }

    private void StopBoosting()
    {
        // 부스팅 종료 후 원래 이동 속도로 복귀
        m_Status.RunSpeed = m_OriginalSpeed;
        m_IsBoosting = false;
    }
}
