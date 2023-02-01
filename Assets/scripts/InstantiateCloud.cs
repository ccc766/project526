using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InstantiateCloud : MonoBehaviour
{
    public GameObject cloud;
    float x_random;
    float time = 2;
    void Start()
    {
        InvokeRepeating("initialize", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void initialize()
    {
        x_random = Random.Range(-50f, -450f);
        GameObject gameobj = Instantiate(cloud);
        gameobj.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width + 150, Screen.height + x_random, 10));
        GameObject textbOject = gameobj.transform.GetChild(0).gameObject;
        TextMeshPro text = textbOject.GetComponent<TextMeshPro>();
        text.SetText("12345");
        Debug.Log(text);
    }
}
