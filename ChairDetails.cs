namespace DesignPattern
{
    public class ChairDetails
    {
        //Abstract product
        public abstract class AbstractChair
        {
            public abstract string Name(string name);
            public abstract string Color(string color);
            public abstract int Height(int height);
            public abstract int Width(int width);
            public abstract string Type();

        }

        //Anyone who is using abstarct factory is bound to use this method GetChair
        public abstract class AbstractFactory
        {
            public abstract AbstractChair GetChair();
        }

        //Concrete classes
        // concrete class inherit abstract chair

        public class ArmChair : AbstractChair
        {
            public override string Color(string color)
            {
                return color;
            }

            public override int Height(int height)
            {
                return height;
            }

            public override string Name(string name)
            {
                return name;
            }

            public override string Type()
            {
                return "ArmChair";
            }

            public override int Width(int width)
            {
                return width;
            }
        }

        public class ReclinerChair : AbstractChair
        {
            public override string Color(string color)
            {
                return color;
            }

            public override int Height(int height)
            {
                return height;
            }

            public override string Name(string name)
            {
                return name;
            }

            public override string Type()
            {
                return "ReclinerChair";
            }

            public override int Width(int width)
            {
                return width;
            }
        }

        public class RockingChair : AbstractChair
        {
            public override string Color(string color)
            {
                return color;
            }

            public override int Height(int height)
            {
                return height;
            }

            public override string Name(string name)
            {
                return name;
            }

            public override string Type()
            {
                return "RockingChair";
            }

            public override int Width(int width)
            {
                return width;
            }
        }

        public class ArmchairFactory : AbstractFactory
        {
            public override AbstractChair GetChair()
            {
                return new ArmChair();
            }
        }

        public class ReclinerFactory : AbstractFactory
        {
            public override AbstractChair GetChair()
            {
                return new ReclinerChair();
            }
        }

        public class RockingFactory : AbstractFactory
        {
            public override AbstractChair GetChair()
            {
                return new RockingChair();
            }
        }

        public class FactorySelector
        {
            public AbstractFactory Selector(int pref)
            {
                switch (pref)
                {
                    case 1:
                        return new ArmchairFactory();
                    case 2:
                        return new ReclinerFactory();
                    default:
                        return new RockingFactory();
                }

            }
        }




    }
}
