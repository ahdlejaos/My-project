using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YourMovementScript : MonoBehaviour
{
    public Rigidbody m_Rb;

    public bool m_Freeze;

    private void Update()
    {
        if(m_Freeze)
        {
            m_Rb.velocity = Vector3.zero;
        }
    }

}

