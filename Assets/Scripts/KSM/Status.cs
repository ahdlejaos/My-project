using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    [Header("Walk, Run Speed")]
    [SerializeField]
    private float m_WalkSpeed;
    [SerializeField]
    private float m_RunSpeed;
    

    public float WalkSpeed => m_WalkSpeed;

    public float RunSpeed { get => m_RunSpeed; set => m_RunSpeed = value; }
}

