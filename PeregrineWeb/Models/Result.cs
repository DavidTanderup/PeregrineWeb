//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeregrineWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Result
    {
        public int ResultID { get; set; }
        public System.DateTime Date { get; set; }
        public int CIK { get; set; }
        public string Symbol { get; set; }
        public string Last_Close { get; set; }
        public string C50_Day_Avg { get; set; }
        public string MACD { get; set; }
        public string MACD_Signal { get; set; }
        public string EMA_12 { get; set; }
        public string EMA_26 { get; set; }
        public string Stochastic_Fast { get; set; }
        public string Stochastic_Slow { get; set; }
        public string Stochastic_Signal { get; set; }
    }
}
