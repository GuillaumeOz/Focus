using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSound : MonoBehaviour
{
    public AudioSource  source;
    public AudioClip    clip;
    // Start is called before the first frame update
    void Start()
    {
        source.clip = clip;
        source.loop = true;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
