namespace RestaurantOrdersAPI
{
    public interface IDataContext
    {
        List<Customer> Customers { get; set; }
        List<Order> Orders { get; set; }
        List<Table> Tables { get; set; }

    }
}
