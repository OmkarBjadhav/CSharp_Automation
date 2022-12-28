

using Microsoft.VisualBasic;

namespace ShoppingCartProject
{
    public class Item
    {
        public int id;
        public string descr;
        private int _quantity;
        public double price;
        public double finalPrice;

        //public Item()
        //{

        //    _quantity = 1;
        //    Console.WriteLine("Object is created ");

        //}

        public Item(int quantity)
        {

            this._quantity = quantity;
        }
      public int Quantity
        {
            set 
            {
                if(value > 0)
                {
                    _quantity=value;
                }
                else
                {
                    Console.WriteLine("The invalid quantity");
                }
                
            }
        }







        public void PrintDiscountPrice()
        {
            if (_quantity == 2)
            {
                finalPrice = (price - (price * 10 / 100)) / _quantity;
                Console.WriteLine(finalPrice + " Congratulation you Getting a 10% of Discount Please visit again");

            }
            else if (_quantity <= 5 && _quantity >= 3)
            {
                finalPrice = (price - (price * 15 / 100)) / _quantity;
                Console.WriteLine(finalPrice + " Congratulation you Getting a 15% of Discount Please visit again");
            }
            else if (_quantity > 5)
            {
                finalPrice = (price - (price * 25 / 100)) / _quantity;
                Console.WriteLine(finalPrice + " Congratulation you Getting a 25% of Discount Please visit again");
            }
            else
            {
                Console.WriteLine("Not Applicable for Discount ");
            }

        }
        public void PrintItemDetails()
        {
            Console.WriteLine("************* Item Details *****************");
            Console.WriteLine(id);
            Console.WriteLine(descr);
            Console.WriteLine(_quantity);
            Console.WriteLine(price);

        }

    }
}
