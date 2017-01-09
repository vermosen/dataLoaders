//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dataLoader
{
    using System;
    using System.Collections.Generic;
    
    public partial class dtcc_transactions
    {
        public long DISSEMINATION_ID { get; set; }
        public Nullable<long> ORIGINAL_DISSEMINATION_ID { get; set; }
        public byte ACTION { get; set; }
        public System.DateTime EXECUTION_TIMESTAMP { get; set; }
        public bool CLEARED { get; set; }
        public Nullable<byte> INDICATION_OF_COLLATERALIZATION { get; set; }
        public Nullable<bool> INDICATION_OF_END_USER_EXCEPTION { get; set; }
        public bool INDICATION_OF_OTHER_PRICE_AFFECTING_TERM { get; set; }
        public bool BLOCK_TRADES_AND_LARGE_NOTIONAL_OFFFACILITY_SWAPS { get; set; }
        public Nullable<bool> EXECUTION_VENUE { get; set; }
        public Nullable<System.DateTime> EFFECTIVE_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public string DAY_COUNT_CONVENTION { get; set; }
        public string SETTLEMENT_CURRENCY { get; set; }
        public byte ASSET_CLASS { get; set; }
        public string SUBASSET_CLASS_FOR_OTHER_COMMODITY { get; set; }
        public string TAXONOMY { get; set; }
        public string PRICE_FORMING_CONTINUATION_DATA { get; set; }
        public string UNDERLYING_ASSET_1 { get; set; }
        public string PRICE_NOTATION_TYPE { get; set; }
        public Nullable<decimal> PRICE_NOTATION { get; set; }
        public string ADDITIONAL_PRICE_NOTATION_TYPE { get; set; }
        public Nullable<decimal> ADDITIONAL_PRICE_NOTATION { get; set; }
        public string NOTIONAL_CURRENCY_1 { get; set; }
        public string NOTIONAL_CURRENCY_2 { get; set; }
        public Nullable<decimal> ROUNDED_NOTIONAL_AMOUNT_1 { get; set; }
        public Nullable<bool> ROUNDED_NOTIONAL_AMOUNT_1_PLUS { get; set; }
        public Nullable<decimal> ROUNDED_NOTIONAL_AMOUNT_2 { get; set; }
        public Nullable<bool> ROUNDED_NOTIONAL_AMOUNT_2_PLUS { get; set; }
        public string PAYMENT_FREQUENCY_1 { get; set; }
        public string PAYMENT_FREQUENCY_2 { get; set; }
        public string RESET_FREQUENCY_1 { get; set; }
        public string RESET_FREQUENCY_2 { get; set; }
        public string EMBEDED_OPTION { get; set; }
        public Nullable<decimal> OPTION_STRIKE_PRICE { get; set; }
        public string OPTION_TYPE { get; set; }
        public string OPTION_FAMILY { get; set; }
        public string OPTION_CURRENCY { get; set; }
        public Nullable<decimal> OPTION_PREMIUM { get; set; }
        public Nullable<System.DateTime> OPTION_LOCK_PERIOD { get; set; }
        public Nullable<System.DateTime> OPTION_EXPIRATION_DATE { get; set; }
        public string PRICE_NOTATION2_TYPE { get; set; }
        public Nullable<decimal> PRICE_NOTATION2 { get; set; }
        public string PRICE_NOTATION3_TYPE { get; set; }
        public Nullable<decimal> PRICE_NOTATION3 { get; set; }
        public System.DateTime FILE_DATE { get; set; }
    
        public virtual asset_class asset_class1 { get; set; }
        public virtual indication_of_collateralization indication_of_collateralization1 { get; set; }
    }
}
