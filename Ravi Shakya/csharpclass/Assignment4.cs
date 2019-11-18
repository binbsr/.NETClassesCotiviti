namespace MbaProgram
{
    public class ProgramCategory
    {
        private string[] batchDetails;

        // 1.1.Default Constructor
         public ProgramCategory(){}

        // 1.2.Parameterized Constructor
        public ProgramCategory (string[] batchList)
        {
            this.batchDetails = batchList;
        }

        //2. Two Auto Implemented Properties
        public string ProgramName {get; set;}
        public string ProgramBatch {get; set;}

        //3. A Read-Only Property Evaluated from Other Properties
        private readonly int ProgramCost = 0;
        public int GetProductCost {get { return ProgramCost;}}

        //4. A Write-Only Property
        string FirstBatchProduct;
        public string FirstBatchDetail {set {FirstBatchProduct = value ;}}


    

    }
}