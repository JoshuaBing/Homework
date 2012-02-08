using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_HW
{
    public abstract class Crust : Pizza
    {
        public override abstract string getDescription();

    }


    public class DeepDish : Crust
    {
        Pizza mSize;
        public DeepDish(Pizza theSize)
        {
            mSize = theSize; 
        }
        public override double cost()
        {
            return 4.00  + mSize.cost();
        }
        public override string getDescription()
        {
            return mSize.getDescription() + " DeepDish";
        }
    }
    public class ThinCrust : Crust
    {
        Pizza mSize;
        public ThinCrust(Pizza theSize)
        {
            mSize = theSize;
        }
        public override double cost()
        {
            return 3.25 + mSize.cost();
        }

        public override string getDescription()
        {
            return mSize.getDescription() + " Thin Crust";
        }

    }

    public class Chicago : Crust
    {
        Pizza mSize;
        public Chicago(Pizza theSize)
        {
            mSize = theSize;
        }
        public override double cost()
        {
            return 3.50 + mSize.cost();
        }
        public override string getDescription()
        {
            return mSize.getDescription() + " Chicago-Style";
        }
    }

    public class Artisan : Crust
    {
        Pizza mSize;
        public Artisan(Pizza theSize)
        {
            mSize = theSize;
        }
        public override double cost()
        {
            return 4.99 + mSize.cost();
        }
        public override string getDescription()
        {
            return mSize.getDescription() + " Artisan";
        }
    }

    public class Standard : Crust
    {
        Pizza mSize;
        public Standard(Pizza theSize)
        {
            mSize = theSize;
        }
        public override double cost()
        {
            return 1.99 + mSize.cost();
        }
        public override string getDescription()
        {
            return mSize.getDescription() + " Standard";
        }
    }

}
