
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/VisitorInfo", order = 1)]
public class VisitorInfo : ScriptableObject
{
    // Start is called before the first frame update
    public VisitorType VisitorType;
    public Sprite CardImage;
    public bool Fake;
}

public enum VisitorType
{
    GoodHuman,
    BadHuman,
    Scp049,
    Scp096,
    Scp999,
    Scp173
}
