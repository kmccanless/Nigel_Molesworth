﻿var KPI_JSON =  {
    userName : "Joe User",
    roleName : "some role",
    locations: [
        1,
        3,
        5,
        6,
        "All"
    ],
    workspaces: [
        {
            id: "Top Row",
            KPIs: [
                {
                    title: "KPI1",
                    ordinal: 1,
                    type: "percentage",
                    target: "80",
                    units: "15",
                    firstWarn: "60",
                    secondWarn: "90"
                },
                {
                    title: "KPI2",
                    ordinal: 2,
                    type: "computed",
                    target: "130",
                    units: "10",
                    firstWarn: "120",
                    secondWarn: "125"
                },
                {
                    title: "KPI3",
                    ordinal: 3,
                    type: "subtraction",
                    target: "225",
                    units: "25",
                    firstWarn: "250",
                    secondWarn: "275"
                }
            ]
        },
        {
            id: "Bottom Row",
            KPIs: [
                {
                    title: "KPI4",
                    ordinal: 1,
                    type: "addition",
                    target: "200",
                    units: "20",
                    firstWarn: "180",
                    secondWarn: "190"
                },
                {
                    title: "KPI5",
                    ordinal: 2,
                    type: "division",
                    target: "170",
                    units: "30",
                    firstWarn: "150",
                    secondWarn: "160"
                }
            ]
        }
    ]
}