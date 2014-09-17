﻿[assembly: Serenity.Extensibility.ScriptRegistrar(typeof(BasicApplication.Northwind.DynamicScripts))]

namespace BasicApplication.Northwind
{
    using Entities;
    using Serenity.Data;
    using Serenity.Web;

    public static class DynamicScripts
    {
        public static IDynamicScript Category =
            new DbLookupScript<CategoryRow>(
                name: "Northwind.Category",
                getItems: cnn =>
                {
                    var fld = CategoryRow.Fields;
                    return cnn.List<CategoryRow>(q => q.Select(
                        fld.CategoryID,
                        fld.CategoryName));
                });

        public static IDynamicScript Region =
            new DbLookupScript<RegionRow>(
                name: "Northwind.Region",
                getItems: cnn =>
                {
                    var fld = RegionRow.Fields;
                    return cnn.List<RegionRow>(q => q.Select(
                        fld.RegionID,
                        fld.RegionDescription));
                });

        public static IDynamicScript Supplier =
            new DbLookupScript<SupplierRow>(
                name: "Northwind.Supplier",
                getItems: cnn =>
                {
                    var fld = SupplierRow.Fields;
                    return cnn.List<SupplierRow>(q => q.Select(
                        fld.SupplierID,
                        fld.CompanyName));
                });

        public static IDynamicScript Territory =
            new DbLookupScript<TerritoryRow>(
                name: "Northwind.Territory",
                getItems: cnn =>
                {
                    var fld = TerritoryRow.Fields;
                    return cnn.List<TerritoryRow>(q => q.Select(
                        fld.ID,
                        fld.TerritoryID,
                        fld.TerritoryDescription,
                        fld.RegionDescription));
                });
    }
}