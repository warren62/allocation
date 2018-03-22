using System;



namespace gg.Model
{
    public class WIP
    {
        private Part _part;
        private string _barcode;

        private int _so;

        private int _itemNo;

        private int _release;


        private Stage _currentStage;

        private DateTime _shipDate;

        private DateTime _projectedShipDate;



        public Part Part {
            get => _part;
            set => _part = value;
        }

        public string Barcode {
            get => _barcode;
            set => _barcode = value;
        }

        public int So {
            get => _so;
            set => _so = value;
        }


        public int ItemNo {
            get => _itemNo;
            set => _itemNo = value;
        }

        public int Release {
            get => _release;
            set => _release = value;
        }


        public Stage CurrentStage {
            get => _currentStage;
            set => _currentStage = value;
        }

        public DateTime ShipDate {
            get => _shipDate;
            set => _shipDate = value;
        }

        
        public DateTime ProjectedShipDate {
            get => _projectedShipDate;
            set => _projectedShipDate = value;
        }

        
    }
}