using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource deathSoundEffect;
    private int times = 0;
    private bool canTakeDamage = true; 

    [SerializeField] private RawImage life1;
    [SerializeField] private RawImage life2;
    [SerializeField] private RawImage life3;

    [SerializeField] private AudioSource collectionSoundEffect;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap") && canTakeDamage)
        {
            times++;
            deathSoundEffect.Play();

            if (life3 != null && times == 1)
            {
                anim.SetTrigger("hit");
                Destroy(life3.gameObject);
            }

            if (life2 != null && times == 2)
            {
                anim.SetTrigger("hit");
                Destroy(life2.gameObject); // Destroy the GameObject associated with the RawImage component
            }
            if(life1 != null && times == 3) {
                Destroy(life1.gameObject);
            }

            if (times == 3)
            {
                Die();
            }
            else
            {
                StartCoroutine(ResetDamageCooldown());
            }
        }
        
    }

    private IEnumerator ResetDamageCooldown()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(1f);
        canTakeDamage = true;
    }
    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
