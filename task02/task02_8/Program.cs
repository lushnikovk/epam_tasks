using System;

namespace task02_8
{


    public struct Point
    {
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double x { get; set; }
        public double y { get; set; }
        public static double GetLenght( Point point1, Point point2)
        {
                return Math.Sqrt(((point2.x - point1.x) * (point2.x - point1.x) + ((point2.y - point1.y) * (point2.y - point1.y))));
        }
    }
    //
    /// <summary>
    /// Pos - разположение объекта на поле 
    /// type - тип объекта
    /// </summary>
   
    //

    abstract class Object
    {
        public string type;
        public Point Pos { get; set; }
        public Object (string type,Point Pos)
        {
            this.type = type;
            this.Pos = Pos;
        }
    }
    /// <summary>
    /// Класс Unit с полями типа, расположения, урона юнита, здоровья, брони и скорости. 
    /// </summary>
    abstract class Unit : Object
    {
        private double damageUnit, health, armor, speed;
        public Unit(string type, Point pos, double DamageUnit, double Health, double Armor, double Speed) : base(type, pos)
        {

        }
        public double DamageUnit
        {
            get
            {
                return damageUnit;
            }
            set
            {
                if (value > 0)
                    damageUnit = value;
                else
                    value = 0;
                damageUnit = value;
            }
        }
        public double Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value >= 0)
                    health = value;
                else throw new ArgumentException("Здоровье не может быть отрицательным. А если оно равно нулю, то вы мертвы");
            }
        }
        public double Armor
        {
            get
            {
                return armor;
            }
            set
            {
                if (value >= 0)
                    armor = value;
                else
                    value = 0;
                armor = value;
            }
        }
        public double Speed
        {
            get
            {
                return speed;

            }
            set
            {
                if (value >= 0)
                    speed = value;
                else throw new ArgumentException("Скорость не может быть отрицательной");
            }
        }

        /// <summary>
        /// Методы класса Unit
        /// </summary>
        

        public  void damagetaken(double damage)
        {
            
            double ReducedArmor = Armor * 0.01;
            double newDamage = damage * ReducedArmor;
            Health = Health - damage;
        }
        public void Treatment(Unit unit )
        {
             unit.Health = unit.Health + health; 

        }
        public abstract void Move();


    }


    /// <summary>
    /// Абстрактный класс препядствий
    /// </summary>

    abstract class Barrier : Object
    {
        private double damage;
        public Barrier(string type, Point Pos, double Damage) : base(type, Pos)
        {
            this.Damage = Damage;
        }
        public double Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 0)
                    damage = value;
                else throw new ArgumentException("урон не может быть отрицательным");
            }
        }

        public virtual void DamagefromBarrier(Unit Object)
        {

        }
    }
        /// <summary>
        /// Классы с преградами , наслдуемые от абстрактного класса Barrier
        /// </summary>
     
        class Mines : Barrier
        {
            public Mines(double Health, Point Pos, int Damage) : base(type: "Mines", Pos, Damage)
            {

            }

            public override void DamagefromBarrier(Unit Object)
            {
                int damage = (int)Math.Round(Damage);
                Object.damagetaken(damage);

            }

        }
        class Stone : Barrier
        {
            public Stone(double Health, Point Pos, int Damage) : base(type: "Stone", Pos, Damage)
            {

            }

            public override void DamagefromBarrier(Unit Object)
            {
                int damage = (int)Math.Round(Damage);
                Object.damagetaken(damage);

            }
        }

        /// <summary>
        /// Абстрактный класс бонусов
        /// </summary>
        abstract class Bonus : Object
        {
            public Bonus(string type, Point Pos) : base(type, Pos)
            {

            }
            public virtual void GetBonus(Unit unit)
            {

            }
        }

        /// <summary>
        /// Наследуемые классы от абстрактного класса бонусов
        /// </summary>
  
        class Apple : Bonus
        {
            public Apple(Point Pos, double armorBonus,double healthBonus):base(type:"Apple",Pos)
            {
                this.armorBonus = armorBonus;
                this.healthBonus = healthBonus;
            }
            public double armorBonus { get; }
            public double healthBonus { get; }
            public override void GetBonus(Unit user)
            {
                user.Health += healthBonus;
                user.Armor  += armorBonus;
            }
        public double PosicionX()
        {
            return Pos.x;
        }
        public double PosicionY()
        {
            return Pos.x;
        }
    }
        class cherry : Bonus
        {
            public cherry(Point Pos, double speedBonus, double damagehBonus) : base(type: "cherry", Pos)
            {
                this.speedBonus = speedBonus;
                this.damagehBonus = damagehBonus;
            }
            public double speedBonus { get; }
            public double damagehBonus { get; }
            public override void GetBonus(Unit user)
            {
                user.Speed += speedBonus;
                user.DamageUnit += damagehBonus;
            }
        }

        /// <summary>
        /// Классы, содежащие информацию о юнитах на доске.
        /// </summary>
        class Priest : Unit
        {
            public Priest(Point Pos) : base(type: "Priest", Pos, DamageUnit: 5, Health: 100, Armor: 2, Speed: 15)
            {

            }

            public override void Move()
            {
                Random random = new Random();
                int speed = (int)Math.Round(Speed);
                double x = random.Next(0, speed);
                double y = random.Next(0, speed);
                Pos = new Point(x, y);
            }

            public void PowerHero(Unit unit)
            {
                double health = Health;
                if (unit.Health < 30)

                    unit.Treatment(unit);
            }
        }
        class War : Unit
        {
            public War(Point Pos) : base(type: "War", Pos, DamageUnit: 20, Health: 100, Armor:10, Speed: 10)
        {

        }

        public override void Move()
        {
            Random random = new Random();
            int speed = (int)Math.Round(Speed);
            double x = random.Next(0, speed);
            double y = random.Next(0, speed);
            Pos = new Point(x, y);
        }

        public void Rage(Unit unit)
        {
            Console.WriteLine("attak!!!");
            double damage = unit.DamageUnit;
                if (unit.Health < 30)
                    unit.damagetaken(damage);

        }
    }
        class Player :Unit
        {
            public Player(Point Pos) : base(type: "Player", Pos, DamageUnit: 5, Health: 100, Armor: 5, Speed: 5)
            {

            }
              public override void Move()
            {
                Random random = new Random();
                int speed = (int)Math.Round(Speed);
                double x = random.Next(0, speed);
                double y = random.Next(0, speed);
                Pos = new Point(x, y);

            }
        }
        





    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
