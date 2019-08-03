/* 
Создайте класс Wizard, у которого есть свойства:
•	список известных ему заклинаний
•	текущее состояние (объект типа State), притом, если на волшебника 
были применены все виды заклинаний, он умирает, состояние сменяется на IsDead;
Создайте абстрактный класс Spell и абстрактный метод CastSpell(Wizard wizard), 
возвращающий (в переопределенных классах разумеется), 
как изменилось состояние волшебника.
Создайте перечисление State с элементами: SetOnFire, Drowned, 
ThrownIntoTheAir, Buried, IsDead.
Создайте классы, наследуемые от Spell:
FireSpell, переопределите метод CastSpell, изменив 
состояние волшебника, переданного в параметре (ставьте бинарные флаги).
Аналогично AirSpell, WaterSpell, EarthSpell.
В основной программе смоделируйте битву двух волшебников. 
Каждый из них знает все типы заклинаний.
Проведите три последовательных дуэли, в которых волшебники 
последовательно применяют случайное заклинание из ему известных. 
Выводите на экран сообщения об изменении состояния волшебника. 
Прерывайте схватку досрочно и выводите сообщение о том, кто 
из волшебников победил в случае, если кто-то из них умер.
В конце программы выведите конечное состояние каждого из волшебников.
*/
using System;
using System.Collections.Generic;

namespace Task_1
{
    public class Wizard
    {
        // известные заклинания храним в списке
        public List<Spell> spells { get; set; }
        private State state;
        // свойство для текущего состояния
        public State State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                IsDead();
            }
        }
        // были ли на волшебника применены все виды заклинаний
        private void IsDead()
        {
            if (this.State == (State.SetOnFire | State.Drowned
                | State.ThrownIntoTheAir | State.Buried))
                this.State = State.IsDead;
        }
        // конструктор
        public Wizard(List<Spell> input)
        {
            spells = input;
        }
    }

    [Flags]
    public enum State
    {
        SetOnFire = 1, Drowned = 2, ThrownIntoTheAir = 4,
        Buried = 8, IsDead = 16
    }
    // класс заклинаний
    public abstract class Spell
    {
        public abstract State CastSpell(Wizard wizard);
    }
    // класс-наследник с переопределённым методом CastSpell
    public class FireSpell : Spell
    {
        public override State CastSpell(Wizard wizard)
        {
            wizard.State |= State.SetOnFire;
            return wizard.State;
        }
    }

    public class WaterSpell : Spell
    {
        public override State CastSpell(Wizard wizard)
        {
            wizard.State |= State.Drowned;
            return wizard.State;
        }
    }

    public class AirSpell : Spell
    {
        public override State CastSpell(Wizard wizard)
        {
            wizard.State |= State.ThrownIntoTheAir;
            return wizard.State;
        }
    }

    public class EarthSpell : Spell
    {
        public override State CastSpell(Wizard wizard)
        {
            wizard.State |= State.Buried;
            return wizard.State;
        }
    }

    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            do
            {
                List<Spell> spells = new List<Spell>();
                spells.AddRange(new Spell[] { new FireSpell(), new AirSpell(),
                    new WaterSpell(), new EarthSpell() });

                Wizard wizard_1 = new Wizard(spells);
                Wizard wizard_2 = new Wizard(spells);

                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        // обнуляем состояния
                        wizard_1.State = 0; wizard_2.State = 0;
                        do
                        {
                            // wizard_1 применяет на wizard_2 случайное заклинание
                            wizard_1.spells[random.Next(0, 4)].CastSpell(wizard_2);
                            Console.WriteLine($"состояние wizard_2 стало \t {wizard_2.State}");
                            if (wizard_2.State == State.IsDead)
                                break;
                            wizard_2.spells[random.Next(0, 4)].CastSpell(wizard_1);
                            Console.WriteLine($"состояние wizard_1 стало \t {wizard_1.State}");
                            if (wizard_1.State == State.IsDead)
                                break;
                        } while (true);
                        Console.WriteLine($"Конечные состояния: \n" + $"wizard_1.state = {wizard_1.State} \n" +
                            $"wizard_2.state = {wizard_2.State}");
                    }
                } 
                // ловим исключения
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
