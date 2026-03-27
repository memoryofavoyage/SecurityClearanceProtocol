using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CandidateOptions:MonoBehaviour
{
    public CharacterManager characterManager;
    protected Character character;
    public Sprite citationError;
    public Sprite defaultCitation;
    public bool cardError;
    public bool timetableError;
    public GameObject timetable;
    public GameObject keycard;
    public keycard.Type cardType = global::keycard.Type.Scientist;

    public abstract void Enter();
    public abstract void Reject();
    public abstract void Accept();


    public abstract void SCPButton();

    public abstract void ShutterButton();

    public abstract void SheetButton();

    public abstract void MovedIn();
}
