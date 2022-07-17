using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class State : MonoBehaviour
{
    public static Image content;

    // Start is called before the first frame update
    void Start()
    {
        content = GetComponent<Image>();
        content.fillAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
