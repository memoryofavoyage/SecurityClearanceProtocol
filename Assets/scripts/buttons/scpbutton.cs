using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpbutton : MonoBehaviour
{
    public Shutter Shutter;
    public AudioClip mySound;
    public AudioClip citationsound;
    public AudioSource mySource;
    public float myVolume = 1.0f;
    public GameObject character;
    public GameObject guard;
    public GameObject text;
    public guard guardmanager;
    public GameObject keycardsprite;
    public CharacterManager manager;
    public citation Citation;
    public Animator leveranim;
    public bool lever = true;
    // Start is called before the first frame update
    void Start()
    {
        
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        //Debug.Log("button");
        //Shutter.Waiting = false;
        //keycardsprite.SetActive(false);
        //mySource.PlayOneShot(mySound, myVolume);
        //StartCoroutine(waiter());
        if (CharacterManager.isDead) { return; }
        manager.SCPButton();
        lever = !lever;

        // Do Animation
        leveranim.speed = 1f; // Lazy fix.
        leveranim.SetBool("IsOn", lever);
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(4);
        Shutter.Waiting = false;
        mySource.PlayOneShot(mySound, myVolume);
        character.SetActive(false);
        guard.SetActive(true);
        text.SetActive(true);
        yield return new WaitForSeconds(4);
        text.SetActive(false);
        guardmanager.Move();
        yield return new WaitForSeconds(4);
        mySource.PlayOneShot(citationsound, myVolume);
        Citation.Waiting = false;
        yield return new WaitForSeconds(4);
        Citation.Waiting = false;
    }
}
