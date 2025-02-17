using UnityEngine.UI;
using UnityEngine;

public class PlayStats : MonoBehaviour
{
    public Slider healthBar;
    public float maxHealth = 100;

    public float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.value = currentHealth / maxHealth;

    }

    public void GetHeal(float heal)
    {
        currentHealth += heal;
        healthBar.value = currentHealth / maxHealth;
    }
}
