using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveCamera : MonoBehaviour
{

    public Transform m_CameraPostion;

    // Update is called once per frame
    void Update()
    {
        transform.position = m_CameraPostion.position;
        
    }
}

