using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveComplete : MonoBehaviour
{
    [SerializeField] TrashCollection TC;
    [SerializeField] Animator gate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OpenGate();
    }

    public void OpenGate()
    {
        if (TC.openGate.Equals(true))
        {
            Debug.Log("Gate is open");
        }
        else
        {
            Debug.Log("Gate is closed");
        }
        
    }
}
