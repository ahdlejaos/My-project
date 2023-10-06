using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    [SerializeField]
    private float m_RotCamXAxisSpeed = 5;
    [SerializeField]
    private float m_RotCamYAxisSpeed = 3;

    [SerializeField]
    private float m_LimitMinX = -20;
    [SerializeField]
    private float m_LimitMaxX = 10;
    private float m_EulerAngleX;
    private float m_EulerAngleY;

    public void UpdateRotate(float mousex, float mouseY)
    {
        m_EulerAngleY += mousex * m_RotCamYAxisSpeed;
        m_EulerAngleX -= mouseY * m_RotCamXAxisSpeed;

        m_EulerAngleX = ClampAngle(m_EulerAngleX, m_LimitMinX, m_LimitMaxX);
        transform.rotation = Quaternion.Euler(m_EulerAngleX, m_EulerAngleY, 0);
    }
    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }


}

