using System;
using TesteCsharp.Services.Database;
using System.Diagnostics;
using System.Text.Json;
using System.Collections.Generic;

namespace TesteCsharp.Domain.UseCase.Stock
{
    public class CreateStockInput
    {
        public string Name { get; set; }
    }

    public class CreateStock
    {
        public static Model.Stock handle(CreateStockInput payload)
        {
            string uuid = Guid.NewGuid().ToString();

            var connection = SqliteService.ConnectDB("exchange.db");

            SqliteService.Query(connection, "INSERT INTO stocks (id, name, created_at) VALUES ($id, $name, $created_at)", new {
                id = uuid,
                name = payload.Name,
                created_at = DateTime.UtcNow.ToString("o"),
            });

            var result = SqliteService.Query(connection, "select * from stocks where id = $id limit 1;", new { id = uuid });

            SqliteService.DisconnectDB(connection);

            var mapper = ConfigMapper.Handle();

            return mapper.Map<Model.Stock>(result[0]);
        }
    }
}
