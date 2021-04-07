/*
 * Created by Ranorex
 * User: Hp
 * Date: 4/5/2021
 * Time: 12:19 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;

namespace MonefyApp.ClassFiles
{
	/// <summary>
	/// Description of LeftMenu.
	/// </summary>
	public class LeftMenu
	{
		/// <summary>
		/// This method opens left side menu options
		/// </summary>
		public static void OpenLeftMenu()
		{
			// Report
			Report.Log(ReportLevel.Info, "In OpenLeftMenu");
			
			// Open Left menu
			MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.LeftMenuButton.Touch();
			Report.Log(ReportLevel.Info, "Left menu is open");
			
			// Report
			Report.Log(ReportLevel.Info, "Out OpenLeftMenu");
		}
		
		/// <summary>
		/// This method validates left side menu options
		/// </summary>
		public static void ValideLeftMenuOptions()
		{
			// Report
			Report.Log(ReportLevel.Info, "In ValideLeftMenuOptions");
			
			// Validate right menu options
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.AllAccounts.TextValue == "All accounts");
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.Day.Text == "Day");
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.Week.Text == "Week");
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.Month.Text == "Month");
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.Year.Text == "Year");
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.All.Text == "All");
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.Interval.Text == "Interval");
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.ChooseDate.Text == "Choose date");
			Report.Log(ReportLevel.Info, "ALL options are visible");
			
			// Report
			Report.Log(ReportLevel.Info, "Out ValideLeftMenuOptions");
		}
		
		/// <summary>
		/// This method closes left side menu options
		/// </summary>
		public static void CloseLeftMenu()
		{
			// Report
			Report.Log(ReportLevel.Info, "In CloseLeftMenu");
				
			// Close Left menu
			MonefyAppRepository.Instance.MonefyAppElements.LeftMenu.CloseButton.Touch();
			Report.Log(ReportLevel.Info, "Left menu is closed");	
				
			// Report
			Report.Log(ReportLevel.Info, "Out CloseLeftMenu");
		}
	}
}
