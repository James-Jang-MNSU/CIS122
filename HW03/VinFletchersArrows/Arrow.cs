// Written by James Jang
// 02/11/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    public class Arrow
    {
        // class variables
        public enum ArrowHead { Steel = 10, Wood = 3, Obsidian = 5 };
        public enum Fletching { Plastic = 10, TurkeyFeathers = 5, GooseFeathers = 3 };
        private int shaftLength;
        private ArrowHead headType;
        private Fletching fletchingType;
        
        // gets and sets
        public int ShaftLength
        {
            get { return this.shaftLength; }
        }
        public ArrowHead HeadType
        {
            get { return this.headType; } 
        }
        public Fletching FletchingType
        {
            get { return this.fletchingType; }
        }

        // constructor
        public Arrow(string arrowHeadType, int arrowShaftLength, string arrowFletching)
        {
            this.shaftLength = arrowShaftLength;
            this.headType = arrowHeadType switch
            {
                "steel" => ArrowHead.Steel,
                "wood" => ArrowHead.Wood,
                "obsidian" => ArrowHead.Obsidian
            };
            this.fletchingType = arrowFletching switch
            {
                "plastic" => Fletching.Plastic,
                "turkey feathers" => Fletching.TurkeyFeathers,
                "goose feathers" => Fletching.GooseFeathers
            };
        }

        public double GetCost()
        {
            return (int)FletchingType + (int)HeadType + ShaftLength * 0.05;
        }
    }
}
