namespace _007_AdapterPattern
{
    public class TurkeyAdapter: IDuck //Target interface
    {
        private ITurkey _turkey; //Adaptee interface
        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void DuckFly()
        {
            _turkey.Fly();
        }

        public void DuckQuack()
        {
            _turkey.Gobble();
        }
    }
}
