
using System;
using Ranorex;
using System.Drawing;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Repository;
using MonefyApp.ClassFiles;

namespace MonefyApp.ClassFiles
{
	/// <summary>
	/// Description of HomePage.
	/// </summary>
	public class HomePage
	{
		/// <summary>
		/// This method opens New Expense page from Home page by tapping minus sign
		/// </summary>
		public static void OpenNewExpensePage()
		{
			// Report
			Report.Log(ReportLevel.Info, "In OpenNewExpensePage");
			
			// Tap on plus button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpenseButton.Touch();
			Report.Log(ReportLevel.Info, "Tapped on New expense button");
			
			// Validate we are on new expense page
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.PageTitle.TextValue == "New expense");
			Report.Log(ReportLevel.Info, "We are on the New expense page");
			
			// Report
			Report.Log(ReportLevel.Info, "Out OpenNewExpensePage");
		}
		
		/// <summary>
		/// This method adds new expense by tapping the minus sign from home page
		/// </summary>
		public static void AddNewExpenseByTappingMinusSign(string amt)
		{
			// Report
			Report.Log(ReportLevel.Info, "In AddNewExpense");
			
			// Enter amount
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.INRInputField.Touch();
			NewTransferScreen.EnterValues(amt);
			Report.Log(ReportLevel.Info, "Amount added");
			
			// Choose Category
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.ChooseCategoryButton.Touch();
			SelectNewExpenseCategoryOption(CategoriesOptions.ExpenseCategoryOptions.EatingOut);
			Report.Log(ReportLevel.Info, "Category selected");
			
			// Validate expense added successfully
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.Message.TextValue.Contains("Eating out"));
			Report.Log(ReportLevel.Info, "Expense added successfully");

