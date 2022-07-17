using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage3PlayerController : MonoBehaviour
{
    public bool mouseState;
    public Transform start;
    Vector3 mouspos;
    Rigidbody2D playerRd;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = start.position;
        playerRd = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.GameIsPaused == false)
        {
            mouseState = true;
            mouspos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            -Camera.main.transform.position.z));

            gameObject.transform.position = mouspos;
            Cursor.visible = mouseState;
        }
        else
        {
            mouseState = false;
            playerRd.constraints = RigidbodyConstraints2D.FreezeAll;
            Cursor.visible = mouseState;
        }
        
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "wall")
        {
            #if UNITY_EDITOR
                SceneManager.LoadScene("MainMenu");
            #else
                SceneManager.LoadScene("MainMenu");
            #endif
        }
        if (collision.gameObject.tag == "exit")
        {
            #if UNITY_EDITOR
                SceneManager.LoadScene("Stage4");
            #else
                SceneManager.LoadScene("Stage4");
            #endif
        }
    }
}
