var KPI_JSON = {
    userName: "Joe User",
    roleName: "KPI5 Checker",
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
                    title: "KPI5 GREEN",
                    type: "02",
                    target: 54,
                    value: 57,
                    units: 60,
                    firstWarn: 51,
                    secondWarn: 48
                },
                {
                    title: "KPI5 YELLOW",
                    type: "02",
                    target: 70,
                    value: 53,
                    units: 80,
                    firstWarn: 55,
                    secondWarn: 52
                },
                {
                    title: "KPI5 RED",
                    type: "02",
                    target: 55,
                    value: 39,
                    units: 65,
                    firstWarn: 42,
                    secondWarn: 40
                }
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "KPI5 YELLOW",
                    type: "02",
                    target: 55,
                    value: 42,
                    units: 70,
                    firstWarn: 42,
                    secondWarn: 40
                },
                {
                    title: "KPI5 RED",
                    type: "02",
                    target: 55,
                    value: 40,
                    units: 60,
                    firstWarn: 42,
                    secondWarn: 40
                }
            ]
        }
    ]
}
   