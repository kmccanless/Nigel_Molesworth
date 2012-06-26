var KPI_JSON = {
    userName: "Jane Doe",
    roleName: "Plant Manager",
    activeLocation: "South",
    locations: [
        "Elk Lake",
        "South",
        "1",
        "2",
        "3",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "15",
        "16",
        "17",
        "18",
        "19"
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
            ]
		},
        {
            id: 2,
            KPIs: [
                {
                    title: "First Load",
                    type: "01",
                    target: 123,
                    value: 250,
                    units: 10,
                    firstWarn: 240,
                    secondWarn: 360
                },
                {
                    title: "Startup",
                    type: "01",
                    target: 500,
                    value: 850,
                    units: 43,
                    firstWarn: 700,
                    secondWarn: 900
                },
                {
                    title: "Wash Out",
                    type: "01",
                    target: 280,
                    value: 600,
                    units: 43,
                    firstWarn: 420,
                    secondWarn: 560
                },
                 {
                     title: "KPI4",
                     type: "04",
                     target: 225,
                     value: 180,
                     units: 25,
                     firstWarn: 240,
                     secondWarn: 275
                 },
                  {
                      title: "KPI5",
                      type: "02",
                      target: 225,
                      value: 130,
                      units: 250,
                      firstWarn: 250,
                      secondWarn: 275
                  }
            ]
        }
    ]
}