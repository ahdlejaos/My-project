using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingBall : MonoBehaviour
{
    private Transform m_TargetTransform;
    public float m_PullingForce = 10.0f;
    public float m_RepeatInterval = 3.0f;
    [SerializeField]
    public GameObject m_Target;
  
    private Rigidbody m_Rb;

    private void Start()
    {
        m_TargetTransform = m_Target.transform;
        m_Rb = GetComponent<Rigidbody>();
        InvokeRepeating("ApplyPullingForce", 0.0f, m_RepeatInterval);
    }

    private void ApplyPullingForce()
    {
        Debug.Log("²ø¾îµéÀÓ");
        Vector3 forceDirection = (m_TargetTransform.position - transform.position).normalized;       
        m_Rb.AddForce(forceDirection * m_PullingForce);
    }
}
