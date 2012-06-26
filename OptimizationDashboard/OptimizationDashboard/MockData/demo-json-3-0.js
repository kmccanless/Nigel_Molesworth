﻿var KPI_JSON = {
    userName: "Jane Doe",
    roleName: "Plant Manager",
    activeLocation: "5",
    locations: [
        "3",
        "5",
        "6"
    ],
    workspaces: [
		{
		    id: 1,
		    KPIs: [
                {
                    title: "YARD TIME",
                    type: "01",
                    target: 210,
                    value: 350,
                    units: 14,
                    firstWarn: 280,
                    secondWarn: 350
                },
                 {
                     title: "EOD Yard",
                     type: "01",
                     target: 360,
                     value: 350,
                     units: 18,
                     firstWarn: 450,
                     secondWarn: 540
                 },
                {
                    title: "First Load",
                    type: "01",
                    target: 123,
                    value: 250,
                    units: 10,
                    firstWarn: 240,
                    secondWarn: 360
                },
            ]
		},
        {
            id: 2,
            KPIs: [
            ]
        }
    ]
}