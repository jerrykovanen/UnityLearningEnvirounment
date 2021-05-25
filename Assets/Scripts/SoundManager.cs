using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Space))
        {
 
            source.Play();
        }
    }

}
