var KPI_JSON = {
    userName: "Joe User",
    roleName: "some role",
    activeLocation: "All",
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
                    value: 100,
                    units: 3,
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
            ]
        }
    ]
}