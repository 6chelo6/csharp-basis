using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator<StateObject> current = new Originator<StateObject>();
            current.SetState(new StateObject { Id = 0, Name = "Object 0" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject { Id = 1, Name = "Object 1" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject { Id = 2, Name = "Object 2" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject { Id = 3, Name = "Object 3" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            CareTaker<StateObject>.RestoreState(current, 1);
            current.ShowState();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// This is the object to keep state in memento.
    /// It needs to implement IClonable interface to provide a deep copy object
    /// otherwise the memento could be filled with shallow copies with references to the same object in memory.
    /// </summary>
    public class StateObject : ICloneable
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public object Clone()
        {
            return new StateObject
            {
                Id = this.Id,
                Name = this.Name
            };
        }

        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}";
        }
    }

    /// <summary>
    /// This is the Memento generic structure to wrap the objects to keep state.
    /// </summary>
    /// <typeparam name="T">Generic parameter</typeparam>
    public class Memento<T> where T : ICloneable
    {
        private T StateObj { get; set; }

        public T GetState()
        {
            return StateObj;
        }

        public void SetState(T stateObj)
        {
            StateObj = (T)stateObj.Clone();
        }
    }

    /// <summary>
    /// This is the generic structure that will wrap the most current object state with the option to restore an object state.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Originator<T> where T : ICloneable
    {
        private T StateObj { get; set; }

        public Memento<T> CreateMemento()
        {
            Memento<T> m = new Memento<T>();
            m.SetState(this.StateObj);
            return m;
        }

        public void RestoreMemento(Memento<T> m)
        {
            this.StateObj = m.GetState();
        }

        public void SetState(T state)
        {
            this.StateObj = state;
        }

        public void ShowState()
        {
            Console.WriteLine(this.StateObj.ToString());
        }
    }

    /// <summary>
    /// This is the structure that will manage the objects states through a list of Memento.
    /// The client uses this structure to save and restore states.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class CareTaker<T> where T : ICloneable
    {
        private static List<Memento<T>> mementoList = new List<Memento<T>>();

        public static void SaveState(Originator<T> orig)
        {
            mementoList.Add(orig.CreateMemento());
        }

        public static void RestoreState(Originator<T> orig, int checkpoint)
        {
            orig.RestoreMemento(mementoList[checkpoint]);
        }
    }
}
