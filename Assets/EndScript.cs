using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
    public TextMeshProUGUI m_Text;

    public TimeController m_TimeController;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("텍스트떠야함");
        if (other.CompareTag("Player"))
        {
            m_Text.gameObject.SetActive(true);
            m_TimeController.StopTimer();
        }
    }

   /* private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            m_Text.gameObject.SetActive(false);
        }

    }*/
}