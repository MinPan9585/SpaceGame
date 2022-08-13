using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceDisplay : MonoBehaviour
{
    public Text distanceText;
    public GameObject player;
    private string distanceString;

    // Update is called once per frame
    void Update()
    {
        distanceText.text = "Your Distance Is " + ((int)player.transform.position.x).ToString();
    }
}
