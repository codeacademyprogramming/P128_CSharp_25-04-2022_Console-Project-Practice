using System;
using System.Collections.Generic;
using System.Text;
using P128HomeWork.Enums;

namespace P128HomeWork.Models
{
    class Product
    {
        private static int _count;
        public readonly string Code;
        public ProductType ProductType;
        public string Name;
        public double Price;
        public readonly double DiscountPrice;
        private static int TotalCount;

        static Product()
        {
            _count = 1000;
        }

        public Product(double price, ProductType productType)
        {
            Price = price;

            ProductType = productType;

            _count++;
            Code = $"{productType.ToString()[0]}{_count}";

            if (productType == ProductType.Bakery)
                DiscountPrice = Price - (Price / 10);

            TotalCount++;

            //switch ((int)productType)
            //{
            //    case 1:
            //        DiscountPrice = Price - (Price / 10);
            //        Code = $"B{_count}";
            //        break;
            //    case 2:
            //        Code = $"D{_count}";
            //        break;
            //    case 3:
            //        Code = $"M{_count}";
            //        break;
            //    case 4:
            //        Code = $"F{_count}";
            //        break;
            //    default:
            //        break;
            //}

        }
    }
}
