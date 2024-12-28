using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan
{
    // Die Schnittstelle, die das Verhalten jedes Form vorgibt. Sie kann verbessert werden
    public interface IShapeLogic
    {
        void Move();
        void Jump();
    }
}
