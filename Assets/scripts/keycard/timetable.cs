using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timetable : MonoBehaviour
{
    public GameObject timetablezoom;
    public GameObject timetablesprite;
    public AudioClip timetablesound;
    public AudioSource mySource;
    public float myVolume = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    
    void OnMouseDown()
    {
        timetablezoom.SetActive(true);
        mySource.PlayOneShot(timetablesound, 1.0f);
    }
}
