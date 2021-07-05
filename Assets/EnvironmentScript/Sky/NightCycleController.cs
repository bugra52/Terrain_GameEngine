using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightCycleController : MonoBehaviour
{
    [Range(0, 24)]
    public float timeOfDay2;

    public float orbitSpeed = 1.0f;
    public Light moon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeOfDay2 += Time.deltaTime * orbitSpeed;
        if (timeOfDay2 > 24)
            timeOfDay2 = 0;


        UpdateTime();


        if (timeOfDay2 <= 7f || timeOfDay2 >=17f)
        {
            moon.intensity = 0f;
        }
    }

    private void OnValidate()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        float alpha = timeOfDay2 / 24.0f;
        float moonRotation = Mathf.Lerp(-90, 270, alpha);
        moon.transform.rotation = Quaternion.Euler(moonRotation, -150.0f, 0);
    }

}
