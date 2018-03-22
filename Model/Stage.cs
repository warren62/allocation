using System;

namespace gg.Model
{
    public class Stage
    {
        private string _name;
        private double _time;
        private int _sequence;
        private string _nextStage;
        private string _previousStage;
        private IStageStrategy _stageStrategy;

       

        public string Name {
            get => _name;
            set => _name = value;
        }


        public double Time {
            get => _time;
            set => _time = value;
        }



        public int Sequence {
            get => _sequence;
            set => _sequence = value;
        }



        public string NextStage {
            get => _nextStage;
            set => _nextStage = value;
        }


        public string PreviousStage {
            get => _previousStage;
            set => _previousStage = value;
        }

        public IStageStrategy StageStrategy {
            get => _stageStrategy;
            set => _stageStrategy = value;
        }

        





        public void executeStrategy()
        {

            _stageStrategy.allocate();

        }
    }
}