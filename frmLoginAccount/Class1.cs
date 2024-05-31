namespace frmLoginAccount
{
    internal class Item
    {
        protected string itemName;
        protected double itemPrice;
        protected int itemQuantity;
        protected double totalPrice;

        public Item(string name, double price, int quantity)
        {
            itemName = name;
            itemPrice = price;
            itemQuantity = quantity;
            totalPrice = 0;
        }

        public virtual double getTotalPrice()
        {
            totalPrice = itemPrice * itemQuantity;
            return totalPrice;
        }

        public virtual void setPayment(double amount) { }
    }
}