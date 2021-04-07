
using System;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Repository;

namespace MonefyApp.ClassFiles
{
	/// <summary>
	/// Description of NewTransferScreen.
	/// </summary>
	public class NewTransferScreen
	{
		
		/// <summary>
		/// This method performs new transfer
		/// </summary>
		public static void PerformNewTransfer(string amt)
		{
			Report.Log(ReportLevel.Info, "In PerformNewTransfer");
			
			// Tap on New Transfer button (double arrow)
			MonefyAppRepository.Instance.MonefyAppElements.NewTransferScreen.NewTransferButton.Touch();
			Report.Log(ReportLevel.Info, "New Transfer Screen is open");
			
			// Validate we are on New Transfer screen
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.NewTransferScreen.WindowTitle.TextValue == "New transfer");
			Report.Log(ReportLevel.Info, "Validation successfull");
			
			// Add amount
			MonefyAppRepository.Instance.MonefyAppElements.NewTransferScreen.INRInputField.Touch();
			EnterValues(amt);
			Delay.Seconds(2);
			Report.Log(ReportLevel.Info, "Amount is added");
			
			// Tap on Add Transfer Button
			MonefyAppRepository.Instance.MonefyAppElements.NewTransferScreen.AddTransferButton.Touch();
			Report.Log(ReportLevel.Info, "Tapped on Add Transfer Button");
			
			// Validate transfer is done successfully
			Validate.IsTrue(MonefyAppRepository.Instance.MonefyAppElements.NewTransferScreen.TransferAddedMessage.TextValue == "Transfer was added");
			Report.Log(ReportLevel.Info, "Transfer was added successfully and we are back on Home Page");
			
			Report.Log(ReportLevel.Info, "Out PerformNewTransfer");
		}
		
		/// <summary>
		/// This method select values from keyboard
		/// </summary>
		public static void EnterValues(string valueToEnterIn)
		{
			
			// Log Info
			Report.Log(ReportLevel.Info, "In EnterValue - Value being entered is: " + valueToEnterIn);

			// Must convert the string to an array
			char[] myInputValue = valueToEnterIn.ToCharArray();
			
			// Now loop though the array
			for (int iCounter = 0; iCounter < myInputValue.Length; iCounter++)
			{
				switch (myInputValue[iCounter]) 
				{
					case '1':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number1.Touch();			
						break;
					case '2':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number2.Touch();			
						break;
					case '3':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number3.Touch();			
						break;
					case '4':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number4.Touch();			
						break;
					case '5':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number5.Touch();			
						break;
					case '6':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number6.Touch();			
						break;
					case '7':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number7.Touch();			
						break;
					case '8':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number8.Touch();			
						break;
					case '9':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number9.Touch();			
						break;
					case '0':
						MonefyAppRepository.Instance.MonefyAppElements.KeyboardElements.Number0.Touch();			
						break;
					default:
						
						break;
				}					
			}
			
			// Log Info
			Report.Log(ReportLevel.Info, "Out EnterValue");
		}
	}
}
