using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody2D ballRd;
    public float speed = 930.0f;
    Vector3 lastVelocity;
    public AudioSource balleffect;
    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody2D>();
        ballRd.AddForce(new Vector2(speed, speed * 0.7f)); // 시작 시 공에 힘을 주어 쏘는 코드
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = ballRd.velocity;

        Vector2 ballScreenPos = Camera.main.WorldToScreenPoint(ballRd.position); //공에 대한 화면 좌표 값이 들어간다

        if (ScoreController.Jumsu == 15) // 블록이 모두 파괴된 경우
        {
            #if UNITY_EDITOR
                SceneManager.LoadScene("Clear");
            #else
                SceneManager.LoadScene("Clear");
            #endif
        }
        else if (ballScreenPos.x > Screen.width || ballScreenPos.x < 0 || ballScreenPos.y > Screen.height || ballScreenPos.y < 0) // 공이 화면을 벗어나는 경우
        {
            #if UNITY_EDITOR
                SceneManager.LoadScene("MainMenu");
            #else
                SceneManager.LoadScene("MainMenu");
            #endif
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) // 부딪쳤을 때
    {
        var speed = lastVelocity.magnitude;     // 공의 현재 속도
        var dir = Vector2.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        ballRd.velocity = dir * Mathf.Max(speed, 0f);
        if (collision.gameObject.tag == "player")
        {
            balleffect.Play();
        }
    }
}
