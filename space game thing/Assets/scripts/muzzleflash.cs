using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzzleflash : MonoBehaviour
{
    private void Awake()
    {
        Invoke("selfDestruct", 0.1F);
    }

    private void selfDestruct()
    {
        Destroy(gameObject);
        //Debug.Log("self destruction is called");
    }
}
