using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage1PlayerController : MonoBehaviour
{
    public Transform warpExit;
    public float speed = 15f;
    public Vector2 speed_vec;
    private Rigidbody2D rd;
    public Animator anim;
    bool state;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        speed_vec = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed_vec.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed_vec.x -= speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed_vec.y += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed_vec.y -= speed;
        }

        GetComponent<Rigidbody2D>().velocity = speed_vec;

        if (LifeRecoder.PlayerLife == 0)
        {
            #if UNITY_EDITOR
                SceneManager.LoadScene("MainMenu");
            #else
                SceneManager.LoadScene("MainMenu");
            #endif
        }

        if (state)
        {
            anim.SetBool("HitState", true);
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("PlayerHit") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.1f)
            {
                state = false;
            }
        }
        else 
        {
            anim.SetBool("HitState", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            state = true;
            LifeRecoder.PlayerLife -= 1;
        }
        if (collision.gameObject.tag == "Warp")
        {
            gameObject.transform.position = warpExit.transform.position;
        }
    }

}
