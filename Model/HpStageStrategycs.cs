using System;
using System.Collections.ObjectModel;

namespace gg.Model {
    public class HpStageStrategycs : IStageStrategy {

        private int _soQty;
        private string _partNumber;

        private Part _part;

        private Stage _stage;
        private int _allocatedQty;
        private int _balance;

        private DateTime _shipDate;

        private DateTime _projectedShipDate;

        static int[] itemSize;
        static int[] bagFreeSpace;
        static bool[, ] doesBagContainItem;

        public Part Part {
            get => _part;
            set => _part = value;
        }

        public Stage Stage {
            get => _stage;
            set => _stage = value;
        }

        public string PartNumber {
            get => _partNumber;
            set => _partNumber = value;
        }

        public int SoQty {
            get => _soQty;
            set => _soQty = value;
        }

        public int AllocatedQty {
            get => _allocatedQty;
            set => _allocatedQty = value;
        }

        public int Balance {
            get => _balance;
            set => _balance = value;
        }

        public DateTime ShipDate {
            get => _shipDate;
            set => _shipDate = value;
        }

        public DateTime ProjectedShipDate {
            get => _projectedShipDate;
            set => _projectedShipDate = value;
        }
        public static bool[,] DoesBagContainItem { get => doesBagContainItem; set => doesBagContainItem = value; }

        public void allocate () {

            //double qty = this.SoQty - this.AllocatedQty;
            itemSize = new int[] { 60, 60, 60, 30, 30, 30, 20, 20, 20, 20, 20, 20, 10, 70, 5, 1 };
            bagFreeSpace = new int[] { 100, 100, 100, 100, 100 };
            DoesBagContainItem = new bool[bagFreeSpace.Length, itemSize.Length];

            if (!pack (0))
                Console.WriteLine ("No solution");

            Console.Write ("Part:  " + this.Part.PartNumber + " " + this.Part.Stages.Count);

        }


        static bool pack (int item) {
            // output the solution if we're done
            if (item == itemSize.Length) {
                for (int i = 0; i < bagFreeSpace.Length; i++) {
                    Console.WriteLine ("bag" + i);
                    for (int j = 0; j < itemSize.Length; j++)
                        if (DoesBagContainItem[i, j])
                            Console.Write ("item" + j + "(" + itemSize[j] + ") ");
                    Console.WriteLine ();
                }
                return true;
            }

            // otherwise, keep traversing the state tree
            for (int i = 0; i < bagFreeSpace.Length; i++) {
                if (bagFreeSpace[i] >= itemSize[item]) {
                    DoesBagContainItem[i, item] = true; // put item into bag
                    bagFreeSpace[i] -= itemSize[item];
                    if (pack (item + 1)) // explore subtree
                        return true;
                    bagFreeSpace[i] += itemSize[item]; // take item out of the bag
                    DoesBagContainItem[i, item] = false;
                }
            }

            return false;
        }

        
    }
}