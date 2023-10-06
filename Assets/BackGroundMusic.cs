using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackGroundMusic : MonoBehaviour
{
    private static BackGroundMusic instance;
    public AudioClip backgroundMusic; // ��� ���� ����
    private AudioSource audioSource;
    public float m_Volume = 0.5f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // AudioSource ������Ʈ ����
        audioSource.clip = backgroundMusic;
        audioSource.loop = true; // �ݺ� ��� ���� (���ϴ� ���)
        audioSource.volume = m_Volume; // ���� ���� (0.0���� 1.0 ����, ���ϴ´�� ����)
        audioSource.Play(); // ��� ���� ���
    }

    void Awake()
    {
        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {

            Destroy(gameObject);
        }
    }


    // ���� �ε�� ������ ȣ��Ǵ� �̺�Ʈ
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // ���� ��ε�� ������ ȣ��Ǵ� �̺�Ʈ
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // ���� �ε�� �� ȣ��Ǵ� �޼���
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        GetComponent<AudioSource>().volume = m_Volume;
    }



}


