using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WallAttackCollision : MonoBehaviour
{
    public MovementCharacterController m_Movement;

    private void OnEnable()
    {
        StartCoroutine("AutoDisable");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Debug.Log("º®Á¡ÇÁ");
            m_Movement.WallJump();
            //other.GetComponent<Wall>().HitWall();
        }
    }

    private IEnumerator AutoDisable()
    {
        yield return new WaitForSeconds(0.1f);

        gameObject.SetActive(false);
    }
}

