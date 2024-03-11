using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSensor : MonoBehaviour
{
    [SerializeField] CollisionSensors Sensor;
    [SerializeField] MeshRenderer mesh;
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip sensorActivated;
    [SerializeField] BoxCollider collider;

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Blue"))
        {
            Destroy(col.gameObject);
            mesh.enabled = false;
            Debug.Log("Blue Active");
            Sensor.blueSensor = true;
            collider.enabled = false;
            audio.clip = sensorActivated;
            audio.Play();
        }
    }
}
