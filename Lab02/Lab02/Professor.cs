namespace Lab02
{
    public class Professor : Staff
    {
        public string name { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public float salary { get; set; }

        public override float CalculateWorkload()
        {
            throw new System.NotImplementedException();
        }

        public override string GetViolation(string message)
        {
            throw new System.NotImplementedException();
        }

        public float CalculateSalary()
        {
            return 2;
            //
        }

        public void AddPostGraduateStudent(PostgraduateStudent student)
        {
            //
        }

        public void RequestSupport()
        {
            //
        }
    }
}