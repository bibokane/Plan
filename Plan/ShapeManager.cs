using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Plan.Enum;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Plan
{
    public class ShapeManager
    {
        public Shape currentShape;
        private IShapeLogic shapeLogic;

        public float speed;
        public float jumpForce;
        //private Rigidbody2D rb;

        void Start()
        {
            
        }

        void Update()
        {
            // Bewegung
            /*if ()
            {
                
            }*/

            // Sprung

            /*if() 
            {
                
            }*/
        }

        public void SetShape(Shape newShape)
        {
            currentShape = newShape;
            shapeLogic = ShapeLogicFactory.GetShapeLogic(currentShape);
        }

        /* Da die Formen je nach Level freigeschaltet werden, sollte man 
         * diese in ChangeShape() berücksichtigen */
        public void ChangeShape()
        {
           /* if ()
            {
                SetShape(Shape.Flüssigkeit);
            }
            else if ()
            {
                SetShape(Shape.Feuerkugel);
            }
            else if ()
            {
                SetShape(Shape.Kristall);
            }
            else if()
            {
                SetShape(Shape.Magnet);
            }*/
        }
    }
}
