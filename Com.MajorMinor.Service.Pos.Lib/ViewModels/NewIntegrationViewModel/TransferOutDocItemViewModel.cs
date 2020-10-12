using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MajorMinor.Service.Pos.Lib.ViewModels.NewIntegrationViewModel
{
    public class TransferOutDocItemViewModel
    {
        public string articleRealizationOrder { get; set; }

        public ItemViewModel item { get; set; }

        public double quantity { get; set; }

        public string remark { get; set; }
    }
}
