using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peanutguy : MonoBehaviour
{
    public SpriteRenderer page049;
    public GameObject page;
    public SpriteRenderer page096;
    public GameObject page173;
    public SpriteRenderer back;
    void OnMouseDown()
    {
        page173.SetActive(true);
        page.SetActive(false);
        back.enabled = true;
    }
}
