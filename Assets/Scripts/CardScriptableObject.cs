using UnityEngine;


[CreateAssetMenu(fileName = "New Card", menuName = "Card", order = 1)]
public class CardScriptableObject : ScriptableObject
{
    public string cardName;

    [TextArea] public string actionDescription;
    [TextArea] public string cardLore;

    public int currentHealth;
    public int attackPower;
    public int manCost;

    public Sprite characterSprite;
    public Sprite backgroundSprite;
}
