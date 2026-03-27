using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backscript : MonoBehaviour
{
    public GameObject pageToReturnTo;
    public GameObject page;
    public GameObject page049;
    public GameObject page096;
    public GameObject page173;
    public GameObject page999;
    void OnMouseDown()
    {
        pageToReturnTo.SetActive(true);
        page.SetActive(false);
    }
    void Start()
    {
        if (page049 != null) page049.SetActive(false);
        if (page096 != null) page096.SetActive(false);
        if (page173 != null) page173.SetActive(false);
        if (page999 != null) page999.SetActive(false);
    }
}
