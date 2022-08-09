using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawn : MonoBehaviour
{

    public Transform playertrans;
    public float anchor;
    public GameObject map;
    void Start()
    {
        anchor = 64;
    }

    // Update is called once per frame
    void Update()
    {
        checkpos();
    }

    private void checkpos()
    {
        if (playertrans.position.x >= anchor)
        {
            //Debug.Log("pass");
            Instantiate(map, new Vector3(anchor + 64, 0, 0), new Quaternion(0,0,0,0));
            anchor = anchor + 64;
        }
    }
}
