using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeConfig : MonoBehaviour
{
    public AudioSource aSorce;

    public float volMusic = 0f;

    // Start is called before the first frame update
    void Start()
    {
        aSorce = GetComponent<AudioSource>();



    }

    // Update is called once per frame
    void Update()
    {
        aSorce.volume = volMusic;



    }

    public void MoverVolumen(float vol)
    {
        volMusic  = vol;
    
    }



}
