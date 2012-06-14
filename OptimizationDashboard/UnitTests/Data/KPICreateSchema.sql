/****** Object:  Table [dbo].[plnt]    Script Date: 06/08/2012 10:16:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING OFF
GO

CREATE TABLE [dbo].[plnt](
	[plant_code] [char](3) NOT NULL,
	[addr_line_1] [char](40) NULL,
	[addr_line_2] [char](40) NULL,
	[addr_line_3] [char](40) NULL,
	[air_trim_pct] [numeric](7, 3) NULL,
	[max_batch_size] [numeric](6, 2) NULL,
	[max_batch_size_uom] [char](5) NULL,
	[calcm_trim_pct] [numeric](7, 3) NULL,
	[comp_code] [char](4) NULL,
	[tkting_dev_type] [numeric](2, 0) NULL,
	[tkting_mgr_num] [numeric](3, 0) NULL,
	[tkting_port_num] [numeric](2, 0) NULL,
	[tkting_sel_addr] [numeric](2, 0) NULL,
	[tkting_doc_fmt_code] [char](8) NULL,
	[tkting_auto_dial_flag] [bit] NULL,
	[tkting_modem_phone_num] [char](14) NULL,
	[tkting_modem_code] [char](8) NULL,
	[tkting_tcp_ip_listen_port] [numeric](5, 0) NULL,
	[disptch_copy_flag] [bit] NULL,
	[disptch_mgr_num] [numeric](3, 0) NULL,
	[disptch_port_num] [numeric](2, 0) NULL,
	[disptch_sel_addr] [numeric](2, 0) NULL,
	[disptch_doc_fmt_code] [char](8) NULL,
	[disptch_auto_dial_flag] [bit] NULL,
	[disptch_modem_phone_num] [char](14) NULL,
	[disptch_modem_code] [char](8) NULL,
	[rpting_flag] [bit] NULL,
	[rpting_mgr_num] [numeric](3, 0) NULL,
	[rpting_port_num] [numeric](2, 0) NULL,
	[rpting_sel_addr] [numeric](2, 0) NULL,
	[rpting_auto_dial_flag] [bit] NULL,
	[rpting_modem_phone_num] [char](14) NULL,
	[rpting_modem_code] [char](8) NULL,
	[order_print_flag] [bit] NULL,
	[order_print_mgr_num] [numeric](3, 0) NULL,
	[order_print_port_num] [numeric](2, 0) NULL,
	[order_print_sel_addr] [numeric](2, 0) NULL,
	[order_print_doc_fmt_code] [char](8) NULL,
	[order_print_auto_dial_flag] [bit] NULL,
	[order_print_modem_phone_num] [char](14) NULL,
	[order_print_modem_code] [char](8) NULL,
	[driv_lead_time] [numeric](4, 0) NULL,
	[next_tkt_seq] [char](3) NULL,
	[next_order_seq] [char](3) NULL,
	[next_invc_seq] [char](3) NULL,
	[plant_load_time] [numeric](4, 0) NULL,
	[name] [char](40) NOT NULL,
	[phone_num] [char](14) NULL,
	[short_name] [char](8) NULL,
	[super_plast_trim_pct] [numeric](7, 3) NULL,
	[tax_code] [char](3) NULL,
	[terms_code] [char](3) NULL,
	[plant_washdown_time] [numeric](4, 0) NULL,
	[job_washdown_time] [numeric](4, 0) NULL,
	[water_trim_pct] [numeric](7, 3) NULL,
	[batch_water_uom] [char](5) NULL,
	[weigh_master_empl_code] [char](12) NULL,
	[plant_yard_time] [numeric](4, 0) NULL,
	[zone_code] [char](8) NULL,
	[batch_poll_sleep_time] [numeric](5, 0) NULL,
	[batch_upld_wgts_flag] [bit] NULL,
	[track_flag] [bit] NULL,
	[sched_flag] [bit] NULL,
	[dflt_num_of_trucks] [numeric](3, 0) NULL,
	[dflt_cpcty] [numeric](3, 0) NULL,
	[curr_cpcty] [numeric](3, 0) NULL,
	[mixer_time] [numeric](3, 0) NULL,
	[adj_mix_by_tkt_flag] [bit] NULL,
	[track_truck_color] [numeric](2, 0) NULL,
	[loaded_column_flag] [bit] NULL,
	[trvl_time] [numeric](3, 0) NULL,
	[admin_per_qty_cost] [numeric](13, 3) NULL,
	[sales_per_qty_cost] [numeric](13, 3) NULL,
	[disptch_per_qty_cost] [numeric](13, 3) NULL,
	[plant_per_qty_cost] [numeric](13, 3) NULL,
	[fixed_truck_per_qty_cost] [numeric](13, 3) NULL,
	[variable_truck_per_hour_cost] [numeric](13, 3) NULL,
	[annl_intrst_pct] [numeric](6, 2) NULL,
	[truck_eff_factor] [numeric](6, 2) NULL,
	[desired_profit_per_qty] [numeric](8, 2) NULL,
	[loc_code] [char](4) NULL,
	[scale_code] [char](3) NULL,
	[target_mgr_num] [numeric](3, 0) NULL,
	[map_long] [char](9) NULL,
	[map_lat] [char](9) NULL,
	[map_radius] [numeric](4, 0) NULL,
	[alley_code_1] [char](3) NULL,
	[alley_code_2] [char](3) NULL,
	[alley_code_3] [char](3) NULL,
	[alley_code_4] [char](3) NULL,
	[weighed_water_flag] [bit] NULL,
	[qc_code] [char](1) NULL,
	[track_order_color] [numeric](2, 0) NULL,
	[matl_trnsfr_rcpt_option] [char](1) NULL,
	[ca_plant_flag] [bit] NULL,
	[cb_plant_flag] [bit] NULL,
	[cc_plant_flag] [bit] NULL,
	[cd_plant_flag] [bit] NULL,
	[matl_trfs_rcpt_opt] [char](1) NULL,
	[norm_start_time] [datetime] NULL,
	[norm_end_time] [datetime] NULL,
	[signl_unit_code] [char](3) NULL,
	[map_page] [char](8) NULL,
	[asphalt_scale_feeds] [char](2) NULL,
	[imaging_file_location] [char](128) NULL,
	[imaging_file_format] [char](8) NULL,
	[asphalt_drop_prompt] [char](2) NULL,
	[batch_watcher_upd_flag] [bit] NULL,
	[optimize_code] [char](2) NULL,
	[tkting_doc_fmt_group_code] [char](8) NULL,
	[disptch_doc_fmt_group_code] [char](8) NULL,
	[color_dev_type] [numeric](2, 0) NULL,
	[color_tcp_ip_listen_port] [numeric](5, 0) NULL,
	[color_plant_water] [numeric](10, 2) NULL,
	[color_plant_water_uom] [char](5) NULL,
	[color_max_batch_size] [numeric](6, 2) NULL,
	[color_max_batch_size_uom] [char](5) NULL,
	[color_time] [numeric](4, 0) NULL,
	[adjust_cement_with_slump_code] [char](2) NULL,
	[slump_increment] [numeric](6, 2) NULL,
	[cement_change_per_increment] [numeric](6, 2) NULL,
	[min_max_slump_change] [numeric](5, 2) NULL,
	[warn_or_stop_code] [char](2) NULL,
	[cement_change_prod_code] [char](12) NULL,
	[download_dose_qty_code] [char](2) NULL,
	[ca_tkt_overld_truck_code] [char](2) NULL,
	[tare_weight_code] [char](2) NULL,
	[certificate_expiration_code] [char](2) NULL,
	[cc_tkt_overld_truck_code] [char](2) NULL,
	[dosage_type_qty_interface_code] [char](2) NULL,
	[enable_load_toler] [char](2) NULL,
	[load_toler_qty] [numeric](11, 2) NULL,
	[load_toler_qty_uom] [char](5) NULL,
	[plant_min_load_size] [numeric](11, 2) NULL,
	[plant_min_load_size_uom] [char](5) NULL,
	[color_upload_method] [char](1) NULL,
	[cust_seq] [char](3) NULL,
	[sap_tkt_print_flag] [bit] NULL,
	[batch_wgts_from_server_flag] [bit] NULL,
	[region_code] [char](3) NULL,
	[loading_speed_code] [char](5) NULL,
	[load_fee] [numeric](13, 3) NULL,
	[amt_per_unit_dist] [numeric](13, 3) NULL,
	[batch_status_color_code] [char](2) NULL,
	[addr_city] [char](40) NULL,
	[addr_state] [char](10) NULL,
	[addr_cntry] [char](3) NULL,
	[addr_postcd] [char](10) NULL,
	[third_party_taxareaid] [char](10) NULL,
	[third_party_poa_taxareaid] [char](10) NULL,
	[ca_tkt_underld_truck_code] [char](2) NULL,
	[schedulecom_comp_code] [char](20) NULL,
	[tkting_print_ticket_flag] [bit] NULL,
	[snrty_group_code] [char](12) NULL,
	[master_plant_option] [char](2) NULL,
	[master_plant_code] [char](3) NULL,
	[max_deadhead_mins] [numeric](3, 0) NULL,
	[mix_download_batch_num] [numeric](3, 0) NULL,
	[fixed_opening_cost] [numeric](13, 3) NULL,
	[hourly_oper_cost] [numeric](13, 3) NULL,
	[driver_callin_interval] [numeric](3, 0) NULL,
	[update_date] [datetime] NULL,
	[u_version] [char](1) NULL,
	[tkting_port_url] [varchar](200) NULL,
	[disptch_port_url] [varchar](200) NULL,
	[rpting_port_url] [varchar](200) NULL,
	[order_print_port_url] [varchar](200) NULL,
	[tkting_port_setup] [varchar](30) NULL,
	[disptch_port_setup] [varchar](30) NULL,
	[rpting_port_setup] [varchar](30) NULL,
	[order_print_port_setup] [varchar](30) NULL,
	[user_defined] [varchar](2000) NULL,
	[tkting_tcp_ip_addr] [varchar](20) NULL,
	[color_tcp_ip_addr] [varchar](20) NULL,
	[sap_tkt_url] [varchar](200) NULL,
 CONSTRAINT [plnt_pk] PRIMARY KEY CLUSTERED 
(
	[plant_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[kpis]    Script Date: 06/08/2012 09:57:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[kpis](
	[kpi_code] [char](3) NOT NULL,
	[kpi_display_label] [char](20) NULL,
	[kpi_display_cat] [char](2) NULL,
	[update_date] [datetime] NULL,
	[u_version] [char](1) NULL,
 CONSTRAINT [kpis_pk] PRIMARY KEY CLUSTERED 
(
	[kpi_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[kpit]    Script Date: 06/08/2012 09:57:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[kpit](
	[kpi_code] [char](3) NOT NULL,
	[plant_code] [char](3) NOT NULL,
	[target] [numeric](6, 0) NULL,
	[warning_l1] [numeric](6, 0) NULL,
	[warning_l2] [numeric](6, 0) NULL,
	[update_date] [datetime] NULL,
	[u_version] [char](1) NULL,
 CONSTRAINT [kpit_pk] PRIMARY KEY CLUSTERED 
(
	[kpi_code] ASC,
	[plant_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  Table [dbo].[kpir]    Script Date: 06/08/2012 09:58:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[kpir](
	[kpi_role_name] [char](20) NOT NULL,
	[kpi_codes] [char](200) NULL,
	[kpi_display_codes] [char](200) NULL,
	[kpi_display_timers] [char](200) NULL,
	[update_date] [datetime] NULL,
	[u_version] [char](1) NULL,
 CONSTRAINT [kpir_pk] PRIMARY KEY CLUSTERED 
(
	[kpi_role_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[okpi]    Script Date: 06/08/2012 09:56:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[okpi](
	[unique_num] [numeric](13, 0) NOT NULL,
	[record_date] [datetime] NULL,
	[order_date] [datetime] NULL,
	[region_code] [char](3) NULL,
	[orders] [numeric](6, 0) NULL,
	[orders_scheduled] [numeric](6, 0) NULL,
	[loads_scheduled] [numeric](6, 0) NULL,
	[orders_unscheduled] [numeric](6, 0) NULL,
	[fob_orders] [numeric](6, 0) NULL,
	[qty_uom] [char](5) NULL,
	[tot_order_qty] [numeric](17, 2) NULL,
	[tot_order_qty_scheduled] [numeric](17, 2) NULL,
	[tot_order_qty_unscheduled] [numeric](17, 2) NULL,
	[tot_fob_order_qty] [numeric](17, 2) NULL,
	[tot_fob_loads_scheduled] [numeric](6, 0) NULL,
	[distance_uom] [char](5) NULL,
	[tot_distance] [numeric](6, 0) NULL,
	[number_of_plants] [numeric](6, 0) NULL,
	[plant_codes] [char](2000) NULL,
	[avg_lateness] [numeric](8, 2) NULL,
	[max_lateness] [numeric](8, 2) NULL,
	[avg_startup_mins] [numeric](8, 2) NULL,
	[avg_onjob_wait_mins] [numeric](8, 2) NULL,
	[avg_unload_mins] [numeric](8, 2) NULL,
	[avg_wash_mins] [numeric](8, 2) NULL,
	[avg_shutdown_mins] [numeric](8, 2) NULL,
	[avg_rtt_mins] [numeric](6, 0) NULL,
	[number_of_trucks] [numeric](6, 0) NULL,
	[avg_truck_capacity] [numeric](7, 2) NULL,
	[avg_matl_cost] [numeric](17, 2) NULL,
	[tot_driver_hours] [numeric](6, 0) NULL,
	[tot_order_mixes] [numeric](6, 0) NULL,
	[plant_code] [char](3) NULL,
	[first_load_mins] [numeric](6, 0) NULL,
	[first_load_units] [numeric](6, 0) NULL,
	[first_load_target] [numeric](6, 0) NULL,
	[first_load_warn_1] [numeric](6, 0) NULL,
	[first_load_warn_2] [numeric](6, 0) NULL,
	[job_wait_mins] [numeric](6, 0) NULL,
	[job_wait_units] [numeric](6, 0) NULL,
	[job_wait_target] [numeric](6, 0) NULL,
	[job_wait_warn_1] [numeric](6, 0) NULL,
	[job_wait_warn_2] [numeric](6, 0) NULL,
	[yard_time_mins] [numeric](6, 0) NULL,
	[yard_time_units] [numeric](6, 0) NULL,
	[yard_time_target] [numeric](6, 0) NULL,
	[yard_time_warn_1] [numeric](6, 0) NULL,
	[yard_time_warn_2] [numeric](6, 0) NULL,
	[eod_yard_mins] [numeric](6, 0) NULL,
	[eod_yard_units] [numeric](6, 0) NULL,
	[eod_yard_target] [numeric](6, 0) NULL,
	[eod_yard_warn_1] [numeric](6, 0) NULL,
	[eod_yard_warn_2] [numeric](6, 0) NULL,
	[truck_compliance_points] [numeric](6, 0) NULL,
	[load_time_compliance_points] [numeric](6, 0) NULL,
	[ret_plant_compliance_points] [numeric](6, 0) NULL,
	[total_avail_compliance_points] [numeric](6, 0) NULL,
	[compliance_target] [numeric](6, 0) NULL,
	[compliance_warn_1] [numeric](6, 0) NULL,
	[compliance_warn_2] [numeric](6, 0) NULL,
	[loads_locked] [numeric](6, 0) NULL,
	[loads_locked_target] [numeric](6, 0) NULL,
	[loads_locked_warn_1] [numeric](6, 0) NULL,
	[loads_locked_warn_2] [numeric](6, 0) NULL,
	[startup_mins] [numeric](6, 0) NULL,
	[startup_units] [numeric](6, 0) NULL,
	[startup_target] [numeric](6, 0) NULL,
	[startup_warn_1] [numeric](6, 0) NULL,
	[startup_warn_2] [numeric](6, 0) NULL,
	[load_mins] [numeric](6, 0) NULL,
	[load_units] [numeric](6, 0) NULL,
	[load_target] [numeric](6, 0) NULL,
	[load_warn_1] [numeric](6, 0) NULL,
	[load_warn_2] [numeric](6, 0) NULL,
	[wash_out_mins] [numeric](6, 0) NULL,
	[wash_out_units] [numeric](6, 0) NULL,
	[wash_out_target] [numeric](6, 0) NULL,
	[wash_out_warn_1] [numeric](6, 0) NULL,
	[wash_out_warn_2] [numeric](6, 0) NULL,
	[total_status_updates] [numeric](6, 0) NULL,
	[auto_status_updates] [numeric](6, 0) NULL,
	[auto_status_target] [numeric](6, 0) NULL,
	[auto_status_warn_1] [numeric](6, 0) NULL,
	[auto_status_warn_2] [numeric](6, 0) NULL,
	[loads_cancelled] [numeric](6, 0) NULL,
	[loads_cancelled_target] [numeric](6, 0) NULL,
	[loads_cancelled_warn_1] [numeric](6, 0) NULL,
	[loads_cancelled_warn_2] [numeric](6, 0) NULL,
	[loads_modified] [numeric](6, 0) NULL,
	[loads_modified_target] [numeric](6, 0) NULL,
	[loads_modified_warn_1] [numeric](6, 0) NULL,
	[loads_modified_warn_2] [numeric](6, 0) NULL,
	[wash_mins] [numeric](6, 0) NULL,
	[wash_units] [numeric](6, 0) NULL,
	[wash_target] [numeric](6, 0) NULL,
	[wash_warn_1] [numeric](6, 0) NULL,
	[wash_warn_2] [numeric](6, 0) NULL,
	[total_order_qty_scheduled] [numeric](18, 2) NULL,
	[total_delv_qty] [numeric](18, 2) NULL,
	[loads_advance] [numeric](6, 0) NULL,
	[loads_advance_target] [numeric](6, 0) NULL,
	[loads_advance_warn_1] [numeric](6, 0) NULL,
	[loads_advance_warn_2] [numeric](6, 0) NULL,
	[loads_map_page] [numeric](6, 0) NULL,
	[loads_map_page_target] [numeric](6, 0) NULL,
	[loads_map_page_warn_1] [numeric](6, 0) NULL,
	[loads_map_page_warn_2] [numeric](6, 0) NULL,
	[unload_mins] [numeric](6, 0) NULL,
	[unload_units] [numeric](6, 0) NULL,
	[unload_target] [numeric](6, 0) NULL,
	[unload_warn_1] [numeric](6, 0) NULL,
	[unload_warn_2] [numeric](6, 0) NULL,
	[delv_qty_target] [numeric](6, 0) NULL,
	[delv_qty_warn_1] [numeric](6, 0) NULL,
	[delv_qty_warn_2] [numeric](6, 0) NULL,
	[update_date] [datetime] NULL,
	[u_version] [char](1) NULL,
 CONSTRAINT [okpi_pk] PRIMARY KEY CLUSTERED 
(
	[unique_num] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[usnm]    Script Date: 06/08/2012 09:54:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[usnm](
	[user_name] [char](20) NOT NULL,
	[group_flag] [bit] NULL,
	[owner_name] [char](40) NULL,
	[empl_code] [char](12) NULL,
	[pswd] [char](16) NULL,
	[group_name] [char](16) NULL,
	[life] [numeric](5, 0) NULL,
	[lang] [char](3) NULL,
	[date_fmt] [numeric](1, 0) NULL,
	[date_order] [numeric](1, 0) NULL,
	[appl_type_01] [char](2) NULL,
	[appl_type_02] [char](2) NULL,
	[appl_type_03] [char](2) NULL,
	[appl_type_04] [char](2) NULL,
	[appl_type_05] [char](2) NULL,
	[appl_type_06] [char](2) NULL,
	[appl_type_07] [char](2) NULL,
	[appl_type_08] [char](2) NULL,
	[appl_type_09] [char](2) NULL,
	[appl_type_10] [char](2) NULL,
	[appl_type_11] [char](2) NULL,
	[appl_type_12] [char](2) NULL,
	[appl_type_13] [char](2) NULL,
	[appl_type_14] [char](2) NULL,
	[appl_type_15] [char](2) NULL,
	[appl_type_16] [char](2) NULL,
	[appl_type_17] [char](2) NULL,
	[appl_type_18] [char](2) NULL,
	[appl_type_19] [char](2) NULL,
	[appl_type_20] [char](2) NULL,
	[appl_type_21] [char](2) NULL,
	[appl_type_22] [char](2) NULL,
	[appl_type_23] [char](2) NULL,
	[appl_type_24] [char](2) NULL,
	[appl_type_25] [char](2) NULL,
	[appl_type_26] [char](2) NULL,
	[appl_type_27] [char](2) NULL,
	[appl_type_28] [char](2) NULL,
	[appl_type_29] [char](2) NULL,
	[appl_type_30] [char](2) NULL,
	[appl_type_31] [char](2) NULL,
	[appl_type_32] [char](2) NULL,
	[print_model] [char](16) NULL,
	[print_model_flag] [bit] NULL,
	[assgn_plant_code] [char](3) NULL,
	[allow_rel_cred_batch_flag] [bit] NULL,
	[allow_susp_invc_flag] [bit] NULL,
	[allow_rel_invc_flag] [bit] NULL,
	[allow_order_mix_design_flag] [bit] NULL,
	[allow_tkt_approvl_flag] [bit] NULL,
	[allow_updt_proj_order_flag] [bit] NULL,
	[allow_overhd_loadout_flag] [bit] NULL,
	[last_date_chng] [datetime] NULL,
	[last_time_chng] [datetime] NULL,
	[last_date_used] [datetime] NULL,
	[last_time_used] [datetime] NULL,
	[used_count] [numeric](5, 0) NULL,
	[chng_count] [numeric](5, 0) NULL,
	[gim_screen_master_edit_flag] [bit] NULL,
	[gim_screen_group_edit_flag] [bit] NULL,
	[gim_screen_user_edit_flag] [bit] NULL,
	[gim_temp_user_edit_flag] [bit] NULL,
	[gim_view_only_flag] [bit] NULL,
	[supp_min_load_chrg_disp_flag] [bit] NULL,
	[supp_season_chrg_disp_flag] [bit] NULL,
	[allow_update_to_lang_flag] [bit] NULL,
	[allow_order_quote_flag] [bit] NULL,
	[supp_price_msg_flag] [bit] NULL,
	[expand_delv_addr_flag] [bit] NULL,
	[expand_instr_flag] [bit] NULL,
	[auto_disp_oe_proj_flag] [bit] NULL,
	[auto_disp_oe_prod_flag] [bit] NULL,
	[gim_group_name] [char](16) NULL,
	[restrict_cust_by_comp] [char](4) NULL,
	[dflt_scale_code] [char](3) NULL,
	[lab_loc_code] [char](4) NULL,
	[invc_print_code] [char](1) NULL,
	[supp_item_sub_msg_code] [numeric](2, 0) NULL,
	[cust_code] [char](10) NULL,
	[allow_add_cod_order_code] [char](2) NULL,
	[allow_add_truck_code] [char](1) NULL,
	[allow_change_truck_code] [char](1) NULL,
	[allow_delete_truck_code] [char](1) NULL,
	[fleet_auto_launch_flag] [bit] NULL,
	[expiration_date] [datetime] NULL,
	[allow_non_priv_plant_flag] [bit] NULL,
	[show_expir_proj_in_lookup_flag] [bit] NULL,
	[use_dot_net_printing] [char](2) NULL,
	[kpi_role_name] [char](20) NULL,
	[kpi_plants] [char](200) NULL,
	[update_date] [datetime] NULL,
	[u_version] [char](1) NULL,
	[priv_plant_code_list] [varchar](2000) NULL,
 CONSTRAINT [usnm_pk] PRIMARY KEY CLUSTERED 
(
	[user_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
