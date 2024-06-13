namespace Bil_App
{
    internal class Car
    {
        Random random = new Random();
        internal string _sprite {  get; private set; }
        internal string _name { get; private set; }
        internal int _distanceDriven { get;  private set; }
        internal int _speed { get; private set; }

        internal string _avatar => $@"Navn: {_name}
Distanse: {_distanceDriven} / {Gamestate.finishLine}
{_sprite}";

        internal Car(string sprite, string name, int distanceDriven, int speed)
        {
            _sprite = sprite;
            _name = name;
            _distanceDriven = distanceDriven;
            _speed = speed;
        }

        internal void drive()
        {
            _distanceDriven += _speed;
        }

        internal void randomDrive()
        {
             _distanceDriven += random.Next(60, 200);
        }

        internal void accelerate(int increase)
        {
            _speed += increase;
        }
    }
}
