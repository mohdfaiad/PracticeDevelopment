//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDA.DbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShipmentDispatchNoteDetail
    {
        public int Id { get; set; }
        public string ShipToAddressName { get; set; }
        public string ShipToAddressStreet { get; set; }
        public string ShipToAddressZipCode { get; set; }
        public string ShipToAddressPostalAddress { get; set; }
        public string ShipToAddressCountry { get; set; }
        public string ShipToAddressCity { get; set; }
        public string ShipToAddressContact { get; set; }
        public string ShipToAddressContactPhone { get; set; }
        public string ShipToAddressContactFax { get; set; }
        public string ShipToAddressContactEmail { get; set; }
        public string InvoiceAddressName { get; set; }
        public string InvoiceAddressStreet { get; set; }
        public string InvoiceAddressZipCode { get; set; }
        public string InvoiceAddressPostalAddress { get; set; }
        public string InvoiceAddressCountry { get; set; }
        public string InvoiceAddressCity { get; set; }
        public string InvoiceAddressContact { get; set; }
        public string InvoiceAddressContactPhone { get; set; }
        public string InvoiceAddressContactFax { get; set; }
        public string InvoiceAddressContactEmail { get; set; }
        public string Seller { get; set; }
        public string SellerAddressName { get; set; }
        public string SellerAddressStreet { get; set; }
        public string SellerAddressZipCode { get; set; }
        public string SellerAddressPostalAddress { get; set; }
        public string SellerAddressCountry { get; set; }
        public string SellerAddressCity { get; set; }
        public string SellerAddressContact { get; set; }
        public string SellerAddressContactPhone { get; set; }
        public string SellerAddressContactFax { get; set; }
        public string SellerAddressContactEmail { get; set; }
        public string MeansOfTransport { get; set; }
        public Nullable<bool> PrintShippingList { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string CustomerVATNo { get; set; }
        public Nullable<decimal> CustomerVATRate { get; set; }
        public string VATExemptRef { get; set; }
        public string IncoTermCode { get; set; }
        public string IncoTermText { get; set; }
        public string PaymentTerm { get; set; }
        public string ContractNoDate { get; set; }
        public string PassportOfDeal { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<decimal> FreightCostBeforeBorder { get; set; }
        public Nullable<decimal> FreightCostAfterBorder { get; set; }
        public Nullable<decimal> FreightCost { get; set; }
        public string SellerOrganisationNo { get; set; }
        public string SellerVATNo { get; set; }
        public Nullable<decimal> TotalNetPrice { get; set; }
        public Nullable<decimal> TotalVATAmount { get; set; }
        public Nullable<decimal> TotalInvoiceAmount { get; set; }
        public string InvoiceContactName { get; set; }
        public string InvoiceContactPhone { get; set; }
        public string InvoiceContactFax { get; set; }
        public string InvoiceContactEmail { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string SwiftCode { get; set; }
        public string IBAN { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public Nullable<bool> InvoiceInfoReceived { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual ShipmentDispatchNote ShipmentDispatchNote { get; set; }
    }
}