using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollection : MonoBehaviour
{
    int trashCollected;
    public bool openGate = false;

    void Start()
    {
        trashCollected = 0;
        openGate = false;
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

    void onTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if (other.gameObject.CompareTag("Trash"))
        {
            trashCollected++;
            Destroy(other.gameObject);
            Debug.Log(trashCollected);

        }
    }

    void onCollisionEnter(Collision other)
    {
        Debug.Log("hit");
            Destroy(other.gameObject);
    }
}
