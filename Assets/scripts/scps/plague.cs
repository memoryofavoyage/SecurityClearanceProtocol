using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plague : MonoBehaviour
{
    public GameObject page049;
    public GameObject page;

    void Start()
    {
    }
    void OnMouseDown()
    {
        page049.SetActive(true);
        page.SetActive(false);
    }
}
