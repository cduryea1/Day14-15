using System.ComponentModel.DataAnnotations;

namespace b
{
    public class Order
    {
        [Key]
        public string Id { get; set; }

        public double subTotal { get; set; }
        public double salesTax { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id}, Subtotal: {this.subTotal:C2}";
        }

    }
}