﻿using APP.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace APP.DB
{
    /// <summary>
    ///     Контекст Админ-панели.
    /// </summary>
    public class PanelContext : DbContext
    {
        /// <summary>
        ///     Статьи.
        /// </summary>
        public DbSet<Articles> Articleses { get; set; }

        /// <summary>
        ///     Статьи блога.
        /// </summary>
        public DbSet<BlogArticle> BlogArticles { get; set; }

        /// <summary>
        ///     Категории Блога.
        /// </summary>
        public DbSet<BlogCategory> BlogCategory { get; set; }

        /// <summary>
        ///     Отзывы отзыва.
        /// </summary>
        public DbSet<BlogReview> BlogReviews { get; set; }

        /// <summary>
        ///     Категории.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        ///     Производители.
        /// </summary>
        public DbSet<Manufacturer> Manufacturers { get; set; }

        /// <summary>
        ///     Изображения.
        /// </summary>
        public DbSet<Picture> Pictures { get; set; }

        /// <summary>
        ///     Товары.
        /// </summary>создла
        public DbSet<Product> Products { get; set; }

        /// <summary>
        ///     Отзывы.
        /// </summary>
        public DbSet<Review> Reviews { get; set; }
    }
}