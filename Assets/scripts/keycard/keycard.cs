using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycard : MonoBehaviour
{
    public enum Type
    {
        Scientist,
        Guard
    }
    public Sprite scientistCard;
    public Sprite guardCard;
    public GameObject keycardzoom;
    public GameObject keycardsprite;
    public AudioClip documents;
    public AudioClip card;
    public AudioSource mySource;
    public float myVolume = 1.0f;
    private bool SoundPlayed = false;
    public GameObject highlight2;
    public Animator cardanim;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public void Update()
    {
        if(keycardsprite.activeSelf && !SoundPlayed)
        {
            docu();
        }
    }
    private void OnEnable()
    {
        Debug.Log("Enabled");
    }
    void OnMouseDown()
    {
        keycardzoom.SetActive(true);
        mySource.PlayOneShot(card, 1.0f);
        highlight2.SetActive(false);
        cardanim.SetBool("pressed", true);
    }
    void docu()
    {
        mySource.PlayOneShot(documents, myVolume);
        SoundPlayed = true;
    }

    public void SetCardType(Type type)
    {
        switch (type)
        {
            case Type.Scientist:
                spriteRenderer.sprite = scientistCard;
                break;
            case Type.Guard:
                spriteRenderer.sprite = guardCard;
                break;
        }
    }
}
