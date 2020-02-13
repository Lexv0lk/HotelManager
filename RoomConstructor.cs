using System;

namespace HotelManager
{
    public partial class RoomConstructor : Constructor<Room>
    {
        public RoomConstructor()
        {
            InitializeComponent();
        }

        public RoomConstructor(int newId) : this()
        {
            _newId = newId;
        }

        public RoomConstructor(Room existingRoom) : this()
        {
            _existingRoom = existingRoom;

            _numberInput.Value = _existingRoom.Number;
            _roomsInput.Value = _existingRoom.InnerRoomsCount;
            _squareinput.Value = (decimal)_existingRoom.Area;

            _confirmButton.Text = "Изменить";
        }

        private int _newId;
        private Room _existingRoom;

        public override event Action<Room> ItemCreated;

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int number = (int)_numberInput.Value;
            int rooms = (int)_roomsInput.Value;
            float area = (float)_squareinput.Value;

            if (_existingRoom == null)
            {
                Room newRoom = new Room(number, rooms, area, _newId, Administrator.Authorized.Hotel);
                ItemCreated?.Invoke(newRoom);
            }
            else
            {
                _existingRoom.Number = number;
                _existingRoom.InnerRoomsCount = rooms;
                _existingRoom.Area = area;
            }

            Close();
        }
    }
}
