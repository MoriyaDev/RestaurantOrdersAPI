namespace RestaurantOrdersAPI
{
    public class DataContext : IDataContext
    {
       public List<Customer> Customers { get; set; }
       public List<Order> Orders { get; set; }
       public List<Table> Tables { get; set; }


        public DataContext()
        {
            Customers=new List<Customer>{
             new Customer{Id=1,Name="moiya",Phone="0583253905",NumberOfPeople=6},
             new Customer{Id=2,Name="Itamar",Phone="098856088",NumberOfPeople=2}
            };

            Customers = new List<Customer>{
             new Customer{Id=1,Name="moiya",Phone="0583253905",NumberOfPeople=6},
             new Customer{Id=2,Name="Itamar",Phone="098856088",NumberOfPeople=2}
            };

            Customers = new List<Customer>{
             new Customer{Id=1,Name="moiya",Phone="0583253905",NumberOfPeople=6},
             new Customer{Id=2,Name="Itamar",Phone="098856088",NumberOfPeople=2}
            };

        }


    }
}
