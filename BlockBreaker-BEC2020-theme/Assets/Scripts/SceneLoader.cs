using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// PS1='${PWD##*/} $ ' --- comando pra limpar nomes dir no wsl

public class SceneLoader : MonoBehaviour
{

    GameStatus gamestatus;

    private void Start()
    {
        gamestatus = FindObjectOfType<GameStatus>();
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadFirstScene()
    {
        gamestatus.StartScore();
        SceneManager.LoadScene("Start Menu");
    }
}
