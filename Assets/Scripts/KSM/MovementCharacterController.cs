using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementCharacterController : MonoBehaviour
{

    [SerializeField]
    private float m_MoveSpeed;

    public float m_HitForce;

    private Vector3 m_MoveForce;
    private Vector3 m_MoveDirection = Vector3.zero;

    [SerializeField]
    private bool m_IsGrounded;

    [SerializeField]
    private float m_JumpForce;
    [SerializeField]
    private float m_Gravity;

    private CharacterController m_CharacterController;

    [SerializeField]
    private PlayerStats m_PlayerStats;

    [SerializeField]
    private ElectricTrap m_ElectricTrap;



    public float MoveSpeed
    {
        set => m_MoveSpeed = Mathf.Max(0, value);
        get => m_MoveSpeed;
    }

    private void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();

    }

    private void Update()
    {


        if (!m_CharacterController.isGrounded)
        {
            m_MoveForce.y += m_Gravity * Time.deltaTime;
        }
        m_CharacterController.Move(m_MoveForce * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 hitDirection = -transform.forward;
            m_MoveDirection = hitDirection * m_HitForce;
        }

    }

    public void MoveTo(Vector3 direction)
    {


        direction = transform.rotation * new Vector3(direction.x, 0, direction.z);

        m_MoveForce = new Vector3(direction.x * m_MoveSpeed, m_MoveForce.y, direction.z * m_MoveSpeed);
    }

    public void Jump()
    {
        if (m_CharacterController.isGrounded)
        {
            m_MoveForce.y = m_JumpForce;
        }
    }

    public void WallJump()
    {
        m_MoveForce.y = m_JumpForce;
    }


    public void TakeDamage(float damage)
    {
        //데미지 처리 코드 작성

        m_PlayerStats.GetDamage(m_ElectricTrap.m_TrapDamage);
        Debug.Log("플레이어 데미지" + m_ElectricTrap.m_TrapDamage + " 입음 ");
    }

    public void ApplyHitForce(Vector3 hitDirection)
    {
        m_MoveDirection = hitDirection * m_HitForce;
        

    }


}

