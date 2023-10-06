using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public float m_CurrentHp;
    public float m_MaxHp;
    public Transform m_SpawnTransform;
    [SerializeField]
    private GameObject m_PlayerObject;


    private void Start()
    {
        m_MaxHp = m_CurrentHp;
    }
    private void Update()
    {
        //Dead();
    }

    public void Dead()
    {
        if (m_CurrentHp <= 0)
        {
            Debug.Log("µÚÁ³´Ù");
            //GameOver();
            //Destroy(m_PlayerObject);
            // Instantiate(m_PlayerObject, m_SpawnTransform);
           // StartCoroutine(Revive());
        }
    }

	public void GetDamage(float damage)
    {
        if (m_CurrentHp > 0)
            m_CurrentHp -= damage;
        Debug.Log(m_CurrentHp);
    }
    private void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }


}

