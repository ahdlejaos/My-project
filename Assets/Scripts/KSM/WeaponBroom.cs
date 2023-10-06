using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System;

public class WeaponBroom : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField]
    private AudioClip m_AudioClipSwingSound;

    private AudioSource m_AudioSource;

    [Header("Weapon Setting")]
    [SerializeField]
    private WeaponStats m_WeaponStats;

    private float m_LastAttackTime = 0;

    private PlayerAnimatorController m_PlayerAnimatorController;

    [SerializeField]
    private GameObject m_AttackCollision;
    private Animator m_Animator;

    private void Awake()
    {
        m_AudioClipSwingSound = GetComponent<AudioClip>();
        m_PlayerAnimatorController = GetComponentInParent<PlayerAnimatorController>();
    }
   /* private void OnEnable()
    {
        PlaySound(m_AudioClipSwingSound);
    }*/

    private void PlaySound(AudioClip clip)
    {
        m_AudioSource.Stop();
        m_AudioSource.clip = clip;
        m_AudioSource.Play();

    }

    public void StartWeaponAction(int type = 0)
    {
        //¸¶¿ì½º ÁÂÅ¬
        if (type == 0)
        {
            if (m_WeaponStats.m_IsAutomaticAttack == true)
            {
                StartCoroutine("OnAttackLoop");
            }
            else
            {
                OnAttack();
            }
        }
    }
    public void StopWeaponAction(int type =0)
    {
        if(type ==0)
        {
            StopCoroutine("OnAttackLoop");
        }
    }
    private IEnumerator OnAttackLoop()
    {
        while(true)
        {
            OnAttack();

            yield return null;
        }
    }

    private void OnAttack()
    {
        if(Time.time - m_LastAttackTime > m_WeaponStats.m_AttactRate)
        {
            if(m_PlayerAnimatorController.MoveSpeed > 0.5f)
            {
                return;
            }

            m_LastAttackTime = Time.time;

            m_PlayerAnimatorController.Play("swing", -1, 0);
        }
    }

    public void OnAttackCollision()
    {
        m_AttackCollision.SetActive(true);
    }
}

