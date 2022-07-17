using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        #if UNITY_EDITOR
            SceneManager.LoadScene("Stage2");
        #else
            SceneManager.LoadScene("Stage2");
        #endif

    }
}
