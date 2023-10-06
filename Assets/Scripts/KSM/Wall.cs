using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField]
    private MovementCharacterController m_Movement;

    private void Awake()
    {
       m_Movement = GetComponent<MovementCharacterController>();
    }
    public void HitWall()
    {
        Debug.Log("�� ħ , �ѹ� �� ����");
        m_Movement.WallJump();
 
    }



}










