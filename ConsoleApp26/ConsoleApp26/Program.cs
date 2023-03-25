using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    static List<Product> products=new List<Product>();
    static void Main(string[] args)
    {
        addProducts();
        string name = Console.ReadLine();
        foreach(Product product in products)
        {
            if(product.name == name)
            {
                Console.WriteLine(product.name);
            }
        }
        int price = Convert.ToInt32(Console.ReadLine());
        foreach(Product product in products)
        {
            if(product.price <= price)
            {
                Console.WriteLine(product.name);
            }
        }
        int days = Convert.ToInt32(Console.ReadLine());
        foreach(Product product in products)
        {
            if(product.days >= days)
            {
                Console.WriteLine(product.name);
            }
        }
    }
    static void addProducts()
    {
        products.Add(new Product("Колбаса","Черкизово",350,31,200));
        products.Add(new Product("Молоко", "ЭкоНива", 100, 20, 387));
        products.Add(new Product("Хлеб", "Хлебозовод", 50, 15, 450));
    }
    
}