using System;
using System.Collections.Generic;
using APP.Models.BaseModelsEntities;

namespace APP.DB.Models
{
    /// <summary>
    ///     Продукты.
    /// </summary>
    public class Product : BaseMetaInformation
    {
        /// <summary>
        ///     Описание.
        /// </summary>
        public string FullDescription { get; set; }

        /// <summary>
        ///     Краткое описание.
        /// </summary>
        public string SmallDescription { get; set; }

        /// <summary>
        ///     Теги товара.
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        ///     Цена товара.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Акция.
        /// </summary>
        public decimal Stock { get; set; }

        /// <summary>
        /// Дата начала акции.
        /// </summary>
        public DateTime DataStartStock { get; set; }
        
        /// <summary>
        /// Дата окончания акции.
        /// </summary>
        public DateTime DataEndStock { get; set; }
        
        /// <summary>
        ///     Количество.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        ///     Вес товара.
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        ///     Производитель.
        /// </summary>
        public Manufacturer Manufacturer { get; set; }

        /// <summary>
        ///     В какой категории находится товар.
        /// </summary>
        public Category Categories { get; set; }

        /// <summary>
        ///     Рекомендуемые товары.
        /// </summary>
        public List<Product> RecomendedProducts { get; set; }

        /// <summary>
        ///     Главное изображение.
        /// </summary>
        public Picture Picture { get; set; }

        /// <summary>
        ///     Изображения
        /// </summary>
        public List<Picture> Pictures { get; set; }

        /// <summary>
        ///     Характеристики.
        /// </summary>
        public Dictionary<string, string> Characteristics { get; set; }
    }
}