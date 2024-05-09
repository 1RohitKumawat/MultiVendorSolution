using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;

namespace Nop.Data.Migrations;

[NopMigration("2024/04/18 15:46:55:1687541", "Update: Customer Table", MigrationProcessType.Update)]
public class AddCustomerTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Column(nameof(Customer.NickName))
        .OnTable(nameof(Customer))
        .AsString(200)
        .Nullable();

        //Create.Column(nameof(Category.ShortDescription))
        //.OnTable(nameof(Category))
        //.AsString(200)
        //.Nullable();
    }
}
