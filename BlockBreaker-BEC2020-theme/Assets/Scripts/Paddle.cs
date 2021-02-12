using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidth = 16f;
    [SerializeField] float leftLimitScreen = 1f;
    [SerializeField] float rightLimitScreen = 15f;

    // cached references
    GameStatus autoPlay;
    Ball ball;
    


    // Start is called before the first frame update
    void Start()
    {
        autoPlay = FindObjectOfType<GameStatus>();
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetPosX(), leftLimitScreen, rightLimitScreen); 
        transform.position = paddlePos;
    }

    private float GetPosX()
    {
        if (autoPlay.AutoPlay())
        {
            return ball.transform.position.x;
        }
        else
        {
            float mousePos = Input.mousePosition.x / Screen.width * screenWidth;
            return mousePos;
        }
    }
}
