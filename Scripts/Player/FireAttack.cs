using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FireAttack : MonoBehaviour
{
    public int PlayerHealth = 30;
    int damage = 1;


    private void Start()
    {
        print(PlayerHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fire")
        {
            PlayerHealth -= damage;
            print(PlayerHealth + "Darn");
        }
    }

    private void update()
    {
        if (PlayerHealth <= 0)
        {
            Destroy(gameObject, 0.3f);
        }
    }
    private void Update()
    {
        if (PlayerHealth <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }
}