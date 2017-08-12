﻿'use strict';

weatherSeerApp.factory('fpService',
    function fpService() {
        return {
            forecast: {
                "cod": "200",
                "message": 0.0036,
                "cnt": 40,
                "list": [
                  {
                      "dt": 1485799200,
                      "main": {
                          "temp": 261.45,
                          "temp_min": 259.086,
                          "temp_max": 261.45,
                          "pressure": 1023.48,
                          "sea_level": 1045.39,
                          "grnd_level": 1023.48,
                          "humidity": 79,
                          "temp_kf": 2.37
                      },
                      "weather": [
                        {
                            "id": 800,
                            "main": "Clear",
                            "description": "clear sky",
                            "icon": "02n"
                        }
                      ],
                      "clouds": {
                          "all": 8
                      },
                      "wind": {
                          "speed": 4.77,
                          "deg": 232.505
                      },
                      "snow": {},
                      "sys": {
                          "pod": "n"
                      },
                      "dt_txt": "2017-01-30 18:00:00"
                  },
                  {
                      "dt": 1485810000,
                      "main": {
                          "temp": 261.41,
                          "temp_min": 259.638,
                          "temp_max": 261.41,
                          "pressure": 1022.41,
                          "sea_level": 1044.35,
                          "grnd_level": 1022.41,
                          "humidity": 76,
                          "temp_kf": 1.78
                      },
                      "weather": [
                        {
                            "id": 800,
                            "main": "Clear",
                            "description": "clear sky",
                            "icon": "01n"
                        }
                      ],
                      "clouds": {
                          "all": 32
                      },
                      "wind": {
                          "speed": 4.76,
                          "deg": 240.503
                      },
                      "snow": {
                          "3h": 0.011
                      },
                      "sys": {
                          "pod": "n"
                      },
                      "dt_txt": "2017-01-30 21:00:00"
                  },
                  {
                      "dt": 1485820800,
                      "main": {
                          "temp": 261.76,
                          "temp_min": 260.571,
                          "temp_max": 261.76,
                          "pressure": 1021.34,
                          "sea_level": 1043.21,
                          "grnd_level": 1021.34,
                          "humidity": 84,
                          "temp_kf": 1.18
                      },
                      "weather": [
                        {
                            "id": 600,
                            "main": "Snow",
                            "description": "light snow",
                            "icon": "13n"
                        }
                      ],
                      "clouds": {
                          "all": 68
                      },
                      "wind": {
                          "speed": 4.71,
                          "deg": 243
                      },
                      "snow": {
                          "3h": 0.058
                      },
                      "sys": {
                          "pod": "n"
                      },
                      "dt_txt": "2017-01-31 00:00:00"
                  },
                  {
                      "dt": 1485831600,
                      "main": {
                          "temp": 261.46,
                          "temp_min": 260.865,
                          "temp_max": 261.46,
                          "pressure": 1019.95,
                          "sea_level": 1041.79,
                          "grnd_level": 1019.95,
                          "humidity": 82,
                          "temp_kf": 0.59
                      },
                      "weather": [
                        {
                            "id": 600,
                            "main": "Snow",
                            "description": "light snow",
                            "icon": "13n"
                        }
                      ],
                      "clouds": {
                          "all": 68
                      },
                      "wind": {
                          "speed": 4.46,
                          "deg": 244.5
                      },
                      "snow": {
                          "3h": 0.05225
                      },
                      "sys": {
                          "pod": "n"
                      },
                      "dt_txt": "2017-01-31 03:00:00"
                  },
                  {
                      "dt": 1485842400,
                      "main": {
                          "temp": 260.981,
                          "temp_min": 260.981,
                          "temp_max": 260.981,
                          "pressure": 1018.96,
                          "sea_level": 1040.84,
                          "grnd_level": 1018.96,
                          "humidity": 81,
                          "temp_kf": 0
                      },
                      "weather": [
                        {
                            "id": 600,
                            "main": "Snow",
                            "description": "light snow",
                            "icon": "13d"
                        }
                      ],
                      "clouds": {
                          "all": 80
                      },
                      "wind": {
                          "speed": 4.21,
                          "deg": 245.005
                      },
                      "snow": {
                          "3h": 0.19625
                      },
                      "sys": {
                          "pod": "d"
                      },
                      "dt_txt": "2017-01-31 06:00:00"
                  },
                ],
                "city": {
                    "id": 524901,
                    "name": "Moscow",
                    "coord": {
                        "lat": 55.7522,
                        "lon": 37.6156
                    },
                    "country": "none"
                },
                cityOptions: [
                    {
                        "id": 707860,
                        "name": "Hurzuf",
                        "country": "UA",
                        "coord": {
                            "lon": 34.283333,
                            "lat": 44.549999
                        }
                    },
                    {
                        "id": 519188,
                        "name": "Novinki",
                        "country": "RU",
                        "coord": {
                            "lon": 37.666668,
                            "lat": 55.683334
                        }
                    },
                    {
                        "id": 1283378,
                        "name": "Gorkhā",
                        "country": "NP",
                        "coord": {
                            "lon": 84.633331,
                            "lat": 28
                        }
                    },
                ]
            },
        }
    });