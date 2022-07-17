using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LifeRecoder.PlayerLife = 1;
        Stage2Score.jumsu = 0;
        ScoreController.Jumsu = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
    public void HowToPlaySceneLoad()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
