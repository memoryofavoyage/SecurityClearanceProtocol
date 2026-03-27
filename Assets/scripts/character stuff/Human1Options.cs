using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Human1Options : CandidateOptions
{
    private IEnumerator coroutine;
    public Animator shutter;
    private AudioSource footstep;
    public AudioClip clip;
    public float footsteptime;
    public bool lever = true;
    public Animator leveranim;

    public override void Accept()
    {
        if (cardError || timetableError)
        {
            characterManager.IssueCitation(citationError);
        }
        characterManager.Acceptprocedure();
    }

    public override void Enter()
    {
        
        
        
    }

    public override void Reject()
    {
        if (cardError == false && timetableError == false) 
        {
            characterManager.IssueCitation(defaultCitation);
        }
        
    }

    public override void SCPButton()
    {
        
        shutter.SetBool("down", true);
        StartCoroutine(Shutterup());
        characterManager.IssueCitation(defaultCitation);

    }

    IEnumerator Shutterup()
    {
        yield return new WaitForSeconds(1.5f);
        characterManager.Reject();
        shutter.SetBool("down", false);
        leveranim.SetBool("IsOn", true);
    }

    public override void SheetButton()
    {
        
    }

    public override void ShutterButton()
    {
        
    }

    public override void MovedIn()
    {
        StartCoroutine(Footsteps());
        character.timetableButton.SetActive(true);
        character.keycardButton.SetActive(true);
        keycard card = character.keycardButton.GetComponent<keycard>();
        if (card)
        {
            card.SetCardType(cardType);
        }
        
    }

    IEnumerator Footsteps()
    {
        footstep.Play();
        yield return new WaitForSeconds(footsteptime);
        footstep.Stop();
    }

    // Start is called before the first frame update
    void Start()
    {
        footstep = GetComponent<AudioSource>();
        footstep.clip = clip;
        character = GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
