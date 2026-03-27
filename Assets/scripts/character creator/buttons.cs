using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class buttons : MonoBehaviour
{
    public enum bodypart
    {
        skin,
        nose,
        eyes,
        hair,
        accessories,
        mouths
    }
    
    public Transform options;
    private int index = 0;
    public bodypart part;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        for (int i = 0; i < options.childCount; i++)
        {
            options.GetChild(i).gameObject.SetActive(false);
        }
        options.GetChild(0).gameObject.SetActive(true);
    }
    void OnMouseDown()
    {
        options.GetChild(index).gameObject.SetActive(false);
        index += 1;
        UpdateGameData();
        if (index == options.childCount)
        {
            index = 0;
            UpdateGameData();
        }
        options.GetChild(index).gameObject.SetActive(true);
    }

    void UpdateGameData()
    {
        if (part == bodypart.nose)
        {
            GameData.noseindex = index;
        }
        if (part == bodypart.eyes)
        {
            GameData.eyeindex = index;
        }
        if (part == bodypart.hair)
        {
            GameData.hairindex = index;
        }
        if (part == bodypart.skin)
        {
            GameData.skinindex = index;
        }
        if (part == bodypart.mouths)
        {
            GameData.mouthindex = index;
        }
        if (part == bodypart.accessories)
        {
            GameData.accessoryindex = index;
        }
        {
            
        }
    }
}
