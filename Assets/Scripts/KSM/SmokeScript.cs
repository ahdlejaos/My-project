using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeScript : MonoBehaviour
{

    public PlayerStats m_PlayerStats;

    private CapsuleCollider m_CapsuleCollider;
    private void Start()
    {
        m_CapsuleCollider = GetComponent<CapsuleCollider>();

    }

    [SerializeField]
    private float m_SmokeDmg;
   /* private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("연기닿음 -" + m_SmokeDmg + "데미지");

        m_PlayerStats.m_CurrentHp -= m_SmokeDmg;

        Debug.Log("현재 체력 : " + m_PlayerStats.m_CurrentHp);

    }*/
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("연기닿음 -" + m_SmokeDmg + "데미지");

        m_PlayerStats.m_CurrentHp -= m_SmokeDmg;

        Debug.Log("현재 체력 : " + m_PlayerStats.m_CurrentHp);

    }


}

