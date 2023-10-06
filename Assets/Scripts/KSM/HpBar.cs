using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HpBar : MonoBehaviour
{
    [SerializeField]
    private Slider m_HpBar;

    [SerializeField]
    private PlayerStats m_PlayerStats;

    // Start is called before the first frame update
    void Start()
    {
        m_HpBar.value =  m_PlayerStats.m_CurrentHp / m_PlayerStats.m_MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_PlayerStats.m_CurrentHp < m_PlayerStats.m_MaxHp)
        {
            HandleHp();
        }

    }

    public void HandleHp()
    {
        m_HpBar.value = Mathf.Lerp(m_HpBar.value  ,m_PlayerStats.m_CurrentHp / m_PlayerStats.m_MaxHp, Time.deltaTime * 10);
    }

}
