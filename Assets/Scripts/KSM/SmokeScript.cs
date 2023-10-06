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
        
        Debug.Log("������� -" + m_SmokeDmg + "������");

        m_PlayerStats.m_CurrentHp -= m_SmokeDmg;

        Debug.Log("���� ü�� : " + m_PlayerStats.m_CurrentHp);

    }*/
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("������� -" + m_SmokeDmg + "������");

        m_PlayerStats.m_CurrentHp -= m_SmokeDmg;

        Debug.Log("���� ü�� : " + m_PlayerStats.m_CurrentHp);

    }


}

