using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public float m_DestroyDelay = 5f;

    private void Start()
    {
        Destroy(gameObject, m_DestroyDelay);
    }



}
