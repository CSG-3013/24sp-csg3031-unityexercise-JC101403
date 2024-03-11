using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSensor : MonoBehaviour
{
    [SerializeField] CollisionSensors Sensor;
    [SerializeField] MeshRenderer mesh;
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip sensorActivated;
    [SerializeField] CapsuleCollider collider;

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Green"))
        {
            Destroy(col.gameObject);
            mesh.enabled = false;
            Debug.Log("Green Active");
            Sensor.greenSensor = true;
            collider.enabled = false;
            audio.clip = sensorActivated;
            audio.Play();
        }
    }
}
