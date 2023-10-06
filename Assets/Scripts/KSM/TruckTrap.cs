using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TruckTrap : MonoBehaviour
{

    public float m_TrapDamage;

    [SerializeField]
    private float m_DelayTime;

    private Animation m_Animation;

    [SerializeField]
    private PlayerStats m_PlayerStats;

    [SerializeField]
    private GameObject m_PlayerObject;


    [SerializeField]
    private Status m_Status;


    void Start()
    {
        m_Animation = GetComponent<Animation>();
        StartCoroutine(Go());

    }

    IEnumerator Go()
    {
        while (true)
        {
            m_Animation.Play();
            yield return new WaitForSeconds(m_DelayTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<MovementCharacterController>().TakeDamage(m_TrapDamage);

            Vector3 hitDirection = (other.transform.position - transform.position).normalized;
            other.GetComponent<MovementCharacterController>().ApplyHitForce(hitDirection);

        }

    }


}

