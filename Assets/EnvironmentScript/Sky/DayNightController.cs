using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{

    public GameObject targetLight;
    public GameObject targetMainCamera;
    public Material[] skys;
    public float dayTimer;
    public bool isCycle;

    private void Awake()
    {
        targetLight = GameObject.FindGameObjectWithTag("Light");
        targetMainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Start is called before the first frame update
    void Start()
    {
        dayTimer = targetLight.GetComponent<Light>().intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isCycle)
        {
            targetLight.GetComponent<Light>().intensity = dayTimer -= Time.deltaTime * 0.01f;
            if (dayTimer <= 0)
            {
                isCycle = true; 
            }
        }

        else if (isCycle)
        {
            targetLight.GetComponent<Light>().intensity = dayTimer += Time.deltaTime * 0.01f;
            if (dayTimer >= 1)
            {
                isCycle = false;
            }
        }
        ChangeCycle();
    }

    void ChangeCycle()
    {
        if(dayTimer >= 0.9f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[0];
        }
        else if(dayTimer >= 0.5f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[1];
        }
        else if (dayTimer >= 0.3f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[2];
        }
        else if (dayTimer >= 0.1f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[3];
        }
    }
}
