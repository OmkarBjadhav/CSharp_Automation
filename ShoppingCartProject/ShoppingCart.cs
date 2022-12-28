

namespace ShoppingCartProject
{
    public class ShoppingCart
    {
        public static void Main(string[] args)
        {
            Item itm = new Item(8);
            Item itm1 = new Item(9);
            itm.id = 101;
            itm.descr = "Laptop";
            itm.Quantity = 5;
            itm.price = 45000;


            itm1.id = 839;
            itm1.descr = "T Shirt";
            itm1.Quantity = 4;
            itm1.price = 5000;


            itm.PrintItemDetails();
            itm1.PrintDiscountPrice();
            itm.PrintDiscountPrice();
            itm1.PrintDiscountPrice();



        }
    }
}
