using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class DogProperties : AnimalProperties
    {
        string _owner;

        public DogProperties(string color): base(color)
        {
            
        }

        public void TransferOwnership(string owner)
        {
            _owner = owner;
        }
    }
}
