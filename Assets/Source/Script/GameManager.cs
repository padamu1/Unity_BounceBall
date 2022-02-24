using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    private GameObject userInterface;
    private GameObject gameMenu;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        userInterface = GameObject.FindWithTag("UI");
        gameMenu = GameObject.FindWithTag("UIMenu");
    }

    void Start()
    {
        player.SetActive(false);
    }

    void Update()
    {
        if(player.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log("TTTT");
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                player.SendMessage("PauseGame");
                userInterface.SetActive(true);
            }
        }
    }

    public void GameStart()
    {
        player.SetActive(true);
        gameMenu.SetActive(false);
    }
}

