using Cookbook.Domain.Entities;
using SQLite;
using System;
using System.IO;

namespace Cookbook.Infrastructure.DataAccess
{
    public sealed class DatabaseInitializer : IDatabaseInitializer
    {
        private static readonly string DatabasePath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "cookbook.db3");

        public void Initialize()
        { 
            var connection = new SQLiteConnection(DatabasePath);

            connection.CreateTable<Recipe>();
        }
    }
}
