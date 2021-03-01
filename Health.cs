using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int startingHealth = 10;

    private int currentHealth;
    public bool isHurt, isDead;
    public Animator anim;

    private void OnEnable()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        isHurt = true;
        anim.SetBool("isHurt", isHurt);
        currentHealth -= damageAmount;
        isHurt = false;
        Debug.Log(gameObject + " current health = " + currentHealth);
        if (currentHealth <= 0)
        {
            StartCoroutine(Die());
        }
    }

    IEnumerator Die()
    {
        isDead = true;
        anim.SetBool("isDead", isDead);
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
