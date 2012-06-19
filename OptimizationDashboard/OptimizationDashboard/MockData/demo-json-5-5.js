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
                    title: "KPI1",
                    type: "Percentage",
                    target: 15,
                    value: 10,
                    units: 20,
                    firstWarn: 20,
                    secondWarn: 30
                },
                {
                    title: "KPI2",
                    type: "Minutes",
                    target: 130,
                    value: 140,
                    units: 10,
                    firstWarn: 120,
                    secondWarn: 125
                },
                {
                    title: "KPI3",
                    type: "Minutes",
                    target: 300,
                    value: 720,
                    units: 10,
                    firstWarn: 450,
                    secondWarn: 900
                },
                 {
                     title: "KPI4",
                     type: "Quantity",
                     target: 225,
                     value: 180,
                     units: 25,
                     firstWarn: 240,
                     secondWarn: 275
                 },
                  {
                      title: "KPI5",
                      type: "Percentage",
                      target: 225,
                      value: 130,
                      units: 250,
                      firstWarn: 250,
                      secondWarn: 275
                  }
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "KPI1",
                    type: "Percentage",
                    target: 200,
                    value: 104,
                    units: 200,
                    firstWarn: 200,
                    secondWarn: 50
                },
                {
                    title: "KPI2",
                    type: "Minutes",
                    target: 170,
                    value: 100,
                    units: 3,
                    firstWarn: 150,
                    secondWarn: 160
                },
                {
                    title: "KPI3",
                    type: "Amount",
                    target: 170,
                    value: 130,
                    units: 100,
                    firstWarn: 150,
                    secondWarn: 160
                },
                {
                    title: "KPI4",
                    type: "Quantity",
                    target: 170,
                    value: 140,
                    units: 30,
                    firstWarn: 150,
                    secondWarn: 160
                },
                {
                    title: "KPI5",
                    type: "Percentage",
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