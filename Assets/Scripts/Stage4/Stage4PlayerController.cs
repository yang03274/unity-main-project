using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage4PlayerController : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    private Rigidbody2D pb;

    Vector2 MovLimit = new Vector2(23.0f, 0); // 플레이어가 가지 못하는 x축 값 받기
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        speed = 20f;
        pb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = ClampPosition(transform.localPosition); // ClampPosition 메소드를 사용해 화면을 벗어나지 못하게 막는다.

        speed_vec = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed_vec.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed_vec.x -= speed;
        }

        //transform.Translate(speed_vec);
        GetComponent<Rigidbody2D>().velocity = speed_vec;
    }
    public Vector3 ClampPosition(Vector3 position) // 범위를 지정해 일정이상 범위를 나가지 못하게 함
    {
        return new Vector3(Mathf.Clamp(position.x, -MovLimit.x, MovLimit.x), -14.3f, 0); // Mathf.Clamp를 사용해 플레이어(바)의 x축 범위를 제한
    }
}
