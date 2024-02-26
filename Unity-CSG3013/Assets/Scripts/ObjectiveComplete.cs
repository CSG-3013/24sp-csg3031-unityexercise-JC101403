using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveComplete : MonoBehaviour
{
    [SerializeField] TrashCollection TC;
    [SerializeField] Animator gate;
    //[SerializeField] AudioClip gateScratch;
    [SerializeField] AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
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
            gate.SetBool("isOpen",true);
            
            
        }
        else
        {
            Debug.Log("Gate is closed");
            gate.SetBool("isOpen", false);

        }

    }

    public void PlayGateScratch()
    {
        audio.Play();
    }
}
