using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Start is called before the first frame update
public class StatSystem : MonoBehaviour
{
    [SerializeField] private int maxHealth;             // Maximum amount of health

    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private float speed;
    [SerializeField] private float smoothTime;
    int currentHealth;

    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public float Speed { get => speed; set => speed = value; }
    public float SmoothTime { get => smoothTime; set => smoothTime = value; }
    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }

    //public event System.Action OnHealthReachedZero;

    public virtual void Awake()
    {
        CurrentHealth = MaxHealth;
        //Debug.Log("CURRENT HP: " + currentHealth);
    }


    // TakeDamage()
    public void TakeDamage(int damage)
    {
        
        //Debug.Log("der damage der ankommt"+damage);
        //Debug.Log("Die uebrige hp: "+currentHealth);
        //Health cannot be negative
        //damage = Mathf.Clamp(damage, 0, MaxHealth);

        if (currentHealth - damage < 0)
        {
            currentHealth = 0;
        }
        else
        {
            CurrentHealth -= damage;
        }
        //Debug.Log(currentHealth);

        // Charcaters dies if below 0

        // Hier zuweisen bzglich deathscreen wenn man stirbt!
        if (CurrentHealth <= 0)
        {
            //Debug.Log("tot");
            if (this.gameObject.tag.Equals("PlayerHolder"))
            {
                GameOverScreen.SetActive(true);
                
            }
            
            Destroy(this.gameObject);
           
        }
    }

    // Heal()
    public void Heal(int amount)
    {
        CurrentHealth += amount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
    }

}

