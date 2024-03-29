﻿var KPI_JSON =  {
    userName : "Joe User",
    roleName: "some role",
    activeLocation: 3,
    locations: [
        1,
        3,
        5,
        6
    ],
    workspaces: [
        {
            id: 1,
            KPIs: [
                {
                    title: "KPI1",
                    type: "02",
                    target: 80,
                    value: 170,
                    units: 15,
                    firstWarn: 60,
                    secondWarn: 90
                },
                {
                    title: "KPI2",
                    type: "01",
                    target: 150,
                    value: 245,
                    units: 15,
                    firstWarn: 300,
                    secondWarn: 450
                },
                {
                    title: "KPI3",
                    type: "03",
                    target: 225,
                    value: 120,
                    units: 25,
                    firstWarn: 250,
                    secondWarn: 275
                }
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "KPI4",
                    type: "04",
                    target: 200,
                    value: 180,
                    units: 20,
                    firstWarn: 180,
                    secondWarn: 190
                },
                {
                    title: "KPI5",
                    type: "03",
                    target: 170,
                    value: 105,
                    units: 30,
                    firstWarn: 150,
                    secondWarn: 160
                }
            ]
        }
    ]
 }
   