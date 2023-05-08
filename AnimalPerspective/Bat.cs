namespace AnimalPerspective
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples { get => 2; }
        public int NumberOfWings { get => 2; }
        public override string Sound()
        {
            return "Bat sound";
        }
    }
}