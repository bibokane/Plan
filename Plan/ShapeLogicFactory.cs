using Plan.Formen;
using PlanPlan.Formen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Plan.Enum;

namespace Plan
{
    public static class ShapeLogicFactory
    {
        public static IShapeLogic GetShapeLogic(Shape shape)
        {
            // hier könnte man auch If-statement benutzen
            switch(shape)
            {
                case Shape.Wolke: return new Wolke(); 
                case Shape.Flüssigkeit: return new Flüssigkeit();
                case Shape.Feuerkugel: return new Feuerkugel();
                case Shape.Kristall: return new Kristall(); 
                case Shape.Magnet: return new Magnet(); 
                default: throw new System.NotImplementedException($"Die Forme {shape} existiert nicht.");break;
            }
        }
    }
}
