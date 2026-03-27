using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accept : MonoBehaviour
{
    public SpriteRenderer gameover;
    public CharacterManager manager;
    public GameObject keycardsprite;
    public Animator doc;
    private AudioSource acceptsound;
    public AudioClip clip;
    void Start()
    {
        gameover.enabled = false;
        acceptsound = GetComponent<AudioSource>();
        acceptsound.clip = clip;
    }
    void OnMouseDown()
    {
        if (CharacterManager.isDead) { return; }
        //doc.SetBool("dead", true);
        Debug.Log("Clicked!");
        manager.Acceptpressed();
        acceptsound.Play();
    }
}
