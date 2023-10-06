using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class FirstText : MonoBehaviour
{
    [SerializeField]
    private TutorialScript m_TutorialScript;

    private void OnCollisionEnter(Collision collision)
    {
        m_TutorialScript.ActiveOn();
    }

    private void OnCollisionExit(Collision collision)
    {
        m_TutorialScript.ActiveOff();
    }

}

