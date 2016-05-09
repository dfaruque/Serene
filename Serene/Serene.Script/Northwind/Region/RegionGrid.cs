﻿
namespace Serene.Northwind
{
    using jQueryApi;
    using Serenity;
    using System.Runtime.CompilerServices;

    [Imported]
    [ColumnsKey("Northwind.Region"), IdProperty("RegionID"), NameProperty("RegionDescription")]
    [DialogType(typeof(RegionDialog)), LocalTextPrefix("Northwind.Region"), Service("Northwind/Region")]
    public class RegionGrid : EntityGrid<RegionRow>
    {
        public RegionGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}