using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class docusound : MonoBehaviour
{
    private AudioSource document;
    public AudioClip clip;
    public Character[] characters;
    // Start is called before the first frame update
    void Start()
    {
        document = GetComponent<AudioSource>();
        document.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StopwalkingSound()
    {
        document.Play();
    }
}
