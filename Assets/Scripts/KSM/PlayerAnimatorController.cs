using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator m_Animator;
    private void Awake()
    {
        m_Animator = GetComponentInChildren<Animator>();
    }

    public float MoveSpeed
    {
        set => m_Animator.SetFloat("MovementSpeed", value);
        get => m_Animator.GetFloat("MovementSpeed");
    }

    public void Play(string stateName, int layer, float normalizedTime)
    {
        m_Animator.Play(stateName, layer, normalizedTime);
    }

}

