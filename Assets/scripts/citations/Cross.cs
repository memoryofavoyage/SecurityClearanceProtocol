using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    public Animator citation;
    void OnMouseUpAsButton()
    {
        citation.SetInteger("state", 2);
    }
}
