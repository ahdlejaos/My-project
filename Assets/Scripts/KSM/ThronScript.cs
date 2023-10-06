using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThronScript : MonoBehaviour
{
    [SerializeField]
    private PlayerStats m_PlayerStats;
    [SerializeField]
    private float m_ThronDmg = 50;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�� -" + m_ThronDmg + "������" );
        
        m_PlayerStats.m_CurrentHp -= m_ThronDmg;

        Debug.Log("���� ü�� : " + m_PlayerStats.m_CurrentHp);

    }
}
