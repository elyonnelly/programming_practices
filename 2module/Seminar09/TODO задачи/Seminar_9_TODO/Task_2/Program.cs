/* 

*/
using System;
using System.Collections.Generic;

namespace Task_2
{
    public class Wizard
    {
        public List<Spell> spells { get; set; }

        public State State { get; set; }

        public Wizard(List<Spell> input)
        {
            spells = input;
            State = State.None;
        }
    }

    public enum State : uint
    {
        SetOnFire = 0x01, Drowned = 0x02, ThrownIntoTheAir = 0x04,
        Buried = 0x08, IsDead, None
    }

    public abstract class Spell
    {
        public abstract State CastSpell(Wizard wizard);
        public bool IsDead(Wizard wizard)
        {
            return wizard.State.HasFlag(State.Buried);
        }
    }

    public class FireSpell : Spell
    {
        public override State CastSpell(Wizard wizard)
        {
            if (IsDead(wizard))
                return State.IsDead;
            wizard.State = State.SetOnFire;
            return State.SetOnFire;
        }
    }

    public class AirSpell : Spell
    {
        public override State CastSpell(Wizard wizard)
        {
            if (IsDead(wizard))
                return State.IsDead;
            wizard.State = State.ThrownIntoTheAir;
            return State.ThrownIntoTheAir;
        }
    }

    public class WaterSpell : Spell
    {
        public override State CastSpell(Wizard wizard)
        {
            if (IsDead(wizard))
                return State.IsDead;
            wizard.State = State.Drowned;
            return State.Drowned;
        }
    }

    public class EarthSpell : Spell
    {
        public override State CastSpell(Wizard wizard)
        {
            if (IsDead(wizard))
                return State.IsDead;
            wizard.State = State.Buried;
            return State.Buried;
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
                spells.AddRange(new Spell[] { new FireSpell(), new AirSpell(), new WaterSpell(), new EarthSpell() });

                Wizard wizard_1 = new Wizard(spells);
                Wizard wizard_2 = new Wizard(spells);

                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        do
                        {
                            State state = wizard_1.spells[random.Next(0, 4)].CastSpell(wizard_2);
                            Console.WriteLine($"состояние wizard_2 стало \t {state}");
                            if (wizard_2.State == State.IsDead)
                                break;
                            State state_2 = wizard_2.spells[random.Next(0, 4)].CastSpell(wizard_1);
                            Console.WriteLine($"состояние wizard_1 стало \t {state_2}");
                            if (wizard_1.State == State.IsDead)
                                break;
                        } while (true);
                        Console.WriteLine($"Конечные состояния: \n" + $"wizard_1.state = {wizard_1.State} \n" +
                            $"wizard_2.state = {wizard_2.State}");
                        wizard_1.State = State.None; wizard_2.State = State.None;

                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("Для выхода из программы нажмите Escape.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
