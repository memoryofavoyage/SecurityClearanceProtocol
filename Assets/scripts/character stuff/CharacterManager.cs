using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class CharacterManager : MonoBehaviour
{
    public Character candidate;
    public Character[] characters;
    private int index = -1;
    [HideInInspector]public bool characterReady = true;
    public Animator citation;
    public int mistakes = 0;
    public TMP_Text resultstext;
    public GameObject results;
    public TMP_Text spacetext;
    public GameObject question;
    public static bool isDead = false;
    public TMP_Text restart;
    public Animator shutter;
    // Start is called before the first frame update
    void Start()
    {
        restart.enabled = false;
        resultstext.enabled = false;
        results.SetActive(false);
        spacetext.enabled = false;
        CharacterManager.isDead = false;
        
    }
    

    public void ChangeSprite(Sprite newlook)
    {
        candidate.ChangeSprite(newlook);
    }

    public void TriggerAnimation(string animation)
    {
        candidate.TriggerAnimation(animation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && characterReady)
        {
            spacetext.enabled = false;
            index += 1;
            if (index == characters.Length)
            {
                Endofshift();
            }
            characters[index].Waiting = true;
            Animator anim = characters[index].GetComponent<Animator>();
            candidate.Move(anim, characters[index].SR.sprite, characters[index].keycardSprite, characters[index].timetableSprite);
            characters[index].GetComponent<CandidateOptions>().Enter();
            characterReady = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        if (isDead == true)
        {
            restart.enabled = true;
            question.SetActive(false);
        }
    }

    public void ChangeAnim(string state, bool parameter)
    {
        characters[index].ChangeAnim(state, parameter);
    }

    private void Endofshift()
    {
        string message = $"shift ended. you made {mistakes} mistakes";
        resultstext.enabled = true;
        results.SetActive(true);
        resultstext.text = message;
    }

    public void ShutterButton()
    {
        if (index == -1)
        {
            if (!shutter.GetBool("down") == false)
            {
                //ShutterButton();
            }
            shutter.SetBool("down", !shutter.GetBool("down"));
            return;
        }
        characters[index].GetComponent<CandidateOptions>().ShutterButton();
        
    }

    public void SheetButton()
    {
        characters[index].GetComponent<CandidateOptions>().SheetButton();
    }

    public void MovedIn()
    {
        characters[index].GetComponent<CandidateOptions>().MovedIn();
    }

    public void Reject() 
    {
        characters[index].GetComponent<CandidateOptions>().Reject();
        candidate.Reject();
        characters[index].Waiting = false;
     
    }
    public void Acceptpressed()
    {
        Debug.Log("accept");
        
        characters[index].GetComponent<CandidateOptions>().Accept();
        
        
        // characters[index].Accept = true;
    }

    public void Acceptprocedure()
    {
        characters[index].Waiting = false;
        candidate.Accept();
    }

    public void SCPButton()
    {
        if (index >= 0 && index < characters.Length)
        {
            characters[index].GetComponent<CandidateOptions>().SCPButton();
        }
    }
    public void StopwalkingSound()
    {
       
    }

    internal void IssueCitation(Sprite citationError)
    {
        citation.GetComponent<SpriteRenderer>().sprite = citationError;
        citation.SetInteger("state", 1);
        mistakes = mistakes + 1;
       
    }
}
