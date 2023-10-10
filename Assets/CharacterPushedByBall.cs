using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPushedByBall : MonoBehaviour
{
    private CharacterController m_CharacterController;
    private Vector3 moveDirection = Vector3.zero;
    public float pushForce = 5.0f;


    [SerializeField]
    private float m_SlowDelay;
    [SerializeField]
    private float m_BallSlowDown;
    [SerializeField]
    private Status m_Status;

    private void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
        
    }



    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Ball"))
        {
            Debug.Log("공이랑 충돌했어");

            m_Status.RunSpeed -= m_BallSlowDown;
            Debug.Log("이속 느려짐 " + m_Status.RunSpeed);

            StartCoroutine(SpeedRestore());

            /*Rigidbody ballRigidbody = hit.collider.attachedRigidbody;
            if (ballRigidbody != null)
            {              
                ballRigidbody.velocity = moveDirection * pushForce;
            }*/
        }
    }

    IEnumerator SpeedRestore()
    {
        yield return new WaitForSeconds(m_SlowDelay);
        m_Status.RunSpeed += m_BallSlowDown;
    }

}
