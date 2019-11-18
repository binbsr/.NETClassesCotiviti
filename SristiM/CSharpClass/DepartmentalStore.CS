namespace DepartmentalStore {
    public class StoreDetails {
        private string[] productTypes;

        //1.Default Constructor
        public StoreDetails () { }

        //1.Parameterized Constructor
        public StoreDetails (string[] productTypesList) {
            this.productTypes = productTypesList;
        }

        //2.two auto implemented properties
        public string ProductName { get; set; }
        public string ProductExpiryDate { get; set; }

        //3.A read-only property evaluated from other properties
        //read-only property has only get
        private int ProductPrice = 0;
        public int FindProductPrice { get { return ProductPrice; } }

        //4.A write-only property
        //write-only property has only set
        string DamagedProductDetails;
        public string DamagedProduct { set { DamagedProductDetails = value; } }

        //5.A constant that can be changed at compile time
        public const int NoOfProductsforAMonth = 1000;
        int NoOfProductsforAYear = 12 * 1000;

        //6.A constant that runtime instances can modify
        public readonly int NoOfEsmitatedConsumenrsPerWeek = 1000;
        public StoreDetails (int NoCustomer) {
            NoOfEsmitatedConsumenrsPerWeek = NoCustomer;
        }

        //7.An enumeraiton list within that namespace that this class genuinely need
        enum StoreOpenDays {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        //8.A method that returns value of two properties of point 2
        public (string, string) ProdNameAndExpiryDate (string ProdName, string ExprDate) {
            ProductName = ProdName;
            ProductExpiryDate = ExprDate;
            return (ProductName, ProductExpiryDate);

        }

    }

}