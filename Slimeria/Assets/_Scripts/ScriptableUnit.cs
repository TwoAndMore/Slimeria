using UnityEngine;

[CreateAssetMenu(fileName = "New Slime", menuName = "Slime")]
public class ScriptableUnit : ScriptableObject
{
    public SlimeType slimeType;
    public GameObject prefab;
    public int health;
    public float speed;
}

public enum SlimeType
{
    Simple,
    Water,
}