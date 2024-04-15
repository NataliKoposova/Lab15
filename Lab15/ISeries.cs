using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{   
        interface ISeries
        {
            void setStart(int x);
            int getNext();
            void reset();
        }
        class ArithProgression : ISeries
        {
            int startX;
            int current;
            public int Step { get; set; }
            public int getNext()
            {
                current += Step;
                return current;
            }

            public void reset()
            {
                current = startX;
            }

            public void setStart(int x)
            {
                startX = x;
                current = startX;
            }
        }
        class GeomProgression : ISeries
        {
            int startX;
            int current;

            public int Step { get; set; }
            public int getNext()
            {
                current *= Step;
                return current;
            }

            public void reset()
            {
                current = startX;
            }

            public void setStart(int x)
            {
                startX = x;
                current = startX;
            }
        }    
}
