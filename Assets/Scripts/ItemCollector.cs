using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 6;
    private int pineapples = 2;
    private int fishes = 3;
    private int apples = 2;

    [SerializeField] private Text cherriesText, pineapplesText, fishesText, applesText;
    [SerializeField] private AudioSource collectionSoundEffect, completedSoundEffect, completedAllSoundEffect;
    [SerializeField] private GameObject cherriesCompleted, pineappleCompleted, fishesCompleted, applesCompleted;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (cherries == 0 && pineapples == 0 && fishes == 0 && apples == 0)
        {
            completedAllSoundEffect.Play();
            return;
        }

        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries--;
            if (cherries > 0) {
                collectionSoundEffect.Play();
                cherriesText.text = "x" + cherries;
            }
            if (cherries == 0)
            {
                completedSoundEffect.Play();
                cherriesText.text = null;
                cherriesCompleted.SetActive(true);
            }
        }

        if (collision.gameObject.CompareTag("Pineapple"))
        {

            Destroy(collision.gameObject);
            pineapples--;
            if (pineapples > 0) {
                collectionSoundEffect.Play();
                pineapplesText.text = "x" + pineapples;
            }
            if (pineapples == 0)
            {
                completedSoundEffect.Play();
                pineapplesText.text = null;
                pineappleCompleted.SetActive(true);
            }
        }


        if (collision.gameObject.CompareTag("Fish"))
        {

            Destroy(collision.gameObject);
            fishes--;
            if (fishes > 0)
            {
                collectionSoundEffect.Play();
                fishesText.text = "x" + fishes;
            }
            if (fishes == 0)
            {
                completedSoundEffect.Play();
                fishesText.text = null;
                fishesCompleted.SetActive(true);
            }
        }

        if (collision.gameObject.CompareTag("Apple"))
        {

            Destroy(collision.gameObject);
            apples--;
            if (apples > 0)
            {
                collectionSoundEffect.Play();
                applesText.text = "x" + apples;
            }
            if (apples == 0)
            {
                completedSoundEffect.Play();
                applesText.text = null;
                applesCompleted.SetActive(true);
            }
        }

        if (collision.gameObject.CompareTag("Ingredient"))
        {
            Destroy(collision.gameObject);
            collectionSoundEffect.Play();
        }
    }
}
