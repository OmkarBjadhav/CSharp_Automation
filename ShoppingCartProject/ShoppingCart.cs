

namespace ShoppingCartProject
{
    public class ShoppingCart
    {
        public static void Main(string[] args)
        { 
        Item itm= new Item();
        Item itm1= new Item();
            itm.id = 101;
            itm.descr = "Laptop";
            itm.quantity = 5;
            itm.price = 45000;


            itm1.id = 839;
            itm1.descr = "T Shirt";
            itm1.quantity = 4;
            itm1.price = 5000;
            //itm.PrintItemDetails(); 
            itm.PrintDiscountPrice();
            //itm1.PrintDiscountPrice();



        }
    }
}
