using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionSensors : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] bool hasKey;
    [SerializeField] public bool redSensor;
    [SerializeField] public bool greenSensor;
    [SerializeField] public bool blueSensor;
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip keyPickUp;
    [SerializeField] AudioClip Unlock;


    public bool openGate;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        key.SetActive(false);
        greenSensor = false;
        blueSensor = false;
        redSensor = false;
        hasKey = false;
        openGate = false;
    }

    // Update is called once per frame
    void Update()
    {
        Key();
    }

    public void Key()
    {
        if (redSensor == true && greenSensor == true && blueSensor == true) 
        {
            key.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            Debug.Log("Key collected");
            hasKey = true;
            audio.clip = keyPickUp;
            audio.Play();
        }

        if (other.CompareTag("Lock") && hasKey == true)
        {
            Destroy(other.gameObject);
            Debug.Log("Lock Destroyed");
            openGate = true;
            audio.clip = Unlock;
            audio.Play();
        }

        if (other.CompareTag("Idol"))
        {
            Debug.Log("You Win");
            SceneManager.LoadScene(2);
        }
    }
}
