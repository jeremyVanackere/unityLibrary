using UnityEngine;

[CreateAssetMenu(fileName = "CharacterEntityData", menuName = "ScriptableObjects/CharacterEntityData", order = 1)]
public class CharacterEntityData : ScriptableObject
{
    public int hp = 1;
    public int maxHp = 1;
}
