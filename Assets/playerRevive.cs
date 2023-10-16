using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerRevive : MonoBehaviour
{
    public Transform m_SpawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CharacterController characterController = other.GetComponent<CharacterController>();
            if (characterController != null)
            {
                Debug.Log("∫Œ»∞");
                characterController.enabled = false;
                other.transform.position = m_SpawnPoint.position;
                characterController.enabled = true; 
            }

            Debug.Log("¡¶πﬂπŸ≤∏¡‡");
            //SceneManager.LoadScene(m_Respawn);
        }


    }
}
