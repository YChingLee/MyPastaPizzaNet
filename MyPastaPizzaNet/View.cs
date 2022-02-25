using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPastaPizzaNet
{
    public class View
    {
        public object Data { get; set; }
        public string LineBreak = new string('=', 60);

        public View(object data)
        {
            Data = data;
        }

        public virtual StringBuilder Render()
        {
            var output = new StringBuilder();
            output.AppendLine(Data.ToString());
            return output;
        }

        
    }
}
