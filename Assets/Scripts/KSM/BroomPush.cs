using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BroomPush : MonoBehaviour
{
    [SerializeField]
    private float m_ForceMagnitude;

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;

        if(rigidbody != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rigidbody.AddForceAtPosition(forceDirection * m_ForceMagnitude, transform.position, ForceMode.Impulse);

        }
    }
}

