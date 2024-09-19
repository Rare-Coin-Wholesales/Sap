using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
{
	public partial class Mapper
	{
		public virtual ChecksforPayment ToSql(Api.Domain.ChecksforPayments.ChecksforPayment x)
		{
			return new ChecksforPayment {
				CheckKey = x.CheckKey,
				CheckNumber = x.CheckNumber,
				BankCode = x.BankCode,
				Branch = x.Branch,
				BankName = x.BankName,
				CheckDate = x.CheckDate,
				AccountNumber = x.AccountNumber,
				Details = x.Details,
				JournalEntryReference = x.JournalEntryReference,
				PaymentDate = x.PaymentDate,
				PaymentNo = x.PaymentNo,
				CheckAmount = x.CheckAmount,
				Transferable = x.Transferable,
				VendorCode = x.VendorCode,
				CheckCurrency = x.CheckCurrency,
				Canceled = x.Canceled,
				CardOrAccount = x.CardOrAccount,
				Printed = x.Printed,
				VendorName = x.VendorName,
				Signature = x.Signature,
				CustomerAccountCode = x.CustomerAccountCode,
				TransactionNumber = x.TransactionNumber,
				Address = x.Address,
				CreateJournalEntry = x.CreateJournalEntry,
				UpdateDate = x.UpdateDate,
				CreationDate = x.CreationDate,
				TaxTotal = x.TaxTotal,
				TaxDate = x.TaxDate,
				DeductionRefundAmount = x.DeductionRefundAmount,
				PrintedBy = x.PrintedBy,
				CountryCode = x.CountryCode,
				TotalinWords = x.TotalinWords,
				AddressName = x.AddressName,
				ManualCheck = x.ManualCheck,
				AttachmentEntry = x.AttachmentEntry,
				ECheck = x.ECheck,
				PrintConfirm = x.PrintConfirm,
			};
		}

		public virtual ChecksforPaymentLine ToSql(Api.Domain.ChecksforPayments.ChecksforPaymentLine x)
		{
			return new ChecksforPaymentLine {
				CheckKey = x.CheckKey,
				RowNumber = x.RowNumber,
				RowDetails = x.RowDetails,
				RowTotal = x.RowTotal,
				RowCurrency = x.RowCurrency,
				TaxDefinition = x.TaxDefinition,
				TaxPercent = x.TaxPercent,
				CreditedAccount = x.CreditedAccount,
				LineTotal = x.LineTotal,
			};
		}
	}
}