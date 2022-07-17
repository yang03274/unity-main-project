using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage2ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Stage2Score.jumsu >= 50)
        {
            #if UNITY_EDITOR
                SceneManager.LoadScene("Stage3Controlreview");
            #else
                SceneManager.LoadScene("Stage3Controlreview");
            #endif
        }
    }
}
