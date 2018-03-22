using System.Collections.Generic;

namespace gg.Model {
    public class Part {
        private string _partNumber;
        private List<Stage> _stages;
        
        private IPartStartegy _partStartegy;

        public string PartNumber {
            get => _partNumber;
            set => _partNumber = value;
        }


        public List<Stage> Stages {
            get => _stages;
            set => _stages = value;
        }


        public IPartStartegy PartStartegy {
            get => _partStartegy;
            set => _partStartegy = value;
        }


    }
}