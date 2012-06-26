var KPI_JSON = {
    userName: "Joe User",
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
                    title: "KPI1 GREEN",
                    type: "01",
                    target: 150,
                    value: 245,
                    units: 15,
                    firstWarn: 300,
                    secondWarn: 450
                },
                {
                    title: "KPI1 YELLOW",
                    type: "01",
                    target: 250,
                    value: 375,
                    units: 15,
                    firstWarn: 300,
                    secondWarn: 450
                },
                {
                    title: "KPI1 RED",
                    type: "01",
                    target: 120,
                    value: 285,
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
                    title: "KPI1 YELLOW ",
                    type: "01",
                    target: 150,
                    value: 180,
                    units: 20,
                    firstWarn: 180,
                    secondWarn: 190
                },
                {
                    title: "KPI5 RED",
                    type: "01",
                    target: 140,
                    value: 160,
                    units: 30,
                    firstWarn: 150,
                    secondWarn: 160
                }
            ]
        }
    ]
}
   