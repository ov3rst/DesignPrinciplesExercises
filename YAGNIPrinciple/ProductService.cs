namespace YAGNIPrinciple
{
    public class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Producto '{name}' agregado con éxito.");
        }

        public void DeleteProduct(int productId)
        {
            Console.WriteLine($"Producto '{productId}' agregado con éxito.");
        }
    }
}
