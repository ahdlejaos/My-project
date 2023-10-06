using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float m_InitialSpeedX = 5f;
    public float m_InitialSpeedY = 5f;
    public float m_InitialSpeedZ = 5f;

    private Rigidbody m_Rigidbody;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        Vector3 initialVelocity = new Vector3(m_InitialSpeedX, m_InitialSpeedY, m_InitialSpeedZ);
        m_Rigidbody.velocity = initialVelocity;

        
    }

}
