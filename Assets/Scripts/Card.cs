using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Card : MonoBehaviour
{
    public CardScriptableObject cardSO;

    public int currentHealth;
    public int attackPower;
    public int manaCost;

    public TMP_Text healthText;
    public TMP_Text attackText;
    public TMP_Text manaText;
    public TMP_Text nameText;
    public TMP_Text actionDescriptionText;
    public TMP_Text loreText;

    public Image characterArt;
    public Image bgArt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetupCard();
    }

    public void SetupCard() 
    {
        currentHealth = cardSO.currentHealth;
        attackPower = cardSO.attackPower;
        manaCost = cardSO.manCost;

        healthText.text = currentHealth.ToString();
        attackText.text = attackPower.ToString();
        manaText.text = manaCost.ToString();

        nameText.text = cardSO.cardName;
        actionDescriptionText.text = cardSO.actionDescription;
        loreText.text = cardSO.cardLore;

        characterArt.sprite = cardSO.characterSprite;
        bgArt.sprite = cardSO.backgroundSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
