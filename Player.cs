using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 10f;
    [SerializeField]
    private float health = 1.0f;

    void Start()
    {
        HealthBarHandler.SetHealthBarValue(1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //player movement
        float xMov = Input.GetAxis("Horizontal");
        float zMov = Input.GetAxis("Vertical");
	
	    Vector3 Movement = new Vector3(xMov, 0f, zMov) * moveSpeed * Time.deltaTime;

	    transform.Translate(Movement, Space.Self);
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - damageAmount);
        Debug.Log(gameObject.name + " health = " + health);
        if (health <= 0)
        {
            
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Called Die");
        SceneManager.LoadScene("DeathScene1");
    }

}
