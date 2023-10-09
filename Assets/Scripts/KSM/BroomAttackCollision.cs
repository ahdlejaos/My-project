using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BroomAttackCollision : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine("AutoDisable");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            
        }
    }

    private IEnumerator AutoDisable()
    {
        yield return new WaitForSeconds(0.1f);

        gameObject.SetActive(false);
    }
}
