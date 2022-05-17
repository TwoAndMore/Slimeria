using UnityEngine;

[CreateAssetMenu(fileName = "Building", menuName = "Building")]
public class ScriptableBuilding : ScriptableObject
{
    public GameObject prefab;
    public Sprite image;
    public int price;
    public string title;
    public string description;
}
