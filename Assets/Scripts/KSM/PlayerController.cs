using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [Header("Input KeyCodes")]
    [SerializeField]
    private KeyCode m_KeyCodeRun = KeyCode.LeftShift;
    [SerializeField]
    private KeyCode m_KeyCodeJump = KeyCode.Space;

    [Header("Audio Clips")]
  /*  [SerializeField]
    private AudioClip m_AudioClipWalk;
    [SerializeField]
    private AudioClip m_AudioClipRun;*/

    private RotateToMouse m_RotateToMouse;
    private MovementCharacterController m_Movement;
    private Status m_Status;
    private PlayerAnimatorController m_Animator;
    private AudioSource m_Audiosource;
    private WeaponBroom m_WeaponBroom;
    private void Awake()
    {
        /* Cursor.visible = false;
         Cursor.lockState = CursorLockMode.Locked;*/

        m_RotateToMouse = GetComponent<RotateToMouse>();
        m_Movement = GetComponent<MovementCharacterController>();
        m_Status = GetComponent<Status>();
        m_Animator = GetComponent<PlayerAnimatorController>();
     //   m_Audiosource = GetComponent<AudioSource>();
        m_WeaponBroom = GetComponentInChildren<WeaponBroom>();

    }
    private void Update()
    {
        UpdateRotate();
        UpdateMove();
        UpdateJump();
        UpdateWeaponAction();
    }

    private void UpdateWeaponAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_WeaponBroom.StartWeaponAction();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            m_WeaponBroom.StopWeaponAction();
        }
    }

    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        m_RotateToMouse.UpdateRotate(mouseX, mouseY);
    }

    private void UpdateMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // ¿Ãµø¡ﬂ ¿œ ∂ß ∞»±‚ ∂Ÿ±‚
        if (x != 0 || z != 0)
        {
            bool isRun = false;

            // ø∑¿Ã≥™ µ⁄∑Œ ¿Ãµø«“∂© ¥ﬁ∏Æ±‚∏¯«‘
            if (z > 0) isRun = Input.GetKey(m_KeyCodeRun);

            m_Movement.MoveSpeed = isRun == true ? m_Status.RunSpeed : m_Status.WalkSpeed;
            m_Animator.MoveSpeed = isRun == true ? 1 : 0.5f;
          /*  m_Audiosource.clip = isRun == true ? m_AudioClipRun : m_AudioClipWalk;

            if (m_Audiosource.isPlaying == false)
            {
                m_Audiosource.loop = true;
                m_Audiosource.Play();
            }*/
        }
        else //¡¶¿⁄∏Æ ∏ÿ√Á¿÷¿ª ∂ß
        {
            m_Movement.MoveSpeed = 0;
            m_Animator.MoveSpeed = 0;

          /*  if (m_Audiosource.isPlaying == true)
            {
                m_Audiosource.Stop();
            }*/
        }
        m_Movement.MoveTo(new Vector3(x, 0, z));
    }

    private void UpdateJump()
    {
        if (Input.GetKeyDown(m_KeyCodeJump))
        {
            m_Movement.Jump();
        }
    }


}

