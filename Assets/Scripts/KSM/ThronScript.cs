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
        Debug.Log("찔림 -" + m_ThronDmg + "데미지" );
        
        m_PlayerStats.m_CurrentHp -= m_ThronDmg;

        Debug.Log("현재 체력 : " + m_PlayerStats.m_CurrentHp);

    }
}
