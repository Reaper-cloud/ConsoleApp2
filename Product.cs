using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Product
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract string GetInformation();
    }

    
    public class Toy : Product
    {
        public override string Name => "Toy";
        private decimal basePrice = 20.00m;

        public override decimal Price
        {
            get
            {
                return basePrice;
            }
        }

        public string Type { get; set; }

        public Toy(string type)
        {
            Type = type;
        }

        public override string GetInformation()
        {
            return $"Product: {Name}, Type: {Type}, Price: {Price:C}";
        }
    }

    
    public class Meat : Product
    {
        public override string Name => "Meat";
        private decimal basePrice = 15.00m;

        public override decimal Price
        {
            get
            {
                return basePrice;
            }
        }

        public string Cut { get; set; }

        public Meat(string cut)
        {
            Cut = cut;
        }

        public override string GetInformation()
        {
            return $"Product: {Name}, Cut: {Cut}, Price: {Price:C}";
        }
    }

    
    public class Drinks : Product
    {
        public override string Name => "Drinks";
        private decimal basePrice = 5.00m;

        public override decimal Price
        {
            get
            {
                return basePrice;
            }
        }

        public string Volume { get; set; }

        public Drinks(string volume)
        {
            Volume = volume;
        }

        public override string GetInformation()
        {
            return $"Product: {Name}, Volume: {Volume}, Price: {Price:C}";
        }
    }

    
    public class Clothing : Product
    {
        public override string Name => "Clothing";
        private decimal basePrice = 50.00m;

        public override decimal Price
        {
            get
            {
                return basePrice;
            }
        }

        public string Size { get; set; } 

        public Clothing(string size)
        {
            Size = size;
        }

        public override string GetInformation()
        {
            return $"Product: {Name}, Size: {Size}, Price: {Price:C}";
        }
    }

    
    public class Electronics : Product
    {
        public override string Name => "Electronics";
        private decimal basePrice = 300.00m;

        public override decimal Price
        {
            get
            {
                return basePrice;
            }
        }

        public string Warranty { get; set; } 

        public Electronics(string warranty)
        {
            Warranty = warranty;
        }

        public override string GetInformation()
        {
            return $"Product: {Name}, Warranty: {Warranty}, Price: {Price:C}";
        }
    }
   }