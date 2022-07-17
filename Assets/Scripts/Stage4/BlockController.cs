using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public AudioSource Effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) // 공과 충돌할 때
    {
        gameObject.SetActive(false);
        ScoreController.Jumsu += 1;
        Effect.Play();
    }
}
