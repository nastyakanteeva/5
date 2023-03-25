using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public string name; //название
    public string companyName; // производитель
    public float price; //цена
    public double days; // срок хранения
    public int amt; // количество

    public Product()
{
    name = "Unknown";
    companyName = "Unknown";
    price = 0;
    days = 0;
    amt = 0;
       
 }
 public Product (string name, string companyName, float price, double days, int amt)
    {
        this.name = name; 
        this.companyName = companyName;
        this.price = price;
        this.days = days;
        this.amt = amt;
    }
    public void Print()
    {
        Console.WriteLine();
    }

}
