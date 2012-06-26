var KPI_JSON = {
    userName: "Jeff Miller",
    roleName: "Plant Manager",
    activeLocation: "AMC",
    locations: [
        "1",
        "3",
        "5",
        "6",
        "AMC",
        "7"
    ],
    workspaces: [
        {
            id: 1,
            KPIs: [
                {
                    title: "KPI1",
                    type: "02",
                    target: 15,
                    value: 10,
                    units: 20,
                    firstWarn: 20,
                    secondWarn: 30
                },
                {
                    title: "KPI2",
                    type: "01",
                    target: 130,
                    value: 140,
                    units: 10,
                    firstWarn: 120,
                    secondWarn: 125
                },
                {
                    title: "KPI3",
                    type: "01",
                    target: 300,
                    value: 720,
                    units: 10,
                    firstWarn: 450,
                    secondWarn: 900
                },
                 {
                     title: "KPI4",
                     type: "04",
                     target: 225,
                     value: 180,
                     units: 25,
                     firstWarn: 240,
                     secondWarn: 275
                 }
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "KPI1",
                    type: "02",
                    target: 200,
                    value: 104,
                    units: 200,
                    firstWarn: 200,
                    secondWarn: 50
                },
                {
                    title: "KPI2",
                    type: "01",
                    target: 170,
                    value: 160,
                    units: 2,
                    firstWarn: 150,
                    secondWarn: 160
                },
                {
                    title: "KPI3",
                    type: "03",
                    target: 170,
                    value: 130,
                    units: 100,
                    firstWarn: 150,
                    secondWarn: 160
                },
                {
                    title: "KPI4",
                    type: "04",
                    target: 170,
                    value: 140,
                    units: 30,
                    firstWarn: 150,
                    secondWarn: 160
                },
                {
                    title: "KPI5",
                    type: "02",
                    target: 25,
                    value: 30,
                    units: 50,
                    firstWarn: 30,
                    secondWarn: 50
                }
            ]
        }
    ]
}