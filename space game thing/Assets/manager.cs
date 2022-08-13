using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public bool playerDied;
    public bool gameStarted;
    public bool canEndGame;
    public GameObject blackscreen;
    public Transform playertransform;
    public Text endGameText;
    public GameObject player;
    public int distanceEndGame;
    public Text inGameText;
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
                inGameText.enabled = false;
                endGameText.enabled = true;
                distanceEndGame = (int)player.transform.position.x;
                endGameText.text = "YOU DIED! YOUR DISTANCE IS " + distanceEndGame.ToString();
                
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
