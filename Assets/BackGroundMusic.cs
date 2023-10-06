using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackGroundMusic : MonoBehaviour
{
    private static BackGroundMusic instance;
    public AudioClip backgroundMusic; // 배경 음악 파일
    private AudioSource audioSource;
    public float m_Volume = 0.5f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // AudioSource 컴포넌트 설정
        audioSource.clip = backgroundMusic;
        audioSource.loop = true; // 반복 재생 설정 (원하는 경우)
        audioSource.volume = m_Volume; // 음량 설정 (0.0에서 1.0 사이, 원하는대로 조절)
        audioSource.Play(); // 배경 음악 재생
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


    // 씬이 로드될 때마다 호출되는 이벤트
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // 씬이 언로드될 때마다 호출되는 이벤트
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // 씬이 로드될 때 호출되는 메서드
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        GetComponent<AudioSource>().volume = m_Volume;
    }



}


