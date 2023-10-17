using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    // public Transform m_SpawnPostion;
    public TimeController m_TimeController;
    public Transform m_SpawnPostion;
    private Button m_RestartButton;

    /*public void MoveCharacterToDestination()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = m_SpawnPostion.position;
            Debug.Log("캐릭터움직임성공");
        }
        m_RestartButton.gameObject.SetActive(false);
       // m_TimeController.m_CurrentTime = m_TimeController.m_TotalTime;
    }
    */
    void Start()
    {
        m_RestartButton = GetComponent<Button>();
        m_RestartButton.onClick.AddListener(RestartScene);
    }

    void RestartScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

