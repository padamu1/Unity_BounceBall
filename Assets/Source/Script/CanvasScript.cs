using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    private GameObject player;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ResumeGame();
        }
    }

    public void ResumeGame()
    {
        gameObject.SetActive(false);
        player.SendMessage("ResumeGame");
    }
}
