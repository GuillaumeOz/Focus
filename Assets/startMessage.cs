using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMessage : MonoBehaviour
{
    IEnumerator waitTime() {
        yield return new WaitForSeconds(2);
        GetComponent<Canvas>().enabled = true;
        yield return new WaitForSeconds(7);
        GetComponent<Canvas>().enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
