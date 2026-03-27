using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 1;
    public bool Waiting = true;
   // public bool Accept = false;
    public AudioClip documents;
    public AudioSource mySource;
    public CharacterManager manager;
    public GameObject keycardButton;
    public GameObject highlight2;
    public GameObject timetableButton;
    public scpbutton button;
    public GameObject infected;
    public GameObject doctor;
    private Animator CandidateAnimator;
    private Animator spriteAnimator;
    [HideInInspector]public SpriteRenderer SR;
    public Sprite keycardSprite;
    public Sprite timetableSprite;
    public SpriteRenderer keycardZoom;
    public SpriteRenderer timetableZoom;
    public Sprite citationError;
    public Sprite defaultCitation;
    public bool cardError;
    public bool timetableError;
    public bool highlightshown;
    public Animator cardanim;


    // Start is called before the first frame update
    void Start()
    {
        CandidateAnimator = GetComponent<Animator>();
        SR = GetComponent<SpriteRenderer>();
        highlight2.SetActive(false);
        highlightshown = false;
        cardanim.SetBool("pressed", false);
    }
    public void Update()
    {
        //while (Accept)
        //{
        //    transform.position += Vector3.right * Time.deltaTime * speed;
       // }

    }

    public void ChangeSprite(Sprite newlook)
    {
        SR.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = newlook;
        //SR.sprite = newlook;
    }

    public void Move(Animator anim, Sprite look, Sprite keycardLook, Sprite timetableLook)
    {
        //SR.sprite = look;
        SR.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = look;
        if(anim != null)
        {
            spriteAnimator = SR.transform.GetChild(0).GetComponent<Animator>();
            spriteAnimator.runtimeAnimatorController = anim.runtimeAnimatorController;
        }
        keycardZoom.sprite = keycardLook;
        timetableZoom.sprite = timetableLook;
     
        CandidateAnimator.SetInteger("state", 1);

    }

    public void ChangeAnim(string state, bool parameter)
    {
        SR.transform.GetChild(0).GetComponent<Animator>().SetBool(state, parameter);
    }

    public void Reject()
    {
        CandidateAnimator.SetInteger("state", 3);
        manager.characterReady = true;
        //SR.transform.GetChild(0).GetComponent<Animator>().runtimeAnimatorController = null;
    }

    public void Accept()
    {
        CandidateAnimator.SetInteger("state", 2);
        manager.characterReady = true;
        //SR.transform.GetChild(0).GetComponent<Animator>().runtimeAnimatorController = null;
        //manager.Acceptpressed();
    }

    public void MovedIn()
    {
        manager.MovedIn();
        if (highlightshown == true)
        {
            cardanim.SetBool("pressed", true);
            highlight2.SetActive(false);
        }
        highlightshown = true;
     
    }

    public void MovedOut()
    {
        highlight2.SetActive(false);
        keycardButton.SetActive(false);
        timetableButton.SetActive(false);
        SR.transform.GetChild(0).GetComponent<Animator>().runtimeAnimatorController = null;
    }

    internal void TriggerAnimation(string animation)
    {
        spriteAnimator.SetTrigger(animation);
    }
    /*public void Move()
{
   transform.position = new Vector3(-8, 2, -1);

   StartCoroutine(Animate()); 
}

// Update is called once per frame
IEnumerator Animate()
{
   while (transform.position.x < 0)
   {
       transform.position += Vector3.right * Time.deltaTime * speed;
       yield return null;
   }
   while (Waiting)
   {
       manager.StopwalkingSound();
       keycardsprite.SetActive(true);
       timetable.SetActive(true);
       yield return null;
   }
   while (transform.position.x > -8)
   {
       transform.position += Vector3.left * Time.deltaTime * speed;
       yield return null;


   }
   Accept = false;
   manager.StopwalkingSound();
   manager.characterReady = true;

   // show text
}*/

}
