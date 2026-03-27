using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class smallpage : MonoBehaviour
{
    public GameObject page;
    private AudioSource pageflip;
    public AudioClip clip;
    public GameObject keycardsprite;
    public GameObject keycardzoom;
    public GameObject highlight;
    public CharacterManager characterManager;
    public TMP_Text spacetext;
    public GameObject avatar;
    public Animator pageanim;
    public background bg;


    void Start()
    {
        page.SetActive(false);
        pageflip = GetComponent<AudioSource>();
        pageflip.clip = clip;
        keycardsprite.SetActive(false);
        keycardzoom.SetActive(false);
        highlight.SetActive(false);
        pageanim.SetBool("stop", false);
        avatar.SetActive(false);
    }
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (CharacterManager.isDead) { return; }
        pageanim.SetBool("stop", true);
        highlight.SetActive(false);

        bg.ShowPopup(page);
        pageflip.Play();
        characterManager.SheetButton();
        avatar.SetActive(false);
    }
}