using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ManualEnumerable
{
    class BetterSportSequence : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator()
        {
            int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1;
            for (int i = 0; i < maxEnumValue; i++)
            {
                yield return (Sport)i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
