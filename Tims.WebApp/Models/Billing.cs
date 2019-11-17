namespace Tims.WebApp.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Billing")]
    public class Billing 
    {
        [Key]
        [Display(Name = "Número Factura")]
        public int BillingId { get; set; }

        [Display(Name = "Número cuenta")]
        public long AccountNumber { get; set; }

        [Display(Name = "Descripción cuenta")]
        public string AccountDescription { get; set; }

        [Display(Name = "Proveedor")]
        public string Supplier { get; set; }

        [Display(Name = "Suscriptor")]
        public string Subscriber { get; set; }

        [Display(Name = "Fecha recibido factura")]
        public DateTime ReceivedInvoice { get; set; }

        [Display(Name = "Saldo Anterior")]
        public decimal PreviousBalance { get; set; }

        [Display(Name = "Forma Llegada")]
        public int ReceptionTypeId { get; set; }

        [Display(Name = "Cargo Mensual")]
        public decimal MonthlyCharge { get; set; }

        [Display(Name = "Fecha Corte")]
        public DateTime CutoffDate { get; set; }

        [Display(Name = "IVA 19%")]
        public decimal TaxBase{ get; set; }

        [Display(Name = "Impuesto al Consumo 4%")]
        public decimal ConsumptionTax { get; set; }

        [Display(Name = "Total cargo mes")]
        public decimal TotalChargeMonth { get; set; }

        [Display(Name = "Cargos Adicionales")]
        public decimal ExtraCharge { get; set; }

        [Display(Name = "Total Mes")]
        public decimal FullMonth { get; set; }

        [Display(Name = "Pago Anterior Realizado")]
        public decimal PreviouPayment { get; set; }

        [Display(Name = "Valor total factura")]
        public decimal FullPriceBill { get; set; }

        [Display(Name = "Fecha Oportuna Pago")]
        public DateTime TimelyPayment { get; set; }

        [Display(Name = "Fecha Inicio Periodo Facturado")]
        public DateTime StartDateBilledPeriod { get; set; }

        [Display(Name = "Fecha Fin Periodo Facturado")]
        public DateTime EndDateBilledPeriod { get; set; }

        public virtual ReceptionType ReceptionType { get; set; }
    }
}
