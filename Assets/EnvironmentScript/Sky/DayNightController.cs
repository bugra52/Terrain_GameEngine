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
        targetLight = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Start is called before the first frame update
    void Start()
    {
        dayTimer = targetLight.GetComponent<Light>().intensity;
    }

    // Update is called once per frame
    void Update()
    {
        targetLight.GetComponent<Light>().intensity = dayTimer -= Time.deltaTime * 0.3f;
    }
}
