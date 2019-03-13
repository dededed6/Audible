using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    AudioSource ballAudio; // AudioSource를 저장할 변수 선언
    void Start()
    {
        ballAudio = GetComponent<AudioSource>(); // 시작시 컴포넌트 읽기
        Debug.Log("오디오 파일 = " + ballAudio.clip.name); // Log출력
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collusion)
    {
        ballAudio.Play();
        print("공과 충돌한 물체 = " + collusion.gameObject.name); // Log 출력
    }
}
