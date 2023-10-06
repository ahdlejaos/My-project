using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class FadeEffect : MonoBehaviour
{
    [SerializeField]
    private float m_FadeTime = 0.5f;
    private TextMeshProUGUI m_FadeText;

    private void Awake()
    {
        m_FadeText = GetComponent<TextMeshProUGUI>();
    }
    private void OnEnable()
    {
        StartCoroutine("FadeLoop");    
    }

    private IEnumerator FadeLoop()
    {
        while ( true )
        {
            yield return StartCoroutine(Fade(1, 0));

            yield return StartCoroutine(Fade(0, 1));
        }
    }
    
    private IEnumerator Fade(float start,float end)
    {
        float current = 0;
        float percent = 0;

        while ( percent < 1)
        {
            current += Time.deltaTime;
            percent = current / m_FadeTime;

            Color color = m_FadeText.color;
            color.a = Mathf.Lerp(start, end, percent);
            m_FadeText.color = color;

            yield return null;
        }
    }



}

