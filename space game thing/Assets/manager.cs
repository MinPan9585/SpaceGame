using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public bool playerDied;
    public bool gameStarted;
    public bool canEndGame;
    public GameObject blackscreen;
    public Transform playertransform;
    void Start()
    {
        playerDied = false;
        gameStarted = false;
        canEndGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(canEndGame == true)
        {
            if(playerDied == true)
            {
                Invoke("endGame", 1.5F);
                canEndGame = false;
            }
        }

        
    }

    void endGame()
    {
        blackscreen.GetComponent<SpriteRenderer>().enabled = true;
    }
}
