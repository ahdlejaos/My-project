using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndBox : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("∞‘¿” ≥°");
        GameOver();
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameEndScene");   
    }



}
