using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip pickUp;
    [SerializeField] bool isKeyCollected;

    void Start()
    {

        audio = GetComponent<AudioSource>();
        isKeyCollected = false;

    }

    void update()
    {


    }

    public void FixedUpdate()
    {
    
    }

    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            Debug.Log("Key Collected");
            isKeyCollected = true;
            audio.clip = pickUp;
            audio.Play();

        }
    }
}
