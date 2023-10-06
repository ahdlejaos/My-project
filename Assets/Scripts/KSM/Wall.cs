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
        Debug.Log("벽 침 , 한번 더 점프");
        m_Movement.WallJump();
 
    }



}










