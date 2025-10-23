using OOPsDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        //Create classes in library
       Computers comp=new Computers();
        comp.ProductId = 101;
        comp.ProductName = "Laptop";
        comp.RAMCapacity = 16;
        comp.HDD = 25;
        Accessories accessories = new Accessories();    
        accessories.MousePad = true;
        accessories.Mouse = true;
        accessories.Bag = true;
        accessories.HDMICable = true;   
        comp.GetAccessories = accessories;
       
       
        

        Cart cart=new Cart();
        double amt=cart.AddToCart(comp);
        Console.WriteLine($"Total cost= {amt}");






    }
}