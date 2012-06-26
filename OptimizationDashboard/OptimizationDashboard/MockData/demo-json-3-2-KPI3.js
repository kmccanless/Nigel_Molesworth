var KPI_JSON = {
    userName: "Joe User",
    roleName: "KPI3 Checker",
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
                    title: "KPI3 GREEN",
                    type: "01",
                    target: 120,
                    value: 120,
                    units: 8,
                    firstWarn: 160,
                    secondWarn: 200
                },
                {
                    title: "KPI3 YELLOW",
                    type: "01",
                    target: 180,
                    value: 270,
                    units: 12,
                    firstWarn: 240,
                    secondWarn: 300
                },
                {
                    title: "KPI3 RED",
                    type: "01",
                    target: 90,
                    value: 160,
                    units: 6,
                    firstWarn: 120,
                    secondWarn: 150
                }
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "KPI3 YELLOW",
                    type: "01",
                    target: 180,
                    value: 240,
                    units: 12,
                    firstWarn: 240,
                    secondWarn: 300
                },
                {
                    title: "KPI3 RED",
                    type: "01",
                    target: 90,
                    value: 150,
                    units: 6,
                    firstWarn: 120,
                    secondWarn: 150
                }
            ]
        }
    ]
}
   