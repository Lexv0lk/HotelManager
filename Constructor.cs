using System;
using System.Windows.Forms;

namespace HotelManager
{
    public abstract class Constructor<Item> : Form
    {
        public abstract event Action<Item> ItemCreated;
    }
}
