using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{

    public enum Season { NONE, SPRING, AUTUMN, WINTER }
    public enum Weather { NONE, SUNNY, HOTSUN, RAIN, SNOW }

    public Season currentSeason;
    public Weather currentWeather;

    [Header("Time Settings")]
    public float seasonTime;
    public float springTime;
    public float summerTime;
    public float autumnTime;
    public float winterTime;

    public int currentYear;

    private void Start()
    {
        this.currentSeason = Season.SPRING;
        this.currentWeather = Weather.SUNNY;
        this.currentYear = 1;

        this.seasonTime = this.springTime;
    }

    public void ChangeSeason(Season seasonType)
    {

    }

    public void ChangeWeather(Weather weatherType)
    {

    }





}
