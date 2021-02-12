using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameStatus : MonoBehaviour
{
    // params
    [Range(0.5f, 2f)]  [SerializeField] float gameSpeed = 1f;
    [SerializeField] int scoreForBlocks = 94;
    [SerializeField] TextMeshProUGUI scoreUI;

    // states variables
    [SerializeField] public int currentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            
            DontDestroyOnLoad(gameObject);
        }

    }

    private void Start()
    {
        StartScore();
    }

    public void StartScore()
    {
        currentScore = 0;
        scoreUI.text = currentScore.ToString();
    }

    public void AddToScore()
    {
        currentScore += scoreForBlocks;
        scoreUI.text = currentScore.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }
}
