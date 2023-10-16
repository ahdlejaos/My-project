using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    public Transform m_SpawnPostion;
    public TimeController m_TimeController;

    public void MoveCharacterToDestination()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = m_SpawnPostion.position;
        }
    }

    /*void Start()
    {
        Button restartButton = GetComponent<Button>();
        restartButton.onClick.AddListener(RestartScene);
    }

    void RestartScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }*/
}
