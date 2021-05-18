using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject startMenuUI;
    [SerializeField] private GameObject gameActiveUI;
    [SerializeField] private GameObject gameOverUI;

    private GameActive gameActiveScript;


    private void Awake()
    {
        if (GameManager.instance == null)
            instance = this;
        else
        {
            Debug.LogError("GameManager.instance already exist");
            Destroy(this.gameObject);
        }
    }


    private void Start()
    {
        gameActiveScript = GameActive.instance;
    }

    public void StartGame()
    {
        startMenuUI.SetActive(false);

        gameActiveScript.ActivateSphere();
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void RestartGame()
    {
        gameOverUI.SetActive(false);
        Debug.Log("RestartGame");
        gameActiveScript.ActivateSphere();
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
}
