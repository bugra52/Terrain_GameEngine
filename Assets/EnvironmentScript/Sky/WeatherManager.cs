using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{

    public enum Season { NONE, SPRING, SUMMER, AUTUMN, WINTER }
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
        if (seasonType != this.currentSeason)
        {
            switch (seasonType)
            {
                case Season.SPRING:
                    currentSeason = Season.SPRING;
                    break;
                case Season.SUMMER:
                    currentSeason = Season.SUMMER;
                    break;
                case Season.AUTUMN:
                    currentSeason = Season.AUTUMN;
                    break;
                case Season.WINTER:
                    currentSeason = Season.WINTER;
                    break;
            }
        }
    }

    public void ChangeWeather(Weather weatherType)
    {
        if (weatherType != this.currentWeather)
        {
            switch (weatherType)
            {
                case Weather.SUNNY:
                    currentWeather = Weather.SUNNY;
                    break;
                case Weather.HOTSUN:
                    currentWeather = Weather.HOTSUN;
                    break;
                case Weather.RAIN:
                    currentWeather = Weather.RAIN;
                    break;
                case Weather.SNOW:
                    currentWeather = Weather.SNOW;
                    break;
            }
        }
    }

    private void Update()
    {
        this.seasonTime -= Time.deltaTime;

        if(this.currentSeason == Season.SPRING)
        {
            ChangeWeather(Weather.SUNNY);

            if(this.seasonTime <= 0f)
            {
                ChangeSeason(Season.SUMMER);
                this.seasonTime = this.summerTime;
            }
        }
        if (this.currentSeason == Season.SUMMER)
        {
            ChangeWeather(Weather.HOTSUN);

            if (this.seasonTime <= 0f)
            {
                ChangeSeason(Season.AUTUMN);
                this.seasonTime = this.summerTime;
            }
        }
        if (this.currentSeason == Season.AUTUMN)
        {
            ChangeWeather(Weather.RAIN);

            if (this.seasonTime <= 0f)
            {
                ChangeSeason(Season.WINTER);
                this.seasonTime = this.summerTime;
            }
        }
        if (this.currentSeason == Season.WINTER)
        {
            ChangeWeather(Weather.SNOW);

            if (this.seasonTime <= 0f)
            {
                ChangeSeason(Season.SPRING);
                this.seasonTime = this.summerTime;
            }
        }
    }





}
