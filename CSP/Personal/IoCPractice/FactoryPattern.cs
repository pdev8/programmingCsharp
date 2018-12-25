namespace CSP.Personal.IoCPractice
{
    public class FactoryPattern
    {
        public class CustomerBusinessLogic
        {
            ////private readonly DataAccess dataAccess;

            public CustomerBusinessLogic()
            {   
                // Creates a concrete class of DataAccess, thus this creates a dependency to that class
                ////this.dataAccess = new DataAccess();
            }

            public string GetCustomerName(int id)
            {
                // Uses Factory class to retrieve object
                var dataAccess = DataAccessFactory.GetDataAccessObj();

                return dataAccess.GetCustomerName(id);
            }
        }

        public class DataAccess
        {
            public string GetCustomerName(int id) => "Dummy Customer Name";
        }

        public class DataAccessFactory
        {
            public static DataAccess GetDataAccessObj() => new DataAccess();
        }
    }
}