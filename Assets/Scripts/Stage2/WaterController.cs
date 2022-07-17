using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
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
        if (collision.gameObject.tag == "player")
        {
            Destroy(gameObject);
            Stage2Score.jumsu += 5;
            State.content.fillAmount += 0.1f;
        }
        if (collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
            if (Stage2Score.jumsu > 0)
            {
                Stage2Score.jumsu -= 5;
            }
            State.content.fillAmount -= 0.1f;
        }
	}
}
