var KPI_JSON =  {
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
                    type: "percentage",
                    target: "80",
                    value: 170,
                    units: "15",
                    firstWarn: "60",
                    secondWarn: "90"
                },
                {
                    title: "KPI2",
                    type: "computed",
                    target: "130",
                    value: 120,
                    units: "10",
                    firstWarn: "120",
                    secondWarn: "125"
                },
                {
                    title: "KPI3",
                    type: "subtraction",
                    target: "225",
                    value: 120,
                    units: "25",
                    firstWarn: "250",
                    secondWarn: "275"
                }
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "KPI4",
                    type: "addition",
                    target: "200",
                    value: 180,
                    units: "20",
                    firstWarn: "180",
                    secondWarn: "190"
                },
                {
                    title: "KPI5",
                    type: "division",
                    target: "170",
                    value: 105,
                    units: "30",
                    firstWarn: "150",
                    secondWarn: "160"
                }
            ]
        }
    ]
 }
    

﻿