using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_HW
{
    public abstract class Topping : Pizza
    {
        public override abstract string getDescription();

    }

    public class Pepperoni : Topping
    {
        Pizza mPizza;
        public Pepperoni(Pizza thePizza)
        {
            mPizza = thePizza;
            
        }
        public override string getDescription()
        {
            return mPizza.getDescription() + ", Pepperoni";
        }
        public override double cost()
        {
            return .50 + mPizza.cost();
        }
    }
    public class Onion : Topping
    {
        Pizza mPizza;
        public Onion(Pizza thePizza)
        {
            mPizza = thePizza;

        }
        public override string getDescription()
        {
            return mPizza.getDescription() + ", Onion";
        }
        public override double cost()
        {
            return .50 + mPizza.cost();
        }
    }

    public class Pineapple : Topping
    {
        Pizza mPizza;
        public Pineapple(Pizza thePizza)
        {
            mPizza = thePizza;

        }
        public override string getDescription()
        {
            return mPizza.getDescription() + ", Pineapple";
        }
        public override double cost()
        {
            return .75 + mPizza.cost();
        }
    }

    public class Ham : Topping
    {
        Pizza mPizza;
        public Ham(Pizza thePizza)
        {
            mPizza = thePizza;

        }
        public override string getDescription()
        {
            return mPizza.getDescription() + ", Ham";
        }
        public override double cost()
        {
            return 1.00 + mPizza.cost();
        }
    }

    public class Jalepeno : Topping
    {
        Pizza mPizza;
        public Jalepeno(Pizza thePizza)
        {
            mPizza = thePizza;

        }
        public override string getDescription()
        {
            return mPizza.getDescription() + ", Jalepeno";
        }
        public override double cost()
        {
            return .50 + mPizza.cost();
        }
    }

}
