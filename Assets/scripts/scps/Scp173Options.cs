using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scp173Options : CandidateOptions
{
 
   
    private IEnumerator coroutine;
    public Animator shutter;
    public Shutter shutterEvent;
    public CharacterManager manager;
    public GameObject gameover;
    private AudioSource move;
    public AudioClip clip;
    public GameObject blink;
    public float movetime;
    public override void Accept()
    {
        Debug.Log("dead");
        CharacterManager.isDead = true;
        gameover.SetActive(true);
    }
    
    public override void Enter()
    {
        StartCoroutine(Blink());
        shutterEvent.OnShutterChange += ShutterDown;
    }



    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
    }

    private void ShutterDown(object sender, string direction)
    {
        if (direction == "down")
        {
            manager.Reject();
        }

    }

    public override void Reject()
    {
        
    }

    public override void SCPButton()
    {
        
        //StopCoroutine(coroutine);
        shutter.SetBool("down", true);
        StartCoroutine(Shutterup());
    }

    IEnumerator Shutterup()
    {
        yield return new WaitForSeconds(1.5f);
        shutter.SetBool("down", false);
    }
    

    public override void MovedIn()
    {
        //StartCoroutine(Blink());
        StartCoroutine(Move());
        
    }
    IEnumerator Blink()
    {
        blink.SetActive(true);
        yield return new WaitForSeconds(1);
        blink.SetActive(false);
    }
    IEnumerator Move()
    {
        move.Play();
        yield return new WaitForSeconds(movetime);
        move.Stop();
    }

    public override void SheetButton()
    {
        Debug.Log("dead");
        CharacterManager.isDead = true;
        gameover.SetActive(true);
    }

    public override void ShutterButton()
    {
        gameover.SetActive(true);
        Debug.Log("scp173");
        CharacterManager.isDead = true;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Character>();
        gameover.SetActive(false);
        move = GetComponent<AudioSource>();
        move.clip = clip;
        blink.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
