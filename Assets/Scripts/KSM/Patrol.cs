using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public GameObject m_PatrolObject;
    public float X;
    public float Y;
    public float Z;

    private void Update()
    {
        m_PatrolObject.transform.position = new Vector3(X, Y, Z * Mathf.PingPong(Time.time, 3.0f));
    }


}

