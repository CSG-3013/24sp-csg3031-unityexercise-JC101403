using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollection : MonoBehaviour
{
    int trashCollected;
    public bool openGate = false;
    // Start is called before the first frame update
    void Start()
    {
        trashCollected = 0;
        openGate = false;
    }

    void update()
    {
        if (trashCollected.Equals(3))
        {
            openGate = true;
        }
    }

    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SM_Prop_TrashBag_01")
        {
            trashCollected++;
            Destroy(other.gameObject);
            Debug.Log(trashCollected);

        }
    }
}
