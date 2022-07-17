using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeText : MonoBehaviour
{
    public Text Stage1time;
    private float time_max = 60.0f;
    public float cur_time;
    // Start is called before the first frame update
    void Start()
    {
        cur_time = time_max;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Floor(cur_time) <= 0)
        {
            #if UNITY_EDITOR
                SceneManager.LoadScene("MainMenu");
            #else
                SceneManager.LoadScene("MainMenu");
            #endif
        }
        else 
        {
            cur_time -= Time.deltaTime;
            if (cur_time <= 10)
            {
                Stage1time.text = "<color=#ff0000>" + Mathf.Floor(cur_time) + "</color>"; // 색 넣기
            }
            else
            {
                Stage1time.text = Mathf.Floor(cur_time).ToString();
            }
            
        }
    }
}
