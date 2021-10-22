namespace Lab02
{
    public class PostgraduateStudent : Staff
    {
        public string phd_status { get; set; }
        //unfinished fields
        
        public override float CalculateWorkload()
        {
            throw new System.NotImplementedException();
        }

        public override string GetViolation(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}