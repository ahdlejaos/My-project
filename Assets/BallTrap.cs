using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallTrap : MonoBehaviour
{

    public float m_TrapDamage;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("공맞음");
            other.GetComponent<MovementCharacterController>().TakeDamage(m_TrapDamage);

            Vector3 hitDirection = (other.transform.position - transform.position).normalized;
            other.GetComponent<MovementCharacterController>().ApplyHitForce(hitDirection);

        }

    }

    /*  public void OnControllerColliderHit(ControllerColliderHit hit)
      {
          if(hit.gameObject.CompareTag("Player"))
          {
              Debug.Log("공맞음");
              Vector3 hitDircetion = hit.moveDirection;
              Vector3 pushDirection = new Vector3(hitDircetion.x, m_HitDirectionY, hitDircetion.z).normalized;
              m_CharacterController.Move(pushDirection * m_Hitforce * Time.deltaTime);
          }
      }*/






}

