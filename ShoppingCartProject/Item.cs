

using Microsoft.VisualBasic;

namespace ShoppingCartProject
{
    public class Item
    {
        public int id;
        public string descr;
        public int quantity;
        public double price;
        public double finalPrice;





        public void PrintDiscountPrice()
        {
            if(quantity==2)
            {
                finalPrice = (price - (price * 10 / 100)) / quantity;
                Console.WriteLine(finalPrice+" Congratulation you Getting a 10% of Discount Please visit again");
                
            }
            else if(quantity<=5 && quantity>=3) 
            {
                finalPrice = (price - (price *15/100))/ quantity;
                Console.WriteLine(finalPrice + " Congratulation you Getting a 15% of Discount Please visit again");
            }
            else if (quantity >5)
            {
                finalPrice = (price - (price *25/100))/ quantity;
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
            Console.WriteLine(quantity);
            Console.WriteLine(price);

        }

    }
}
