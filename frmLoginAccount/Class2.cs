namespace frmLoginAccount
{
    internal class DiscountedItem : Item
    {
        private double itemDiscount;
        private double discountedPrice;
        private double paymentAmount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            this.itemDiscount = discount;
            discountedPrice = 0;
            paymentAmount = 0;
            change = 0;
        }

        public override double getTotalPrice()
        {
            discountedPrice = itemPrice * (1 - itemDiscount);
            totalPrice = discountedPrice * itemQuantity;
            return totalPrice;
        }

        public override void setPayment(double amount)
        {
            paymentAmount = amount;
        }

        public double getChange(double totalAmount)
        {
            change = paymentAmount - totalAmount;
            return change;
        }
    }
}