using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ManualEnumerable
{
    class PowersOfTwo : IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator()
        {
            var maxPower = Math.Round(Math.Log(int.MaxValue, 2));
            for (int power = 0; power < maxPower; power++)
            {
                yield return (int)Math.Pow(power, 2);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
