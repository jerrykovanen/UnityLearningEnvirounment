using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 6;
    public float turnSpeed = 4;
    public float jumpingSpeed = 9; //float value for numbers
    public float smooth = 5.0f;
    public Animator playerAnimator;


    void Update()
    {
        float strafe = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(strafe, 0, forward) * speed * Time.deltaTime); //moves the amount and direction translation has.'
        float turn = Input.GetAxis("Mouse X");

        
        transform.rotation *= Quaternion.Slerp(Quaternion.identity, Quaternion.LookRotation(turn < 0 ? Vector3.left : Vector3.right), Mathf.Abs(turn) * turnSpeed * Time.deltaTime);
        //honestly I tried playing around with code, but I had to use help from internet to make these 
        // I am still very much beginner when it comes to coding


        transform.Translate(0, jumpingSpeed * Input.GetAxis("Jump") * Time.deltaTime, 0);

        // This is the jump function, works with space
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
    private void Jump()
    {
        playerAnimator.SetTrigger("Jump");
    }
}

