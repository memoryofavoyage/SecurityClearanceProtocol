using UnityEngine;
//using static UnityEditor.Progress;

public class avatar : MonoBehaviour
{
    public Transform nose;
    public Transform eyes;
    public Transform skin;
    public Transform hair;
    public Transform accessory;
    public Transform mouth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        for (int i = 0; i < nose.childCount; i++)
        {
            nose.GetChild(i).gameObject.SetActive(false);
        }
        nose.GetChild(GameData.noseindex).gameObject.SetActive(true);
        for (int i = 0; i < hair.childCount; i++)
        {
            hair.GetChild(i).gameObject.SetActive(false);
        }
        hair.GetChild(GameData.hairindex).gameObject.SetActive(true);
        for (int i = 0; i < skin.childCount; i++)
        {
            skin.GetChild(i).gameObject.SetActive(false);
        }
        skin.GetChild(GameData.skinindex).gameObject.SetActive(true);
        for (int i = 0; i < eyes.childCount; i++)
        {
            eyes.GetChild(i).gameObject.SetActive(false);
        }
        eyes.GetChild(GameData.eyeindex).gameObject.SetActive(true);
        for (int i = 0; i < accessory.childCount; i++)
        {
            accessory.GetChild(i).gameObject.SetActive(false);
        }
        accessory.GetChild(GameData.accessoryindex).gameObject.SetActive(true);
        for (int i = 0; i < mouth.childCount; i++)
        {
            mouth.GetChild(i).gameObject.SetActive(false);
        }
        mouth.GetChild(GameData.mouthindex).gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
