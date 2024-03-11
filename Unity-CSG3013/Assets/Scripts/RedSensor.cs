using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSensor : MonoBehaviour
{
    [SerializeField] CollisionSensors Sensor;
    [SerializeField] MeshRenderer mesh;
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip sensorActivated;
    [SerializeField] SphereCollider collider;

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Red"))
        {
            Destroy(col.gameObject);
            mesh.enabled = false;
            Debug.Log("Red Active");
            Sensor.redSensor = true;
            collider.enabled = false;
            audio.clip = sensorActivated;
            audio.Play();
        }
    }
}
