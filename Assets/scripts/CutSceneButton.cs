using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutSceneButton : MonoBehaviour
{
    public Image sequence;
    public Sprite[] cutSequence;
    private int index = 0;
    public string nextScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void SetSceneImage()
    {
        sequence.sprite = cutSequence[index];
    }

    public void Start()
    {
        SetSceneImage();
    }
    public void NextImage() 
    {
        index += 1;
        if (index == cutSequence.Length)
        {
            SceneManager.LoadScene(nextScene);
        }
        SetSceneImage();
    }
}
