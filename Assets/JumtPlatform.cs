using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumtPlatform : MonoBehaviour
{
    public float m_JumpForce = 10.0f;

    public MovementCharacterController m_MovementCharacterController;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("점프트리거발ㄷ동)");
        if (other.CompareTag("Player"))
        {
            CharacterController playerController = other.GetComponent<CharacterController>();
            if (playerController != null)
            {
                m_MovementCharacterController.JumpPad();
            }
        }
    }
}
