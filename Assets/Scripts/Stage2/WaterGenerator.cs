using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGenerator : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float randomX;
    public float curtime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curtime += Time.deltaTime;

        if (curtime > 1.5f)
        {
            curtime = 0;

            GameObject item = Instantiate(ItemPrefab) as GameObject;

            randomX = Random.Range(23.5f, -23.5f);

            item.transform.position = new Vector3(randomX, 11.0f, 0);
        }
    }
}
