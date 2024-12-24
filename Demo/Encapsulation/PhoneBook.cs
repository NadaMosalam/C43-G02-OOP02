using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct PhoneBook
    {
        #region Part 05 Encapsulation (Continued) - Indexer

        #region Fields

        private string[] Names;
        private ulong[] Numbers;
        private int size;

        #endregion

        // Getter
        public long GetNumber(string Name)
        {
            if (Names is not null && Numbers is not null)
                for (int i = 0; i < size; i++)
                    if (Name == Names[i])
                        return (long)Numbers[i];
            return -1;
        }

        //Setter
        public long SetNumber(string Name, ulong Value)
        {
            if (Names is not null && Numbers is not null)

                for (int i = 0; i < size; i++)
                    if (Name == Names[i])

                        Numbers[i] = Value;
            return 1;
        }

        //Indexer is a special property [named always with this && can take parameters]
        public long this[string Name]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                    for (int i = 0; i < size; i++)
                        if (Name == Names[i])
                            return (long)Numbers[i];
                return -1;
            }
            set
            {
                if (Names is not null && Numbers is not null)

                    for (int i = 0; i < size; i++)
                        if (Name == Names[i])

                            Numbers[i] = (ulong)value;
                return;
            }
        }

        #region property
        public int Size
        {
            get { return size; }
        }

        #endregion

        #region constructor

        public PhoneBook(int size)
        {
            this.size = size;
            this.Names = new string[size];
            this.Numbers = new ulong[size];
        }

        #endregion

        #region Methods
        public void Addperson(uint index, string name, ulong size)
        {
            if (Names is not null && Numbers is not null && index < size)
            {
                Names[index] = name;
                Numbers[index] = size;
            }
        }
        #endregion



        #endregion
    }
}
