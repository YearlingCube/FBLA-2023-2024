using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    Camera camera; // set this via inspector
    [SerializeField]
    public float shake = 0;
    [SerializeField]
    float shakeAmount = 0.7f;

 
    void Update()
    {
        if (shake > 0)
        {
            camera.transform.localPosition = Random.insideUnitSphere * shakeAmount;
            camera.transform.localPosition = new Vector3(camera.transform.localPosition.x, camera.transform.localPosition.y, -10);
        }else
        {
            camera.transform.localPosition = new Vector3(0, 0, -10);
        }
    }

}
