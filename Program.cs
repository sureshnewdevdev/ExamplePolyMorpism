namespace ExamplePolyMorpism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Draft
            //UGStudent uGStudent = new UGStudent();
            //uGStudent.Id = 1;
            //uGStudent.Name = "Test";

            //PGStudent pgStudent = new PGStudent();

            //Account account = new Account() 
            //                { 
            //                    Id=1, 
            //                    Name="Ram Account" 
            //                };

            //CreditAccount creditAccount = new CreditAccount()
            //{
            //    Id = 1,
            //    Name = "Ram Account",
            //    CreditLimt = 1000
            //};

            //account = creditAccount;

            //Account parentAccount = new CreditAccount() { 
            //    Id=100,
            //    Name="Balu",
            //    CreditLimt = 1000
            //};

            #endregion

            UGStudent student = new UGStudent();
            student.Id = 100;
            student.Name = "Ravi";

            string result = DisplayDetails(student);
            Console.WriteLine(result);

            ITStuduent iTStuduent = new ITStuduent();
            iTStuduent.Id = 200;
            iTStuduent.Name = "Balu";

            result = DisplayDetails(iTStuduent);
            Console.WriteLine(result);
        }

        public static string DisplayDetails(Student student)// Parent Type
        {
            return student.Name;
        }
    }
}

// Create class called
// Account - Id, name (parent)
// CrAccount = Id, name, CreditLimit

