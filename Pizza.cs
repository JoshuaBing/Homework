using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_HW
{
    public abstract class Pizza
    {
        string description = "Blank";
        public virtual string getDescription()
        {
            return description;
        }

        public void setDescription(string Description)
        {
            description = Description;
        }
        public abstract double cost();
    }

    public class Small : Pizza
    {
        public Small()
        {
            setDescription("Small ");
        }
        public override double cost()
        {
            return 2.00;
        }
    }

    public class Medium : Pizza
    {
        public Medium()
        {
            setDescription("Medium ");
        }
        public override double cost()
        {
            return 3.00;
        }
    }

    public class Large : Pizza
    {
        public Large()
        {
            setDescription("Large ");
        }
        public override double cost()
        {
            return 4.00;
        }
    }
}

