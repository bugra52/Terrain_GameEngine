using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightCycleController : MonoBehaviour
{
    [Range(0, 24)]
    public float timeOfDay;

    public float orbitSpeed = 1.0f;
    public Light sun;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeOfDay += Time.deltaTime * orbitSpeed;
        if (timeOfDay > 24)
            timeOfDay = 0;


        UpdateTime();

        if (timeOfDay >= 5f || timeOfDay <= 19f)
        {
            sun.intensity = 0f;
        }
    }

    private void OnValidate()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        float alpha = timeOfDay / 24.0f;
        float sunRotation = Mathf.Lerp(-90, 270, alpha);
        sun.transform.rotation = Quaternion.Euler(sunRotation, -150.0f, 0);
    }

}
