namespace Tims.WebApp.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Billing")]
    public class Billing 
    {
        [Key]
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

        //public int ReceptionTypeId { get; set; }
        //public virtual ReceptionType ReceptionType { get; set; }

    }
}
