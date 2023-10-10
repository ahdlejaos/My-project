using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnSnowball : MonoBehaviour
{
    public GameObject m_ObjectToSpawnPrefab;

    public float m_SpawnInteral = 3f;

    private float m_Timer = 0f;
    
   

    private void Update()
    {
        m_Timer += Time.deltaTime;

        if(m_Timer >= m_SpawnInteral)
        {
            SpawnObject();
            m_Timer = 0f;
        }
    }

    public void SpawnObject()
    {
        Instantiate(m_ObjectToSpawnPrefab, transform.position, Quaternion.identity);
    }

}
