using System;



namespace gg.Model {
    public class HpPartStrategy : IPartStartegy 
    {

        private string _partNumber;
        private int _qty;

        public string PartNumber {
            get => _partNumber;
            set => _partNumber = value;
        }
        public int Qty { get => _qty; set => _qty = value; }

        public void execute() 
        {
            this.Qty = 1000;
             Console.WriteLine("Some Part task! Qty = " + Qty);

        }
    }
}