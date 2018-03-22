using System;
using gg.Model;
using System.Collections.Generic;

namespace gg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Part part = new Part();
            Part part1 = new Part();
            Part part2 = new Part();
            Part part3 = new Part();

            

            WIP w = new WIP();
            w.Part = new Part();
            w.Part.PartNumber = "Part1";
            
            List<Stage> stages = new List<Stage>();
            
            stages.Add(new Stage());
            stages[0].Name = "KITTING";
            stages[0].NextStage = "MANUFACTURING";
            stages[0].Sequence = 0;
            stages[0].Time = 1.0;
            HpStageStrategycs ks = new HpStageStrategycs();
            ks.Part = w.Part;
            ks.PartNumber = w.Part.PartNumber;
            stages[0].StageStrategy = ks;

            stages.Add(new Stage());
            stages[1].Name = "MANUFACTURING";
            stages[1].NextStage = "TEST";
            stages[1].PreviousStage = "KITTING";
            stages[1].Sequence = 1;
            stages[1].Time = 1.0;
            HpStageStrategycs ks1 = new HpStageStrategycs();
            ks1.Part = w.Part;
            ks1.PartNumber = w.Part.PartNumber;
            stages[1].StageStrategy = ks1;

            w.Part.Stages = stages;

            HpPartStrategy wp = new HpPartStrategy();
            wp.PartNumber = w.Part.PartNumber;
            w.Part.PartStartegy = wp;
            w.Barcode = "666";
            w.CurrentStage = w.Part.Stages[1];
            // w.CurrentStage = new Stage();
            // w.CurrentStage.Name = "TEST";
            // w.CurrentStage.NextStage = "FQC";
            // w.CurrentStage.PreviousStage = "MANUFACTURING";
            // w.CurrentStage.Sequence = 2;
            // HpStageStrategycs ws = new HpStageStrategycs();

            // ws.PartNumber = w.Part.PartNumber;
            // ws.Stage = w.CurrentStage;
            // w.CurrentStage.StageStrategy = ws;
            w.ItemNo = 1;
            w.Release = 0;
            w.So = 777;

            WIP w1 = new WIP();
            w1.Part = new Part();
            w1.Barcode = "666";
            w1.CurrentStage = new Stage();
            w1.ItemNo = 1;
            w1.Release = 0;
            w1.So = 777;
            WIP w2 = new WIP();
            w2.Part = new Part();
            w2.Barcode = "666";
            w2.CurrentStage = new Stage();
            w2.ItemNo = 1;
            w2.Release = 0;
            w2.So = 777;
            WIP w3 = new WIP();
            w3.Part = new Part();
            w3.Barcode = "666";
            w3.CurrentStage = new Stage();
            w3.ItemNo = 1;
            w3.Release = 0;
            w3.So = 777;
            

            
            
            List<WIP> wips = new List<WIP>();
            wips.Add(w);

            foreach (var p in wips) {

                p.Part.PartStartegy.execute();
                p.CurrentStage.StageStrategy.allocate();

                

            }


            

            
        }
    }
}
