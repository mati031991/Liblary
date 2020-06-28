namespace TestProject
{
    public class Librarian : Person
    {
        private string _employmentDate;
        private double _salary;

        public Librarian() { }
        public Librarian(string forname, string name, string employmentDate, double salary)
        {
            this.Foranme = forname;
            this.Name = name;
            this._employmentDate = employmentDate;
            this._salary = salary;
        }
    }
}
