using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveSmoke : MonoBehaviour
{
    [SerializeField]
    private float m_SmokeSpeed;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * m_SmokeSpeed, Space.World);
    }

}
