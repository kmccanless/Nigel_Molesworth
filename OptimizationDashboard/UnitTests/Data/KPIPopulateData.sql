/* Insert Plants */
INSERT INTO plnt (plant_code,name)
VALUES ('  1', 'Plant 1')
GO
INSERT INTO plnt (plant_code,name)
VALUES ('  2', 'Plant 2')
GO
INSERT INTO plnt (plant_code,name)
VALUES ('  3', 'Plant 3')
GO
INSERT INTO plnt (plant_code,name)
VALUES ('  5', 'Plant 5')
GO
INSERT INTO plnt (plant_code,name)
VALUES ('  6', 'Plant 6')
GO
INSERT INTO plnt (plant_code,name)
VALUES ('  7', 'Plant 7')
GO
INSERT INTO plnt (plant_code,name)
VALUES ('  8', 'Plant 8')
GO

/* Insert KPIs */
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '001',	'FIRST LOAD', 	'01',	current_timestamp,	'!')
GO
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '002',	'JOB WAIT',	'01',	current_timestamp,	'!')
GO
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '003',	'YARD TIME', 	'01',	current_timestamp,	'!')
GO
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '004',	'End Of Day Yard Time',	'01',	current_timestamp,	'!')
GO
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '005',	'TOTAL COMPLIANCE',  	'02',	current_timestamp,	'!')
GO
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '006',	'LOCKED LOADS',      	'02',	current_timestamp,	'!')
GO
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '007',	'Punch In to In Servi',	'01',	current_timestamp,	'!')
GO
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '008',	'Print to To Job',     	'01',	current_timestamp,	'!')
GO
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '009',	'Wash to Clock Out',   	'01',	current_timestamp,	'!')
GO
INSERT INTO kpis (kpi_code,kpi_display_label,kpi_display_cat,update_date,u_version)
VALUES ( '010',	'Status Updates %',    	'02',	current_timestamp,	'!')
GO

/* Insert KPI Targets */
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '001', '  1', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '001', '  2', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '001', '  3', 150, 300, 450, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '001', '  5', 120, 240, 360, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '001', '  6', 60, 120, 180, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '001', '  7', 40, 80, 120, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '001', '  8', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '002', '  1', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '002', '  2', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '002', '  3', 120, 180, 240, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '002', '  5', 168, 252, 336, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '002', '  6', 80, 120, 160, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '002', '  7', 48, 72, 96, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '002', '  8', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '003', '  1', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '003', '  2', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '003', '  3', 180, 240, 300, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '003', '  5', 210, 280, 350, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '003', '  6', 120, 160, 200, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '003', '  7', 90, 120, 150, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '003', '  8', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '004', '  1', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '004', '  2', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '004', '  3', 210, 280, 350, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '004', '  5', 360, 450, 540, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '004', '  6', 144, 216, 288, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '004', '  7', 150, 200, 250, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '004', '  8', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '005', '  1', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '005', '  2', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '005', '  3', 54, 51, 48, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '005', '  5', 58.5, 55.3, 52, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '005', '  6', 49.5, 46.8, 44, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '005', '  7', 45, 42.5, 40, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '005', '  8', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '006', '  1', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '006', '  2', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '006', '  3', 3, 6, 9, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '006', '  5', 3.3, 6.5, 9.8, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '006', '  6', 2.8, 5.5, 8.3, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '006', '  7', 2.4, 4.8, 7.2, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '006', '  8', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '007', '  1', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '007', '  2', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '007', '  3', 320, 480, 640, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '007', '  5', 500, 700, 900, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '007', '  6', 300, 450, 600, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '007', '  7', 540, 720, 900, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '007', '  8', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '008', '  1', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '008', '  2', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '008', '  3', 252, 325, 360, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '008', '  5', 264, 352, 440, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '008', '  6', 315, 420, 525, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '008', '  7', 210, 270, 300, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '008', '  8', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '009', '  1', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '009', '  2', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '009', '  3', 240, 360, 480, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '009', '  5', 280, 420, 560, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '009', '  6', 160, 240, 320, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '009', '  7', 180, 270, 360, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '009', '  8', 5, 5, 5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '010', '  1', 57, 54, 51, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '010', '  2', 57, 54, 51, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '010', '  3', 57, 54, 51, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '010', '  5', 61.8, 58.5, 55.3, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '010', '  6', 52.3, 48.5, 46.8, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '010', '  7', 47.5, 45, 42.5, current_timestamp, '!')
GO
INSERT INTO kpit (kpi_code,plant_code,target,warning_l1,warning_l2,update_date,u_version)
VALUES ( '010', '  8', 57, 54, 51, current_timestamp, '!')
GO

