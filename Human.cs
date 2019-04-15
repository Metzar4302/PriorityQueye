namespace PriorityQueye
{
    public class Human
    {
        public int Priority { get; set; }
        
        protected Human(int prior)
        {
            Priority = prior;
        }
    }
}