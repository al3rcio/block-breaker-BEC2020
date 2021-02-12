using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // configurando parametros
    [SerializeField] Paddle paddle1;
    [SerializeField] GameObject[] wall;
    [SerializeField] float speedX = 2f;
    [SerializeField] float speedY = 15f;
    [SerializeField] AudioClip[] hitSounds;
    [SerializeField] float randomFactor = 0.2f;
    
    // states
    Vector2 paddleToBallVector;
    bool isLaunch = false;

    // cached components
    AudioSource myAudioSource;
    Rigidbody2D rgbd;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
        rgbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaunch)
        {
            BallStickPaddle();
            LaunchOnClick();
        } 
    }

    private void LaunchOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isLaunch = true;
            rgbd.velocity = new Vector2(speedX, speedY);
        }
    }

    private void BallStickPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddleToBallVector + paddlePos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2
            (UnityEngine.Random.Range(0f, randomFactor),
             UnityEngine.Random.Range(0f, randomFactor));
        if (isLaunch)
        {
            rgbd.velocity += velocityTweak;
            myAudioSource.PlayOneShot(hitSounds[0]);
        }
        
        
    }

}
