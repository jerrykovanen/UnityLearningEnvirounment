using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping_sound : MonoBehaviour
{

    public AudioSource jump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            jump.Play();
    }
}
