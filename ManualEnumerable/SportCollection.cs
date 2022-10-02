using System;
using System.Collections.Generic;
using System.Text;

namespace ManualEnumerable
{
    class SportCollection
    {
        public Sport this[int index]
        {
            get => (Sport)index;
        }
    }
}
