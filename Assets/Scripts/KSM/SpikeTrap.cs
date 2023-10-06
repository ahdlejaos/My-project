using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpikeTrap : MonoBehaviour
{
    [SerializeField]
    private float m_TrapDamage;


    [SerializeField]
    private float m_DelayTime;

    private Animation m_Animation;

    [SerializeField]
    private PlayerStats m_PlayerStats;

    [SerializeField]
    private GameObject m_PlayerObject;
    [SerializeField]
    private Transform m_SpawnPoint;

    [SerializeField]
    private Status m_Status;
    [SerializeField]
    private float m_SpikeSlowDown;
    [SerializeField]
    private float m_SlowDelay;

    void Start()
    {
        m_Animation = GetComponent<Animation>();
        StartCoroutine(Go());

    }

    IEnumerator Go()
    {
        while (true)
        {
            m_Animation.Play();
            yield return new WaitForSeconds(m_DelayTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        m_PlayerStats.GetDamage(m_TrapDamage);
        Debug.Log("플레이어 데미지" + m_TrapDamage + " 입음 ");

        if (m_PlayerStats.m_CurrentHp <= 0)
        {
            m_Status.RunSpeed -= m_SpikeSlowDown;
            Debug.Log("이속 느려짐 " + m_Status.RunSpeed);

            StartCoroutine(SpeedRestore());
            
        }

    }
    IEnumerator SpeedRestore()
    {
        yield return new WaitForSeconds(m_SlowDelay);
        m_Status.RunSpeed += m_SpikeSlowDown;
    }
    IEnumerator bounce()
    {
        yield return new WaitForSeconds(3f);
       

    }

}

