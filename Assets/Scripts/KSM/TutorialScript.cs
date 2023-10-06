using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI m_TextMesh;


    public void ActiveOn()
    {
        gameObject.SetActive(true);
    }

    public void ActiveOff()
    {
        gameObject.SetActive(false);
    }


}

