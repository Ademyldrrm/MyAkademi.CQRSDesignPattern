﻿namespace MyAkademi.CQRSDesignPattern.DAL.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<Product>Products  { get; set; }
    } 

}
