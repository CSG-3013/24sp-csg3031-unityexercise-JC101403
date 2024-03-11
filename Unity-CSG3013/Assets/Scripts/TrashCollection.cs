using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollection : MonoBehaviour
{
    int trashCollected;
    public bool openGate = false;
    [SerializeField]AudioSource audio;
    [SerializeField]AudioClip pickUp;

    void Start()
    {
        trashCollected = 0;
        openGate = false;
        audio = GetComponent<AudioSource>();

    }

    void update()
    {

        
    }

    public void FixedUpdate()
    {
        if (trashCollected.Equals(3))
        {
            openGate = true;
        }
        else
        {
            openGate = false;
        }

        Gate();
    }

    public void Gate()
    {
        if (Input.GetKeyUp("o") && openGate == false)
        {
            trashCollected = 3;
            Debug.Log(trashCollected);
        }
        else if (Input.GetKeyUp("o") && openGate == true)
        {
            trashCollected = 0;
            Debug.Log(trashCollected);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bag"))
        {
            trashCollected++;
            Destroy(other.gameObject);
            Debug.Log(trashCollected);
            audio.clip = pickUp;
            audio.Play();

        }
    }
}
