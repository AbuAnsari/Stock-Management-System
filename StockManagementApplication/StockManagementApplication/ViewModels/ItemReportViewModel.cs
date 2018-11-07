
namespace StockManagementApplication.ViewModels
{
    public class ItemReportViewModel
    {
        public int Serial { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public string Item { get; set; }
        public int AvailableQuantity { get; set; }
        public int ReorderLevel { get; set; }

    }
}