/* Insert KPI Roles */
INSERT INTO kpir (kpi_role_name,kpi_codes,kpi_display_codes,kpi_display_timers,update_date,u_version)
VALUES ('Role1', '001|003|004|005', 'A1|A2|A3|B1', '00:00-23:59|00:00-23:59||', current_timestamp, '#')
GO
INSERT INTO kpir (kpi_role_name,kpi_codes,kpi_display_codes,kpi_display_timers,update_date,u_version)
VALUES ('Role2', '001|002|003|005|006', 'B1|B2|B3|A1|A2', '00:00-23:59|00:00-23:59|00:00-23:59|00:00-23:59|00:00-23:59', current_timestamp, '#')
GO

/* Insert Users */
INSERT INTO usnm (user_name,kpi_role_name,kpi_plants)
VALUES ('user1', 'Role1', '  1|  2|  3|  5|  6|  7|  8|')
GO
INSERT INTO usnm (user_name,kpi_role_name,kpi_plants)
VALUES ('user2', 'Role2', '  3|  5|  6|  7|')
GO

/* Insert Operational KPIs */
    /* Plant 3 */       
INSERT INTO okpi (unique_num,record_date,plant_code,first_load_mins,first_load_units,first_load_target,first_load_warn_1,first_load_warn_2,job_wait_mins,job_wait_units,job_wait_target,job_wait_warn_1,job_wait_warn_2,yard_time_mins,yard_time_units,yard_time_target,yard_time_warn_1,yard_time_warn_2,eod_yard_mins,eod_yard_units,eod_yard_target,eod_yard_warn_1,eod_yard_warn_2,truck_compliance_points,load_time_compliance_points,ret_plant_compliance_points,total_avail_compliance_points,compliance_target,compliance_warn_1,compliance_warn_2,loads_locked,loads_scheduled,loads_locked_target,loads_locked_warn_1,loads_locked_warn_2,startup_mins,startup_units,startup_target,startup_warn_1,startup_warn_2,load_mins,load_units,load_target,load_warn_1,load_warn_2,wash_out_mins,wash_out_units,wash_out_target,wash_out_warn_1,wash_out_warn_2,auto_status_updates,total_status_updates,auto_status_target,auto_status_warn_1,auto_status_warn_2)
VALUES ( 1, '13-JUN-2012 3:45PM', '  3'
           ,240,15,150,300,450		--001
           ,180,12,120,180,240		--002
           ,230,12,180,240,300		--003
           ,305,14,210,280,350		--004
           ,45,55,47,60,54,51,48	--005
           ,8,60,3,6,9				--006
           ,490,16,320,480,640		--007
           ,370,18,252,324,360		--008
           ,340,12,240,360,480		--009
           ,62,60,57,54,51			--010
)
GO
INSERT INTO okpi (unique_num,record_date,plant_code,first_load_mins,first_load_units,first_load_target,first_load_warn_1,first_load_warn_2,job_wait_mins,job_wait_units,job_wait_target,job_wait_warn_1,job_wait_warn_2,yard_time_mins,yard_time_units,yard_time_target,yard_time_warn_1,yard_time_warn_2,eod_yard_mins,eod_yard_units,eod_yard_target,eod_yard_warn_1,eod_yard_warn_2,truck_compliance_points,load_time_compliance_points,ret_plant_compliance_points,total_avail_compliance_points,compliance_target,compliance_warn_1,compliance_warn_2,loads_locked,loads_scheduled,loads_locked_target,loads_locked_warn_1,loads_locked_warn_2,startup_mins,startup_units,startup_target,startup_warn_1,startup_warn_2,load_mins,load_units,load_target,load_warn_1,load_warn_2,wash_out_mins,wash_out_units,wash_out_target,wash_out_warn_1,wash_out_warn_2,auto_status_updates,total_status_updates,auto_status_target,auto_status_warn_1,auto_status_warn_2)
VALUES ( 2, '13-JUN-2012 3:50PM', '  3'
           ,245,15,150,300,450		--001
           ,185,12,120,180,240		--002
           ,240,12,180,240,300		--003
           ,355,14,210,280,350		--004
           ,50,55,47,60,54,51,48	--005
           ,7,60,3,6,9				--006
           ,470,16,320,480,640		--007
           ,350,18,252,324,360		--008
           ,390,12,240,360,480		--009
           ,56,60,57,54,51			--010
)
GO
    /* Plant 5 */       
