using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBomb : MonoBehaviour
{
    public GameObject jet;
    public GameObject bomb;
    public KeyCode space;
    int interval = 1;
    float nextTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(space))
        {
            if (Time.time >= nextTime)
            {
                Instantiate(bomb, jet.transform.position, jet.transform.rotation);
                nextTime += interval;

            }
        }

    }

}
