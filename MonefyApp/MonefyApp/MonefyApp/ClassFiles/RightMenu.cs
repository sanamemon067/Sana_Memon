/*
 * Created by Ranorex
 * User: Hp
 * Date: 4/5/2021
 * Time: 12:19 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Reporting;
using System.Drawing;

namespace MonefyApp.ClassFiles
{
	/// <summary>
	/// Description of RightMenu.
	/// </summary>
	public class RightMenu
	{
		/// <summary>
		/// This method validates options from the right hand side
		/// </summary>
		public static void ValidateRightHandSideMenuItems()
		{
			// Report
			Report.Log(ReportLevel.Info, "In ValidateRightHandSideMenuItems");
				
			// Validate menu options
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.RightMenu.CategoriesOption.Visible == true);
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.RightMenu.AccountsOption.Visible == true);
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.RightMenu.CurrenciesOption.Visible == true);
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.RightMenu.SettingsOption.Visible == true);
			Report.Log(ReportLevel.Info, "Menu options are displayed successfully");
				
			// Report
			Report.Log(ReportLevel.Info, "Out ValidateRightHandSideMenuItems");
		}
		
		/// <summary>
		/// This method opens and closes right side menu
		/// </summary>
		public static void OpenAndCloseRightMenu(bool openmenu = true, bool closemenu = true)
		{
			// Report
			Report.Log(ReportLevel.Info, "In OpenAndCloseRightMenu");
			
			if(openmenu)
			{
				// Tap on right hand side menu (three vertical dots)
				MonefyAppRepository.Instance.MonefyAppElements.RightMenu.RightMenuButton.Touch();
				Report.Log(ReportLevel.Info, "Right side menu is open");
			}
			
			if(closemenu)
			{
				// Tap on right hand side menu (three vertical dots) to close the menu
				MonefyAppRepository.Instance.MonefyAppElements.RightMenu.RightMenuButton.Touch();
				Report.Log(ReportLevel.Info, "Right side menu is closed");	
			}
			
			// Report
			Report.Log(ReportLevel.Info, "Out OpenAndCloseRightMenu");
		}
		
		/// <summary>
		/// This method opens New Account Page
		/// </summary>
		public static void OpenNewAccountPage()
		{
			// Report
			Report.Log(ReportLevel.Info, "In OpenNewAccountPage");
			
			// Tap on accounts section
			MonefyAppRepository.Instance.MonefyAppElements.RightMenu.AccountsOption.Touch();
			Report.Log(ReportLevel.Info, "Tapped on acounts section");
			
			// Tap on the add account option
			MonefyAppRepository.Instance.MonefyAppElements.RightMenu.NewAccountPage.AddAccountButton.Touch();
			Report.Log(ReportLevel.Info, "Tapped on add account button");
			
			// Validate new account page is open
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.RightMenu.NewAccountPage.PageTitle.TextValue == "New account");
			Report.Log(ReportLevel.Info, "New Account Page is open");
			
			// Report
			Report.Log(ReportLevel.Info, "Out OpenNewAccountPage");
		}
		
		/// <summary>
		/// This method adds new account details of user
		/// </summary>
		public static void AddNewAccountDetails(string accountName, string amount)
		{
			// Report
			Report.Log(ReportLevel.Info, "In AddNewAccountDetails");
			
			// Enter Account Name
			MonefyAppRepository.Instance.MonefyAppElements.RightMenu.NewAccountPage.NameInputField.TextValue = accountName;
			Report.Log(ReportLevel.Info, "In AddNewAccountDetails");
			
			// Enter initial balance
			MonefyAppRepository.Instance.MonefyAppElements.RightMenu.NewAccountPage.InitialAccountBalanceInput.Touch();
			MonefyAppRepository.Instance.MonefyAppElements.RightMenu.NewAccountPage.InitialAccountBalanceInput.TextValue = amount;
			Report.Log(ReportLevel.Info, "Amount added");
			
			// Select image
			MonefyAppRepository.Instance.MonefyAppElements.RightMenu.NewAccountPage.Image.Touch();
			Report.Log(ReportLevel.Info, "Image selected");
			
			// Tap on add button
			MonefyAppRepository.Instance.MonefyAppElements.RightMenu.NewAccountPage.AddButton.Touch();
			Report.Log(ReportLevel.Info, "Tapped on add button");
			
			// Verify account added message
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.RightMenu.NewAccountPage.Message.TextValue == "New account was added");
			Report.Log(ReportLevel.Info, "New account is added successfully");
			
			// Report
			Report.Log(ReportLevel.Info, "Out AddNewAccountDetails");
		}
	}
}
