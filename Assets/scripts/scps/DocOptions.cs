using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocOptions : CandidateOptions
{
    public GameObject Question;
    private AudioSource audioSource;
    public AudioClip audioClip;
    public Animator doc;
    public Sprite grab;
    public Sprite deadSprite;
    public CharacterManager manager;
    public GameObject gameover;

    // Start is called before the first frame update

    public override void Accept()
    {
        // Optional: stop ongoing coroutines that change sprite
        StopAllCoroutines();

        StartCoroutine(SetDeadSprite());
    }

    private IEnumerator SetDeadSprite()
    {
        // Optional: small delay if needed, can be 0
        yield return null;
        manager.TriggerAnimation("dead");
        Debug.Log("dead");
        gameover.SetActive(true);
        CharacterManager.isDead = true;
        ChangeSprite(); // Use the system your code already uses
    }

    void StopLineBoil()
    {
        Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.enabled = false; // stops any animation from overriding the sprite
        }

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = deadSprite; // set the sprite you want
    }

    IEnumerator WaitAndChangeSprite()
    {
        yield return null; // wait one frame
        ChangeSprite();
    }

    public override void Enter()
    {
        Question.SetActive(true);
    }

    public override void MovedIn()
    {
        
    }

    public override void Reject()
    {
        Question.SetActive(false);
    }

    public override void SCPButton()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        Debug.Log("dead");
        gameover.SetActive(true);
        CharacterManager.isDead = true;
    }

    public override void SheetButton()
    {
        
    }

    public override void ShutterButton()
    {
        
    }

    void Start()
    {
        character = GetComponent<Character>();
        audioSource = GetComponent<AudioSource>();
        doc.SetBool("dead", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void ChangeSprite()
    {
        characterManager.ChangeSprite(grab);
        Debug.Log("ChangeSprite() called!");
    }

}
