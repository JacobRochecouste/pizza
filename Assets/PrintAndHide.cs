using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.tag == "Blue")
        {
            i = Random.Range(0, 1000);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ": " + i);
        ++i;

        if(gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i >= 200 && i <= 250)
        {
            rend.enabled = false;
        }
    }
}