INSERT INTO okpi (unique_num,record_date,plant_code,first_load_mins,first_load_units,first_load_target,first_load_warn_1,first_load_warn_2,job_wait_mins,job_wait_units,job_wait_target,job_wait_warn_1,job_wait_warn_2,yard_time_mins,yard_time_units,yard_time_target,yard_time_warn_1,yard_time_warn_2,eod_yard_mins,eod_yard_units,eod_yard_target,eod_yard_warn_1,eod_yard_warn_2,truck_compliance_points,load_time_compliance_points,ret_plant_compliance_points,total_avail_compliance_points,compliance_target,compliance_warn_1,compliance_warn_2,loads_locked,loads_scheduled,loads_locked_target,loads_locked_warn_1,loads_locked_warn_2,startup_mins,startup_units,startup_target,startup_warn_1,startup_warn_2,load_mins,load_units,load_target,load_warn_1,load_warn_2,wash_out_mins,wash_out_units,wash_out_target,wash_out_warn_1,wash_out_warn_2,auto_status_updates,total_status_updates,auto_status_target,auto_status_warn_1,auto_status_warn_2)
VALUES ( 3, '13-JUN-2012 3:45PM', '  5'
           ,255,10,120,240,360	--001
           ,150,14,168,252,336	--002
           ,273,14,210,280,350	--003
           ,340,18,360,450,540	--004
           ,59,52,56,65,59,55,52	--005
           ,2,65,3.3,6.5,9.8	--006
           ,875,20,500,700,900	--007
           ,248,22,264,352,440	--008
           ,640,14,280,420,560	--009
           ,57,65,61.8,58.5,55.3	--010
)
GO
INSERT INTO okpi (unique_num,record_date,plant_code,first_load_mins,first_load_units,first_load_target,first_load_warn_1,first_load_warn_2,job_wait_mins,job_wait_units,job_wait_target,job_wait_warn_1,job_wait_warn_2,yard_time_mins,yard_time_units,yard_time_target,yard_time_warn_1,yard_time_warn_2,eod_yard_mins,eod_yard_units,eod_yard_target,eod_yard_warn_1,eod_yard_warn_2,truck_compliance_points,load_time_compliance_points,ret_plant_compliance_points,total_avail_compliance_points,compliance_target,compliance_warn_1,compliance_warn_2,loads_locked,loads_scheduled,loads_locked_target,loads_locked_warn_1,loads_locked_warn_2,startup_mins,startup_units,startup_target,startup_warn_1,startup_warn_2,load_mins,load_units,load_target,load_warn_1,load_warn_2,wash_out_mins,wash_out_units,wash_out_target,wash_out_warn_1,wash_out_warn_2,auto_status_updates,total_status_updates,auto_status_target,auto_status_warn_1,auto_status_warn_2)
VALUES ( 4, '13-JUN-2012 3:50PM', '  5'
           ,250,10,120,240,360	--001
           ,250,14,168,252,336	--002
           ,350,14,210,280,350	--003
           ,350,18,360,450,540	--004
           ,54,52,56,65,59,55,52	--005
           ,4,65,4,7,10	--006
           ,850,20,500,700,900	--007
           ,280,22,264,352,440	--008
           ,600,14,280,420,560	--009
           ,54,65,62,59,55	--010
)
GO
    /* Plant 6 */       
INSERT INTO okpi (unique_num,record_date,plant_code,first_load_mins,first_load_units,first_load_target,first_load_warn_1,first_load_warn_2,job_wait_mins,job_wait_units,job_wait_target,job_wait_warn_1,job_wait_warn_2,yard_time_mins,yard_time_units,yard_time_target,yard_time_warn_1,yard_time_warn_2,eod_yard_mins,eod_yard_units,eod_yard_target,eod_yard_warn_1,eod_yard_warn_2,truck_compliance_points,load_time_compliance_points,ret_plant_compliance_points,total_avail_compliance_points,compliance_target,compliance_warn_1,compliance_warn_2,loads_locked,loads_scheduled,loads_locked_target,loads_locked_warn_1,loads_locked_warn_2,startup_mins,startup_units,startup_target,startup_warn_1,startup_warn_2,load_mins,load_units,load_target,load_warn_1,load_warn_2,wash_out_mins,wash_out_units,wash_out_target,wash_out_warn_1,wash_out_warn_2,auto_status_updates,total_status_updates,auto_status_target,auto_status_warn_1,auto_status_warn_2)
VALUES ( 5, '13-JUN-2012 3:45PM', '  6'
           ,310,6,60,120,180	--001
           ,330,8,80,120,160	--002
           ,112,8,120,160,200	--003
           ,245,12,144,216,288	--004
           ,47,41,40,55,49.5,46.8,44	--005
           ,19,55,2.8,5.5,8.3	--006
           ,650,15,300,450,600	--007
           ,357,21,315,420,525	--008
           ,359,8,160,240,320	--009
           ,45,55,52.3,49.5,46.8	--010
)
GO
INSERT INTO okpi (unique_num,record_date,plant_code,first_load_mins,first_load_units,first_load_target,first_load_warn_1,first_load_warn_2,job_wait_mins,job_wait_units,job_wait_target,job_wait_warn_1,job_wait_warn_2,yard_time_mins,yard_time_units,yard_time_target,yard_time_warn_1,yard_time_warn_2,eod_yard_mins,eod_yard_units,eod_yard_target,eod_yard_warn_1,eod_yard_warn_2,truck_compliance_points,load_time_compliance_points,ret_plant_compliance_points,total_avail_compliance_points,compliance_target,compliance_warn_1,compliance_warn_2,loads_locked,loads_scheduled,loads_locked_target,loads_locked_warn_1,loads_locked_warn_2,startup_mins,startup_units,startup_target,startup_warn_1,startup_warn_2,load_mins,load_units,load_target,load_warn_1,load_warn_2,wash_out_mins,wash_out_units,wash_out_target,wash_out_warn_1,wash_out_warn_2,auto_status_updates,total_status_updates,auto_status_target,auto_status_warn_1,auto_status_warn_2)
VALUES ( 6, '13-JUN-2012 3:50PM', '  6'
           ,300,6,60,120,180	--001
           ,300,8,80,120,160	--002
           ,120,8,120,160,200	--003
           ,250,12,144,216,288	--004
           ,42,41,40,55,50,47,44	--005
           ,9,55,3,6,8	--006
           ,605,15,300,450,600	--007
           ,375,21,315,420,525	--008
           ,375,8,160,240,320	--009
           ,55,55,52,50,47	--010
)
GO
    /* Plant 7 */       
