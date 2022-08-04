using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string hreoname = "hussein";
    int heropower = 30;
    string villainname = "aref";
    int villainpower = 20;
    float playerspeed = 2.4f;

    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villainpower)
        {
            print("the hero will win");
        }
        else
        {
            print("the villain will win");
        }
        Setspeed();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void Setspeed(float newSpeed = 2.5f)
    {
        print("the old speed is " + playerspeed);
        playerspeed = newSpeed;
        print("the new speed is " + playerspeed);
    }
}
