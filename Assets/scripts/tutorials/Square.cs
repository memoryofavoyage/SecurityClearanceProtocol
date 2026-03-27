using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Square : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject square;
    

    // Update is called once per frame
    void OnMouseDown()
    {
        square.SetActive(false);
    }
}