INSERT INTO okpi (unique_num,record_date,plant_code,first_load_mins,first_load_units,first_load_target,first_load_warn_1,first_load_warn_2,job_wait_mins,job_wait_units,job_wait_target,job_wait_warn_1,job_wait_warn_2,yard_time_mins,yard_time_units,yard_time_target,yard_time_warn_1,yard_time_warn_2,eod_yard_mins,eod_yard_units,eod_yard_target,eod_yard_warn_1,eod_yard_warn_2,truck_compliance_points,load_time_compliance_points,ret_plant_compliance_points,total_avail_compliance_points,compliance_target,compliance_warn_1,compliance_warn_2,loads_locked,loads_scheduled,loads_locked_target,loads_locked_warn_1,loads_locked_warn_2,startup_mins,startup_units,startup_target,startup_warn_1,startup_warn_2,load_mins,load_units,load_target,load_warn_1,load_warn_2,wash_out_mins,wash_out_units,wash_out_target,wash_out_warn_1,wash_out_warn_2,auto_status_updates,total_status_updates,auto_status_target,auto_status_warn_1,auto_status_warn_2)
VALUES ( 7, '13-JUN-2012 3:45PM', '  7'
           ,79,5,40,80,120		--001
           ,110,6,48,72,96		--002
           ,140,6,90,120,150	--003
           ,160,10,150,200,250	--004
           ,31,38,32,50,45,42.5,40	--005
           ,5,48,2.4,4.8,7.2	--006
           ,590,18,540,720,900	--007
           ,358,15,210,270,300	--008
           ,258,9,180,270,360	--009
           ,35,50,47.5,45,42.5	--010
)
GO
INSERT INTO okpi (unique_num,record_date,plant_code,first_load_mins,first_load_units,first_load_target,first_load_warn_1,first_load_warn_2,job_wait_mins,job_wait_units,job_wait_target,job_wait_warn_1,job_wait_warn_2,yard_time_mins,yard_time_units,yard_time_target,yard_time_warn_1,yard_time_warn_2,eod_yard_mins,eod_yard_units,eod_yard_target,eod_yard_warn_1,eod_yard_warn_2,truck_compliance_points,load_time_compliance_points,ret_plant_compliance_points,total_avail_compliance_points,compliance_target,compliance_warn_1,compliance_warn_2,loads_locked,loads_scheduled,loads_locked_target,loads_locked_warn_1,loads_locked_warn_2,startup_mins,startup_units,startup_target,startup_warn_1,startup_warn_2,load_mins,load_units,load_target,load_warn_1,load_warn_2,wash_out_mins,wash_out_units,wash_out_target,wash_out_warn_1,wash_out_warn_2,auto_status_updates,total_status_updates,auto_status_target,auto_status_warn_1,auto_status_warn_2)
VALUES ( 8, '13-JUN-2012 3:50PM', '  7'
           ,90,5,40,80,120		--001
           ,100,6,48,72,96		--002
           ,150,6,90,120,150	--003
           ,170,10,150,200,250	--004
           ,36,38,32,50,45,42,40	--005
           ,2,48,2,5,7	--006
           ,590,18,540,720,900	--007
           ,325,15,210,270,300	--008
           ,280,9,180,270,360	--009
           ,45,50,48,45,43	--010
)           
GO
