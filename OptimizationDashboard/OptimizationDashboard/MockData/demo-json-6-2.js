var KPI_JSON = {
    userName: "Joe User",
    roleName: "Plant Manager",
    activeLocation: "All",
    locations: [
        "HighPlantSouthWest",
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
                    title: "KPI2",
                    type: "02",
                    target: 200,
                    value: 104,
                    units: 200,
                    firstWarn: 200,
                    secondWarn: 50
                },
                {
                    title: "KPI3",
                    type: "04",
                    target: 170,
                    value: 140,
                    units: 30,
                    firstWarn: 150,
                    secondWarn: 160
                },
                {
                    title: "KPI4",
                    type: "02",
                    target: 25,
                    value: 30,
                    units: 50,
                    firstWarn: 30,
                    secondWarn: 50
                },
                {
                    title: "KPI5",
                    type: "04",
                    target: 170,
                    value: 140,
                    units: 30,
                    firstWarn: 150,
                    secondWarn: 160
                },
                {
                    title: "KPI6",
                    type: "02",
                    target: 25,
                    value: 30,
                    units: 50,
                    firstWarn: 30,
                    secondWarn: 50
                },
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
                    type: "04",
                    target: 170,
                    value: 140,
                    units: 30,
                    firstWarn: 150,
                    secondWarn: 160
                },
            ]
        }
    ]
}