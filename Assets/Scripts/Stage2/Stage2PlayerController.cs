using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage2PlayerController : MonoBehaviour
{
    public float speed = 15f;
    public Vector2 speed_vec;
    private Rigidbody2D rd;
    public AudioSource waterSound;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
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

        GetComponent<Rigidbody2D>().velocity = speed_vec;

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.x < 0f) 
        {
            pos.x = 0f;
        }
        if (pos.x > 1f)
        {
            pos.x = 1f;
        }

        transform.position = Camera.main.ViewportToWorldPoint(pos);

        if (LifeRecoder.PlayerLife == 0)
        {
            #if UNITY_EDITOR
                SceneManager.LoadScene("MainMenu");
            #else
                SceneManager.LoadScene("MainMenu");
            #endif
        }
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Water")
        {
            waterSound.Play();
        }
	}
}
