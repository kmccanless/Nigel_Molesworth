var KPI_JSON = {
    userName: "Joe User",
    roleName: "some role",
    activeLocation: "All",
    locations: [
        "1",
        "3",
        "5",
        "6"
    ],
    workspaces: [
        {
            id: 1,
            KPIs: [
                {
                    title: "Yard Time",
                    type: "02",
                    target: 15,
                    value: 10,
                    units: 20,
                    firstWarn: 20,
                    secondWarn: 30
                },
                {
                    title: "First Load",
                    type: "01",
                    target: 130,
                    value: 140,
                    units: 10,
                    firstWarn: 120,
                    secondWarn: 125
                },
                {
                    title: "Startup",
                    type: "01",
                    target: 300,
                    value: 720,
                    units: 10,
                    firstWarn: 450,
                    secondWarn: 900
                },
                 {
                     title: "Wash Out",
                     type: "04",
                     target: 225,
                     value: 180,
                     units: 25,
                     firstWarn: 240,
                     secondWarn: 275
                 },
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "Time to Leave",
                    type: "02",
                    target: 200,
                    value: 104,
                    units: 200,
                    firstWarn: 200,
                    secondWarn: 50
                },
            ]
        }
    ]
}