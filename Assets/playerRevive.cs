using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerRevive : MonoBehaviour
{
    public Transform m_SpawnPoint;
    public int m_Respawn;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("¡¶πﬂπŸ≤∏¡‡");
            SceneManager.LoadScene(m_Respawn);
        }


    }
}
