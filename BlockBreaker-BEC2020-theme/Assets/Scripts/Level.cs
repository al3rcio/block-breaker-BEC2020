using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] int breakBlocks;
    SceneLoader nextScene;

    public void Start()
    {
        nextScene = FindObjectOfType<SceneLoader>();
    }

    public void Update()
    {
        winScene();
    }

    public void CountBlocks()
    {
        breakBlocks++;
    }

    public void BreakBlocks()
    {
        breakBlocks--;
    }

    public void winScene()
    {
        if (breakBlocks <= 0)
        {
            nextScene.LoadNextScene();
        }
    }
}
