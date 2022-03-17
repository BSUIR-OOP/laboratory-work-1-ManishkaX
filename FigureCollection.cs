using System.Collections.Generic;

namespace Lab_1
{
    class FigureCollection: List<Figure>
    {  
       public FigureCollection()
       {
            
       }


        public void Display()
        {
            foreach (Figure f in this)
            {
                f.Display();
            }
        }
    }
}
