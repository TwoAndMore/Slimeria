using UnityEngine;

[CreateAssetMenu(fileName = "BuildingUpgrade", menuName = "Building  Upgrade")]
public class ScriptableBuildingUpgrade : ScriptableObject
{
    public Sprite image;
    public int price;
    public string title;
    public string description;
}