			// Report
			Report.Log(ReportLevel.Info, "Out AddNewExpense");
		}
		
		/// <summary>
		/// This method navigates to add expense page by selecting category image from home screen
		/// </summary>
		public static void SelectCategoryImage()
		{
			// Report
			Report.Log(ReportLevel.Info, "In SelectCategoryImage");
			
			// Select expense category image
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.FirstCategory.Touch();
			Report.Log(ReportLevel.Info, "Expense Image selected");
			
			// Report
			Report.Log(ReportLevel.Info, "Out SelectCategoryImage");
		}
		
		/// <summary>
		/// This method adds new expense by selecting expense image from home page
		/// </summary>
		public static void AddNewExpenseBySelectingExpenseImage(string amt)
		{
			// Report
			Report.Log(ReportLevel.Info, "In AddNewExpense");
			
			// Enter amount
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.INRInputField.Touch();
			NewTransferScreen.EnterValues(amt);
			Report.Log(ReportLevel.Info, "Amount added");
			
			// Choose Category
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.AddButton.Touch();
			Report.Log(ReportLevel.Info, "Category selected");
			
			// Validate expense added successfully
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.Message.TextValue.Contains("added"));
			Report.Log(ReportLevel.Info, "Expense added successfully");					
			
			// Report
			Report.Log(ReportLevel.Info, "Out AddNewExpense");
		}
		
		/// <summary>
		/// This method opens New Income page from Home page by tapping plus sign
		/// </summary>
		public static void OpenNewIncomePage()
		{
			// Report
			Report.Log(ReportLevel.Info, "In OpenNewIncomePage");
			
			// Tap on plus button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewIncomeButton.Touch();
			Report.Log(ReportLevel.Info, "Tapped on New expense button");
			
			// Validate we are on new expense page
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewIncomePage.PageTitle.TextValue == "New income");
			Report.Log(ReportLevel.Info, "We are on the New expense page");
			
			// Report
			Report.Log(ReportLevel.Info, "Out OpenNewIncomePage");
		}
		
		/// <summary>
		/// This method adds new income by tapping the plus sign from home page
		/// </summary>
		public static void AddNewIncomeByTappingPlusSign(string amt)
		{
			// Report
			Report.Log(ReportLevel.Info, "In AddNewIncomeByTappingPlusSign");
			
			// Enter amount
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.INRInputField.Touch();
			NewTransferScreen.EnterValues(amt);
			Report.Log(ReportLevel.Info, "Amount added");
			
			// Choose Category
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.ChooseCategoryButton.Touch();
			SelectNewIncomeCategoryOption(CategoriesOptions.IncomeCategoryOptions.Deposits);
			Report.Log(ReportLevel.Info, "Category selected");
			
			// Validate income added successfully
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewIncomePage.IncomeAddedMessage.TextValue.Contains("Deposits:"));
			Report.Log(ReportLevel.Info, "Income added successfully");					
			
			// Report
			Report.Log(ReportLevel.Info, "Out AddNewIncomeByTappingPlusSign");
		}
		
		/// <summary>
		/// This method selects the income category options 
		/// </summary>
		public static void SelectNewIncomeCategoryOption(CategoriesOptions.IncomeCategoryOptions myIncomeCategory)
		{
			// Log Info
			Report.Log(ReportLevel.Info, "In SelectNewIncomeCategoryOption");
			
			// Tap the category options
			switch (myIncomeCategory) 
			{
					
				case CategoriesOptions.IncomeCategoryOptions.Salary:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewIncomePage.SalaryIncomeCategory.Touch();
					break;
				
				case CategoriesOptions.IncomeCategoryOptions.Deposits:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewIncomePage.DepositIncomeCategory.Touch();
					break;
					
				case CategoriesOptions.IncomeCategoryOptions.Savings:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewIncomePage.SavingsIncomeCategory.Touch();
					break;
					
				default:
					
					break;
			}
			
			// Log Info
			Report.Log(ReportLevel.Info, "Out SelectNewIncomeCategoryOption");
			
		}

		/// <summary>
		/// This method selects the expense category options 
		/// </summary>
		public static void SelectNewExpenseCategoryOption(CategoriesOptions.ExpenseCategoryOptions myExpenseCategory)
		{
			// Log Info
			Report.Log(ReportLevel.Info, "In SelectNewExpenseCategoryOption");
			
			// Tap the category options
			switch (myExpenseCategory) 
			{
					
				case CategoriesOptions.ExpenseCategoryOptions.Bills:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.BillsCategory.Touch();
					break;
				
				case CategoriesOptions.ExpenseCategoryOptions.Car:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.BillsCategory.Touch();
					break;
					
				case CategoriesOptions.ExpenseCategoryOptions.Clothes:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.ClothesCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Communications:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.CommunicationsCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.EatingOut:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.EatingOutCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Entertainment:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.EntertainmentCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Food:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.FoodCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Gifts:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.GiftsCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Health:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.HealthCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.House:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.HouseCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Pets:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.PetsCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Sports:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.SportsCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Taxi:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.TaxiCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Toiletry:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.ToiletryCategory.Touch();
					break;
					
					case CategoriesOptions.ExpenseCategoryOptions.Transport:
					MonefyAppRepository.Instance.MonefyAppElements.HomePage.NewExpensePage.TransportCategory.Touch();
					break;
					
				default:
					
					break;
			}
			
			// Log Info
			Report.Log(ReportLevel.Info, "Out SelectNewExpenseCategoryOption");
			
		}	

		/// <summary>
		/// This method selects the expense to be edited
		/// </summary>
		public static void SelectExpenseToEdit()
		{
			// Log Info
			Report.Log(ReportLevel.Info, "In SelectExpenseToEdit");
			
			// Tap on balance button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalanceButton.Touch();
			Report.Log(ReportLevel.Info, "Balance Page is open");
			
			// Select on expense to be edit
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.AddedExpense.Touch();
			Report.Log(ReportLevel.Info, "Expense selected to edit");
			
			// Tap on the expense to be edit
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.EditExpense.Touch();
			Report.Log(ReportLevel.Info, "Tapped on the expense to be edited");
			
			// Log Info
			Report.Log(ReportLevel.Info, "Out SelectExpenseToEdit");
		}
		
		/// <summary>
		/// This method selects the income to be edited
		/// </summary>
		public static void SelectIncomeToEdit()
		{
			// Log Info
			Report.Log(ReportLevel.Info, "In SelectIncomeToEdit");
			
			// Tap on balance button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalanceButton.Touch();
			Report.Log(ReportLevel.Info, "Balance Page is open");
			
			// Select on expense to be edit
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.AddedIncome.Touch();
			Report.Log(ReportLevel.Info, "Expense selected to edit");
			
			// Tap on the expense to be edit
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.EditIncome.Touch();
			Report.Log(ReportLevel.Info, "Tapped on the expense to be edited");
			
			// Log Info
			Report.Log(ReportLevel.Info, "Out SelectIncomeToEdit");
		}
		
		/// <summary>
		/// This method edits the expense added
		/// </summary>
		public static void EditExpense(string amt)
		{
			// Log Info
			Report.Log(ReportLevel.Info, "In EditExpense");
			
			// Validate we are on edit expense page
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.EditPageTitle.TextValue == "Edit expense");
			Report.Log(ReportLevel.Info, "We are on the edit expense page");
			
			// Tap backspace button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.BackSpaceButton.Touch();
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.BackSpaceButton.Touch();
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.BackSpaceButton.Touch();
			Report.Log(ReportLevel.Info, "Tapped on backspace");
			
			// Enter new amount
			NewTransferScreen.EnterValues(amt);
			Report.Log(ReportLevel.Info, "New amount added");
			
			// Select category
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.ChangeCategoryButton.Touch();
			SelectNewExpenseCategoryOption(CategoriesOptions.ExpenseCategoryOptions.Food);
			Report.Log(ReportLevel.Info, "New category selected");
			
			// Verify record updated
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.ChangesUpdatedMessage.TextValue == "Record was updated");
			Report.Log(ReportLevel.Info, "Expense was modified successfully");
			
			// Back to home page
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalanceButton.Touch();
			Report.Log(ReportLevel.Info, "We are back on the home page");
			
			// Log Info
			Report.Log(ReportLevel.Info, "Out EditExpense");
		}
		
		/// <summary>
		/// This method edits the income added
		/// </summary>
		public static void EditIncome(string amt)
		{
			// Log Info
			Report.Log(ReportLevel.Info, "In EditExpense");
			
			// Validate we are on edit expense page
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.EditPageTitle.TextValue == "Edit income");
			Report.Log(ReportLevel.Info, "We are on the edit expense page");
			
			// Tap backspace button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.BackSpaceButton.Touch();
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.BackSpaceButton.Touch();
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.BackSpaceButton.Touch();
			Report.Log(ReportLevel.Info, "Tapped on backspace");
			
			// Enter new amount
			NewTransferScreen.EnterValues(amt);
			Report.Log(ReportLevel.Info, "New amount added");
			
			// Select category
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.ChangeCategoryButton.Touch();
			SelectNewIncomeCategoryOption(CategoriesOptions.IncomeCategoryOptions.Salary);
			Report.Log(ReportLevel.Info, "New category selected");
			
			// Verify record updated
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.ChangesUpdatedMessage.TextValue == "Record was updated");
			Report.Log(ReportLevel.Info, "Expense was modified successfully");
			
			// Back to home page
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalanceButton.Touch();
			Report.Log(ReportLevel.Info, "We are back on the home page");
			
			// Log Info
			Report.Log(ReportLevel.Info, "Out EditExpense");
		}
		
		/// <summary>
		/// This method selects the expense to be deleted
		/// </summary>
		public static void SelectExpenseToDelete()
		{
			// Log Info
			Report.Log(ReportLevel.Info, "In SelectExpenseToDelete");
			
			// Tap on balance button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalanceButton.Touch();
			Report.Log(ReportLevel.Info, "Balance Page is open");
			
			// Select on expense to be edit
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.AddedExpense.Touch();
			Report.Log(ReportLevel.Info, "Expense selected to be deleted");
			
			// Long touch on expense to delete
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.EditExpense.LongTouch();
			Report.Log(ReportLevel.Info, "Long touch on expense to be deleted");
			
			// Delete button 
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.DeleteButton.Touch();
			Report.Log(ReportLevel.Info, "Tapped on delete button");
			
			// Verify item deleted
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.ChangesUpdatedMessage.TextValue.Contains("deleted"));
			Report.Log(ReportLevel.Info, "Expense was deleted successfully");
			
			// Tap on balance button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalanceButton.Touch();
			Report.Log(ReportLevel.Info, "Back on home page");
			
			// Log Info
			Report.Log(ReportLevel.Info, "Out SelectExpenseToDelete");
		}
		
		/// <summary>
		/// This method selects the income to be deleted
		/// </summary>
		public static void SelectIncomeToDelete()
		{
			// Log Info
			Report.Log(ReportLevel.Info, "In SelectIncomeToDelete");
			
			// Tap on balance button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalanceButton.Touch();
			Report.Log(ReportLevel.Info, "Balance Page is open");
			
			// Select on expense to be edit
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.AddedIncome.Touch();
			Report.Log(ReportLevel.Info, "Income selected to edit");
			
			// Tap on the expense to be edit
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.EditIncome.LongTouch();
			Report.Log(ReportLevel.Info, "Tapped on the income to be edited");
			
			// Delete button 
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.DeleteButton.Touch();
			Report.Log(ReportLevel.Info, "Tapped on delete button");
			
			// Verify item deleted
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalancePage.ChangesUpdatedMessage.TextValue.Contains("deleted"));
			Report.Log(ReportLevel.Info, "Income was deleted successfully");
			
			// Tap on balance button
			MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalanceButton.Touch();
			Report.Log(ReportLevel.Info, "Balance Page is open");
			
			// Log Info
			Report.Log(ReportLevel.Info, "Out SelectIncomeToDelete");
		}
	}
}
