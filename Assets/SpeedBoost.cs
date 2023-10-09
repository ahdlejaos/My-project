using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float m_BoostAmount = 3.0f; // �̵� �ӵ��� �󸶳� ������ų ������
    private float m_OriginalSpeed; // ���� �̵� �ӵ�
    private bool m_IsBoosting = false; // ���� �ν��� ������ ����
    private float m_BoostDuration = 3.0f; // �ν��� ���� �ð�
    public Status m_Status;

    private void Start()
    {
        // ĳ������ �ʱ� �̵� �ӵ��� ����
      
        m_OriginalSpeed = m_Status.RunSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !m_IsBoosting)
        {
            Debug.Log("�ν���");
            // �ν��� ����
            m_IsBoosting = true;
            m_Status.RunSpeed += m_BoostAmount;

            // ���� �ð��� ���� �� �ν��� ����
            Invoke("StopBoosting", m_BoostDuration);
        }
    }

    private void StopBoosting()
    {
        // �ν��� ���� �� ���� �̵� �ӵ��� ����
        m_Status.RunSpeed = m_OriginalSpeed;
        m_IsBoosting = false;
    }
}
