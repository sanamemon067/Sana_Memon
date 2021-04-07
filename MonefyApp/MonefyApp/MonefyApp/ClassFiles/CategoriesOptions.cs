
using System;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;


namespace MonefyApp.ClassFiles
{
	/// <summary>
	/// Description of CategoriesOptions.
	/// </summary>
	public class CategoriesOptions
	{
		/// <summary>
		/// ENUM to to help support method calls so that user does not have to type out what Prompt they are working with
		/// </summary>
		public enum IncomeCategoryOptions
		{
			Deposits,
			Salary,
			Savings,
		}
		
		/// <summary>
		/// ENUM to to help support method calls so that user does not have to type out what Prompt they are working with
		/// </summary>
		public enum ExpenseCategoryOptions
		{
			Bills,
			Car,
			Clothes,
			Communications,
			EatingOut,
			Entertainment,
			Food,
			Gifts,
			Health,
			House,
			Pets,
			Sports,
			Taxi,
			Toiletry,
			Transport
			
		}
		
		
	}
}
