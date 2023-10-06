using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator m_Animator;
    private SkinnedMeshRenderer m_MeshRenderer;
    private Color m_OriginColor;

    private void Awake()
    {
        m_Animator = GetComponent<Animator>();
        m_MeshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        m_OriginColor = m_MeshRenderer.material.color;
    }

    public void TakeDamage(int damage)
    {
        Debug.Log(damage + "피해입음");
        m_Animator.SetTrigger("OnHit");
        StartCoroutine("OnHitColor");
    }

    private IEnumerator OnHitColor()
    {
        m_MeshRenderer.material.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        m_MeshRenderer.material.color = m_OriginColor;

    }


}

