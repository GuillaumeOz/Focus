using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eolienne : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cam2.enabled == true) {
            Debug.Log("in here");
        }
    }
}
