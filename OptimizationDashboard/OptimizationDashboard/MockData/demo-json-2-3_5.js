var KPI_JSON = {
    "userName": "Jane Doe",
    "roleName": "Plant Manager",
    activeLocation: "5",
    "locations": [
        3,
        5,
        6
    ],
	workspaces: [
		{
			id: 1,
			KPIs: [
                {
                    title: "YARD TIME",
                    type: "minutes",
                    target: 210,
                    units: 25,
                    firstWarn: 280,
                    secondWarn: 350
                },
                 {
                     title: "EOD YARD",
                     type: "minutes",
                     target: 360,
                     units: 19,
                     firstWarn: 450,
                     secondWarn: 540
                 },
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "FIRST LOAD",
                    type: "minutes",
                    target: 123,
                    units: 25,
                    firstWarn: 240,
                    secondWarn: 360
                },
                {
                    title: "STARTUP",
                    type: "minutes",
                    target: 500,
                    units: 43,
                    firstWarn: 700,
                    secondWarn: 900
                },
                {
                    title: "WASH OUT",
                    type: "minutes",
                    target: 280,
                    units: 43,
                    firstWarn: 420,
                    secondWarn: 560
                },
            ]
        }
    ]
}